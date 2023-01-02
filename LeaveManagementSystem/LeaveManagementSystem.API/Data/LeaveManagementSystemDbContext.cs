using LeaveManagementSystem.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagementSystem.API.Data
{
    public class LeaveManagementSystemDbContext:DbContext
    {
        public LeaveManagementSystemDbContext
            (DbContextOptions<LeaveManagementSystemDbContext> options):base(options) 
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Leave> Leaves { get; set; }

        public DbSet<LeaveStatus> LeaveStatuses { get; set; }
    }
}
