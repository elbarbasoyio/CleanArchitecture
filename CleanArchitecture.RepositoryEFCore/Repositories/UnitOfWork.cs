using CleanArchitecture.Entities.Interfaces;
using CleanArchitecture.RepositoryEFCore.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.RepositoryEFCore.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly CleanArchitectureContext _context;
        public UnitOfWork(CleanArchitectureContext context)
        {
            _context = context;
        }
        public Task<int> SaveChanges()
        {
            return _context.SaveChangesAsync();
        }
    }
}
