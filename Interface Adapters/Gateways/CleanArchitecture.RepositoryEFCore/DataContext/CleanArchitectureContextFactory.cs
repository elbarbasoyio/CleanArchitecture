using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
