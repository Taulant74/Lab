namespace backendLab.Models
{
    public class Review
    {
        public int ReviewID { get; set; }
        public int HotelID { get; set; }
        public int GuestID { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime ReviewDate { get; set; }

        // Relationships
        public Hotel Hotel { get; set; }
        public Guest Guest { get; set; }
    }

}
