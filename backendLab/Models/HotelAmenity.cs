namespace backendLab.Models
{
    public class HotelAmenity
    {
        public int HotelID { get; set; }
        public int AmenityID { get; set; }

        // Relationships
        public Hotel Hotel { get; set; }
        public Amenity Amenity { get; set; }
    }

}
