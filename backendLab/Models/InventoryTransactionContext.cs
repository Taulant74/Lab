using Microsoft.EntityFrameworkCore;

namespace backendLab.Models
{
    public class InventoryTransactionContext : DbContext
    {
        public InventoryTransactionContext(DbContextOptions<InventoryTransactionContext> options) : base(options)
        {
        }

        public DbSet<InventoryTransaction> InventoryTransactions { get; set; }
    }

}
