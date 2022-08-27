using HMS_API.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HMS_API.DAL
{
    public class AppDbContext:IdentityDbContext<ApiUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

       

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Drug> Drugs { get; set; }
        public DbSet<Ward> Wards { get; set; }
    }
}
