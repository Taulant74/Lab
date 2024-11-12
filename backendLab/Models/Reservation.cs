namespace backendLab.Models
{
    public class Reservation
    {
        public int ReservationID { get; set; }
        public int GuestID { get; set; }
        public int HotelID { get; set; }
        public int RoomID { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public decimal TotalPrice { get; set; }

        // Relationships
        public Guest Guest { get; set; }
        public Hotel Hotel { get; set; }
        public Room Room { get; set; }
        public ICollection<Invoice> Invoices { get; set; }
    }

}
