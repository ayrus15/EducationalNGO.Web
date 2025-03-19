using System.Data.Entity;
using EducationalNGO.Models;

namespace EducationalNGO.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() 
            : base("name=DefaultConnection")
        {
        }

        public DbSet<Beneficiary> Beneficiaries { get; set; }
        public DbSet<Volunteer> Volunteers { get; set; }
        public DbSet<Donation> Donations { get; set; }
        public DbSet<Event> Events { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}