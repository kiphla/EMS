using EMS.Core.Models.BaseModels;

namespace EMS.Core.Models
{
    public class Species
    {
        public int Id { get; set; }
        public string SpeciesName { get; set; }
    }

    public class SpeciesData : EnvironmentalData
    {
        public int SpeciesId { get; set; }
        public int Population { get; set; }
    }
}
