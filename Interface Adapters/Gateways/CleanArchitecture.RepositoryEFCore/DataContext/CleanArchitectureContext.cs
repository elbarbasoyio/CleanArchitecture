using CleanArchitecture.Entities.POCOs;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.RepositoryEFCore.DataContext
{
    public class CleanArchitectureContext : DbContext
    {
        public CleanArchitectureContext(DbContextOptions<CleanArchitectureContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
    }
}
