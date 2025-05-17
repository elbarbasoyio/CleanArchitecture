using CleanArchitecture.Entities.Interfaces;
using CleanArchitecture.UseCasesPorts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.UseCases.GetAllProducts
{
    public class GetAllProductsInteractor : IGetAllProductsInputPort
    {
        readonly IProductRepository _productRepository;
        readonly IGetAllProductsOutputPort _outputPort;
        public GetAllProductsInteractor(IProductRepository productRepository, IGetAllProductsOutputPort outputPort)
        {
            _productRepository = productRepository;
            _outputPort = outputPort;
        }
        public Task Handle()
        {
            var products = _productRepository.GetAllProducts().Select(p => 
                new DTOs.ProductDTO
                {
                    Id = p.Id,
                    Name = p.Name
                });
            _outputPort.Handle(products);
            return Task.CompletedTask;
        }
    }
}
