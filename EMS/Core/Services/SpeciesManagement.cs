using EMS.Core.Models;
using EMS.Core.Repositories;

namespace EMS.Core.Services {
    public class SpeciesManagement {
        private readonly SpeciesRepository _speciesRepository;
        private readonly SpeciesDataRepository _speciesDataRepository;
        private readonly NotificationsRepository _notificationsRepository;

        public SpeciesManagement() {
            _speciesRepository = new SpeciesRepository();
            _speciesDataRepository = new SpeciesDataRepository();
            _notificationsRepository = new NotificationsRepository();
        }

        public List<Species> GetAllSpecies() {
            return _speciesRepository.GetAll();
        }

        public void AddSpeciesData(SpeciesData speciesData) {
            _speciesDataRepository.Add(speciesData);
            CheckSpeciesConditionsAndNotify(speciesData);
        }

        public List<SpeciesData> GetAllSpeciesData() {
            return _speciesDataRepository.GetAll();
        }

        public List<SpeciesData> GetSpeciesDataBySpecies(int speciesId) {
            return _speciesDataRepository.GetAll()
                .Where(s => s.speciesID == speciesId)
                .OrderBy(s => s.date)
                .ToList();
        }

        public List<SpeciesData> GetSpeciesDataInRange(DateTime startDate, DateTime endDate) {
            return _speciesDataRepository.GetAll()
                .Where(s => s.date >= startDate && s.date <= endDate)
                .OrderBy(s => s.date)
                .ToList();
        }

        private void CheckSpeciesConditionsAndNotify(SpeciesData speciesData) {
            var species = _speciesRepository.GetById(speciesData.speciesID);
            if (species == null) return;

            // Check population trends
            var recentData = GetSpeciesDataBySpecies(speciesData.speciesID)
                .OrderByDescending(s => s.date)
                .Take(5)
                .ToList();

            if (recentData.Count >= 2) {
                var populationTrend = CalculatePopulationTrend(recentData);
                if (populationTrend < -0.2) // 20% decline
                {
                    CreateSpeciesAlert($"{species.speciesName} Population Decline",
                        $"Significant population decline detected for {species.speciesName}. Current count: {speciesData.populationCount}");
                }
            }

            // Check health concerns
            if (!string.IsNullOrEmpty(speciesData.healthConcerns)) {
                CreateSpeciesAlert($"{species.speciesName} Health Alert",
                    $"Health concerns reported for {species.speciesName}: {speciesData.healthConcerns}");
            }
        }

        private double CalculatePopulationTrend(List<SpeciesData> data) {
            if (data.Count < 2) return 0;

            var oldest = data.Last().populationCount;
            var newest = data.First().populationCount;

            return (newest - oldest) / (double)oldest;
        }

        private void CreateSpeciesAlert(string title, string description) {
            var notification = new Notification {
                userID = 1, // TODO: Get current user ID
                creationDate = DateTime.Now,
                terminationDate = DateTime.Now.AddDays(7),
                isActive = true,
                title = title,
                description = description
            };

            _notificationsRepository.Add(notification);
        }
    }
}
