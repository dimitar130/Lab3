using Lab3.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Lab3.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Patient> Patients {  get; set; } 
        public DbSet<Hospital> Hospitals {  get; set; } 
        public DbSet<Doctor> Doctors {  get; set; } 
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
