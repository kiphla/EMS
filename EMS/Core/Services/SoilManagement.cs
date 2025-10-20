using EMS.Core.Models;
using EMS.Core.Repositories;

namespace EMS.Core.Services {
    public class SoilManagement {
        private readonly SoilRepository _soilRepository;
        private readonly NotificationsRepository _notificationsRepository;

        public SoilManagement() {
            _soilRepository = new SoilRepository();
            _notificationsRepository = new NotificationsRepository();
        }

        public void AddSoilData(SoilData soilData) {
            _soilRepository.Add(soilData);
            CheckSoilConditionsAndNotify(soilData);
        }

        public List<SoilData> GetAllSoilData() {
            return _soilRepository.GetAll();
        }

        public SoilData? GetSoilDataById(int sampleId) {
            return _soilRepository.GetById(sampleId);
        }

        public List<SoilData> GetSoilDataInRange(DateTime startDate, DateTime endDate) {
            return _soilRepository.GetAll()
                .Where(s => s.date >= startDate && s.date <= endDate)
                .OrderBy(s => s.date)
                .ToList();
        }

        public Dictionary<string, double> CalculateAverages(List<SoilData> soilData) {
            if (soilData == null || !soilData.Any())
                return new Dictionary<string, double>();

            return new Dictionary<string, double>
            {
                { "pH", soilData.Average(s => s.pH) },
                { "Density", soilData.Average(s => s.density) },
                { "Moisture", soilData.Average(s => s.moisture) },
                { "Nitrogen", soilData.Average(s => s.nitrogen) },
                { "OrganicMatter", soilData.Average(s => s.organicMatter) },
                { "Firmness", soilData.Average(s => s.firmness) }
            };
        }

        public Dictionary<string, (double Min, double Max)> CalculateRanges(List<SoilData> soilData) {
            if (soilData == null || !soilData.Any())
                return new Dictionary<string, (double Min, double Max)>();

            return new Dictionary<string, (double Min, double Max)>
            {
                { "pH", (soilData.Min(s => s.pH), soilData.Max(s => s.pH)) },
                { "Density", (soilData.Min(s => s.density), soilData.Max(s => s.density)) },
                { "Moisture", (soilData.Min(s => s.moisture), soilData.Max(s => s.moisture)) },
                { "Nitrogen", (soilData.Min(s => s.nitrogen), soilData.Max(s => s.nitrogen)) },
                { "OrganicMatter", (soilData.Min(s => s.organicMatter), soilData.Max(s => s.organicMatter)) },
                { "Firmness", (soilData.Min(s => s.firmness), soilData.Max(s => s.firmness)) }
            };
        }

        private void CheckSoilConditionsAndNotify(SoilData soilData) {
            var notifications = new List<(string Title, string Description)>();

            // Check pH levels (ideal range 6.0-7.5)
            if (soilData.pH < 6.0)
                notifications.Add(("Low Soil pH Alert", $"Soil pH is {soilData.pH}, which is below the recommended minimum of 6.0"));
            else if (soilData.pH > 7.5)
                notifications.Add(("High Soil pH Alert", $"Soil pH is {soilData.pH}, which is above the recommended maximum of 7.5"));

            // Check moisture levels (ideal range 20%-60%)
            if (soilData.moisture < 0.20)
                notifications.Add(("Low Soil Moisture Alert", $"Soil moisture is {soilData.moisture * 100}%, which indicates drought conditions"));
            else if (soilData.moisture > 0.60)
                notifications.Add(("High Soil Moisture Alert", $"Soil moisture is {soilData.moisture * 100}%, which indicates potential waterlogging"));

            // Check nitrogen levels (ideal minimum 0.2%)
            if (soilData.nitrogen < 0.2)
                notifications.Add(("Low Nitrogen Alert", $"Soil nitrogen content is {soilData.nitrogen * 100}%, which is below the recommended minimum"));

            // Check organic matter (ideal minimum 3%)
            if (soilData.organicMatter < 3.0)
                notifications.Add(("Low Organic Matter Alert", $"Soil organic matter is {soilData.organicMatter}%, which is below the recommended minimum"));

            // Create notifications
            foreach (var (title, description) in notifications) {
                var notification = new Notification {
                    title = title,
                    description = description,
                    creationDate = DateTime.Now,
                    isActive = true
                };
                _notificationsRepository.Add(notification);
            }
        }

        public List<(DateTime Date, double Value)> GetMetricTrend(string metricName, DateTime startDate, DateTime endDate) {
            var data = GetSoilDataInRange(startDate, endDate);
            return data.Select(s => (s.date, GetMetricValue(s, metricName))).ToList();
        }

        private double GetMetricValue(SoilData soilData, string metricName) {
            return metricName.ToLower() switch {
                "ph" => soilData.pH,
                "density" => soilData.density,
                "moisture" => soilData.moisture,
                "nitrogen" => soilData.nitrogen,
                "organicmatter" => soilData.organicMatter,
                "firmness" => soilData.firmness,
                _ => throw new ArgumentException($"Unknown metric: {metricName}")
            };
        }

        public void UpdateSoilData(SoilData soilData) {
            _soilRepository.Update(soilData);
            CheckSoilConditionsAndNotify(soilData);
        }

        public void DeleteSoilData(int sampleId) {
            _soilRepository.Delete(sampleId);
        }
    }
}
