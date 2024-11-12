using Microsoft.EntityFrameworkCore;

namespace backendLab.Models
{
    public class EmployeeScheduleContext : DbContext
    {
        public EmployeeScheduleContext(DbContextOptions<EmployeeScheduleContext> options) : base(options)
        {
        }

        public DbSet<EmployeeSchedule> EmployeeSchedules { get; set; }
    }

}
