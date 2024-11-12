namespace backendLab.Models
{
    public class MaintenanceRequest
    {
        public int RequestID { get; set; }
        public int HotelID { get; set; }
        public string Description { get; set; }
        public DateTime RequestDate { get; set; }
        public string Priority { get; set; }
        public string Status { get; set; }

        // Relationships
        public Hotel Hotel { get; set; }
    }

}
