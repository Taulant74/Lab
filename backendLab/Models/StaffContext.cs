using Microsoft.EntityFrameworkCore;

namespace backendLab.Models
{
    public class StaffContext : DbContext
    {
        public StaffContext(DbContextOptions<StaffContext> options) : base(options)
        {
        }

        public DbSet<Staff> Staff { get; set; }
    }

}
