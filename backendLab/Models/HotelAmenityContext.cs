using Microsoft.EntityFrameworkCore;

namespace backendLab.Models
{
    public class HotelAmenityContext : DbContext
    {
        public HotelAmenityContext(DbContextOptions<HotelAmenityContext> options) : base(options)
        {
        }

        public DbSet<HotelAmenity> HotelAmenities { get; set; }
    }

}
