using EMS.Core.Services;
using System;
using System.IO;

namespace EMS.Core.Services
{
    public class ExportService
    {
        private readonly SoilDataManager _soilDataManager;
        private readonly HydrologyDataManager _hydrologyDataManager;
        private readonly SpeciesDataManager _speciesDataManager;

        public ExportService()
        {
            _soilDataManager = new SoilDataManager();
            _hydrologyDataManager = new HydrologyDataManager();
            _speciesDataManager = new SpeciesDataManager();
        }

        public bool ExportSoilDataToCsv(string filePath, DateTime? startDate, DateTime? endDate, string location)
        {
            try
            {
                string csvData = _soilDataManager.ExportToCsv(startDate, endDate, location);
                File.WriteAllText(filePath, csvData);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool ExportHydrologyDataToCsv(string filePath, DateTime? startDate, DateTime? endDate, string location)
        {
            try
            {
                string csvData = _hydrologyDataManager.ExportToCsv(startDate, endDate, location);
                File.WriteAllText(filePath, csvData);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool ExportSpeciesDataToCsv(string filePath, DateTime? startDate, DateTime? endDate, string location)
        {
            try
            {
                string csvData = _speciesDataManager.ExportToCsv(startDate, endDate, location);
                File.WriteAllText(filePath, csvData);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
