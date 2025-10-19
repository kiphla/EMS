using EMS.Core.Models.BaseModels;

namespace EMS.Core.Models
{
    public class SoilData : EnvironmentalData
    {
        public double PHLevel { get; set; }
        public double MoistureLevel { get; set; }
        public double NitrogenLevel { get; set; }
        public double PhosphorusLevel { get; set; }
        public double SulphurLevel { get; set; }
    }
}
