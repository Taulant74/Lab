using Microsoft.EntityFrameworkCore;

namespace backendLab.Models
{
    public class EventBookingContext : DbContext
    {
        public EventBookingContext(DbContextOptions<EventBookingContext> options) : base(options)
        {
        }

        public DbSet<EventBooking> EventBookings { get; set; }
    }

}
