using DigitalNomadHub.Models;
using Microsoft.EntityFrameworkCore;

namespace DigitalNomadHub.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Country>().HasData(
                new Country { CountryId = 1, Name = "Thaïland" },
                new Country { CountryId = 2, Name = "Vietnam" },
                new Country { CountryId= 3, Name="Laos"}
                );
        }
    }
}
