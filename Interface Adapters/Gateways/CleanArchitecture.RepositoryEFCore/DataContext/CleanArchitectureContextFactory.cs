using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace CleanArchitecture.RepositoryEFCore.DataContext
{
    public class CleanArchitectureContextFactory : IDesignTimeDbContextFactory<CleanArchitectureContext>
    {
        public CleanArchitectureContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CleanArchitectureContext>();
            optionsBuilder.UseSqlServer("Server=localhost;Database=CleanArchitectureDB;Trusted_Connection=True;TrustServerCertificate=True;");
            return new CleanArchitectureContext(optionsBuilder.Options);
        }
    }
}
