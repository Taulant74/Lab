using Microsoft.EntityFrameworkCore;

namespace backendLab.Models
{
    public class MaintenanceRequestContext : DbContext
    {
        public MaintenanceRequestContext(DbContextOptions<MaintenanceRequestContext> options) : base(options)
        {
        }

        public DbSet<MaintenanceRequest> MaintenanceRequests { get; set; }
    }

}
