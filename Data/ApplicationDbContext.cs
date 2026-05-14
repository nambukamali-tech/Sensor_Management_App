using Microsoft.EntityFrameworkCore;
using Snape_Lite.Models;

namespace Snape_Lite.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Sensors> Sensors { get; set; }
    }
}
