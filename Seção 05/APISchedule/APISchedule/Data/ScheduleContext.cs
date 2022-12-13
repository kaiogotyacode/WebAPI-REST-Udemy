using APISchedule.Models;
using Microsoft.EntityFrameworkCore;

namespace APISchedule.Data
{
    public class ScheduleContext : DbContext
    {       
        public DbSet<Schedule>? Schedules { get; set; }
        public DbSet<User>? Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Password=12345678;User ID=sa;Initial Catalog=DBSchedule;Data Source=DESKTOP-4D49KJE;trustServerCertificate=true");
        }

    }
}
