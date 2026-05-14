using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Snape_Lite.Data;

namespace Snape_Lite.Data
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();

            optionsBuilder.UseMySql(
                "server=localhost;port=3306;database=SnapeLiteDB;user=root;password=16072003",
                ServerVersion.AutoDetect("server=localhost;port=3306;database=SnapeLiteDB;user=root;password=16072003")
            );

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
