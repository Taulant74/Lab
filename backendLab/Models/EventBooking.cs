namespace backendLab.Models
{
    public class EventBooking
    {
        public int EventBookingID { get; set; }
        public int EventID { get; set; }
        public int GuestID { get; set; }

        // Relationships
        public Event Event { get; set; }
        public Guest Guest { get; set; }
    }

}
