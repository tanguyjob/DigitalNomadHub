using Microsoft.EntityFrameworkCore;

namespace DigitalNomadHub.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) 
        {
        }
    }
}
