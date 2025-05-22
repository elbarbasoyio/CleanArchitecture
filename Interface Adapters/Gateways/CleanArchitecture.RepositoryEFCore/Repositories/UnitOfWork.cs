using CleanArchitecture.Entities.Interfaces;
using CleanArchitecture.RepositoryEFCore.DataContext;

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
