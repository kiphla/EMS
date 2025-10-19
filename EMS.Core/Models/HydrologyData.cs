using EMS.Core.Models.BaseModels;

namespace EMS.Core.Models
{
    public class HydrologyData : EnvironmentalData
    {
        public double WaterLevel { get; set; }
        public double Rainfall { get; set; }
        public double Salinity { get; set; }
        public double PHLevel { get; set; }
        public double DissolvedOxygen { get; set; }
        public double Turbidity { get; set; }
        public double Temperature { get; set; }
        public double PH { get; set; }
    }
}
