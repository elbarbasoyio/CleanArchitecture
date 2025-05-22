using CleanArchitecture.Entities.Interfaces;
using CleanArchitecture.Entities.POCOs;
using CleanArchitecture.RepositoryEFCore.DataContext;

namespace CleanArchitecture.RepositoryEFCore.Repositories
{
    public class ProductRepository : IProductRepository
    {
        readonly CleanArchitectureContext _context;
        public ProductRepository(CleanArchitectureContext context)
        {
            _context = context;
        }
        public void CreateProduct(Product product)
        {
            _context.Add(product);
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _context.Products;
        }
    }
}
