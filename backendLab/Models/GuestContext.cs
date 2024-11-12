using Microsoft.EntityFrameworkCore;

namespace backendLab.Models
{
    public class GuestContext : DbContext
    {
        public GuestContext(DbContextOptions<GuestContext> options) : base(options)
        {
        }

        public DbSet<Guest> Guests { get; set; }
    }

}
