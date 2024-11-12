using Microsoft.EntityFrameworkCore;

namespace backendLab.Models
{
    public class PaymentContext : DbContext
    {
        public PaymentContext(DbContextOptions<PaymentContext> options) : base(options)
        {
        }

        public DbSet<Payment> Payments { get; set; }
    }

}
