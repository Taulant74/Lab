using Microsoft.EntityFrameworkCore;

namespace backendLab.Models
{
    public class SupplierContext : DbContext
    {
        public SupplierContext(DbContextOptions<SupplierContext> options) : base(options)
        {
        }

        public DbSet<Supplier> Suppliers { get; set; }
    }

}
