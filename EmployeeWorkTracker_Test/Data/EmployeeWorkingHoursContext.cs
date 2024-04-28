using EmployeeWorkTracker_Test.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeWorkTracker_Test.Data
{
    public class EmployeeWorkingHoursContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public EmployeeWorkingHoursContext(DbContextOptions options, IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<WorkingHours> WorkingHours { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("EmployeeWorkTracker"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasData(new
                {
                    Id = 1,
                    FirstName = "Tomislav",
                    LastName = "Marinković",
                    CreationTime = DateTime.Now,
                    LastUpdate = DateTime.Now
                }, new
                {
                    Id = 2,
                    FirstName = "Marina",
                    LastName = "Perović",
                    CreationTime = DateTime.Now.AddDays(-3),
                    LastUpdate = DateTime.Now
                }, new
                {
                    Id = 3,
                    FirstName = "Petra",
                    LastName = "Božinović",
                    CreationTime = DateTime.Now.AddHours(-95),
                    LastUpdate = DateTime.Now
                }, new
                {
                    Id = 4,
                    FirstName = "Mario",
                    LastName = "Došen",
                    CreationTime = DateTime.Now.AddHours(-195),
                    LastUpdate = DateTime.Now
                }, new
                {
                    Id = 5,
                    FirstName = "Ozren",
                    LastName = "Bogdan",
                    CreationTime = DateTime.Now.AddHours(-175),
                    LastUpdate = DateTime.Now
                });
            //base.OnModelCreating(modelBuilder);
            //this.Database.EnsureCreated();
        }
    }
}
