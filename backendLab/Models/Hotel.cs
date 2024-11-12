using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.Extensions.Logging;

namespace backendLab.Models
{
    public class Hotel
    {
        public int HotelID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        // Relationships
        public ICollection<Room> Rooms { get; set; }
        public ICollection<Staff> Staff { get; set; }
        public ICollection<Inventory> Inventories { get; set; }
        public ICollection<HotelAmenity> HotelAmenities { get; set; }
        public ICollection<MaintenanceRequest> MaintenanceRequests { get; set; }
        public ICollection<Event> Events { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }

}
