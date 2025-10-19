namespace EMS.Core.Models
{
    public class Notification
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsOngoing { get; set; }
        public bool IsActive { get; set; }
    }
}
