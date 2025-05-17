using CleanArchitecture.Entities.Interfaces;
using CleanArchitecture.Entities.POCOs;
using CleanArchitecture.RepositoryEFCore.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
