using CleanArchitecture.Entities.POCOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
