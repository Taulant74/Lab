namespace backendLab.Models
{
    public class Guest
    {
        public int? GuestID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string?  Email { get; set; }
        public string? Phone { get; set; }
        public string? Passi { get; set; }


        // Relationships
        public ICollection<Reservation> Reservations { get; set; }
        public ICollection<Feedback> Feedbacks { get; set; }
        public ICollection<EventBooking> EventBookings { get; set; }
    }

}
