namespace EMS.Core.Models.BaseModels
{
    public abstract class EnvironmentalData
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public string Location { get; set; }
    }
}