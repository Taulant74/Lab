namespace backendLab.Models
{
    public class Event
    {
        public int EventID { get; set; }
        public int HotelID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        // Relationships
        public Hotel Hotel { get; set; }
        public ICollection<EventBooking> EventBookings { get; set; }
    }

}
