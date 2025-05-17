using CleanArchitecture.DTOs;
using CleanArchitecture.Entities.Interfaces;
using CleanArchitecture.Entities.POCOs;
using CleanArchitecture.UseCasesPorts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.UseCases.CreateProduct
{
    public class CreateProductInteractor : ICreateProductInputPort
    {
        readonly IProductRepository _productRepository;
        readonly IUnitOfWork _unitOfWork;
        readonly ICreateProductOutputPort _outputPort;

        public CreateProductInteractor(IProductRepository productRepository, IUnitOfWork unitOfWork, ICreateProductOutputPort outputPort)
        {
            _productRepository = productRepository;
            _unitOfWork = unitOfWork;
            _outputPort = outputPort;
        }

        public async Task Handle(CreateProductDTO product)
        {
            Product newProduct = new Product
            {
                Name = product.ProductName
            };
            _productRepository.CreateProduct(newProduct);
            await _unitOfWork.SaveChanges();
            await _outputPort.Handle(new ProductDTO
            {
                Id = newProduct.Id,
                Name = newProduct.Name
            });
        }
    }
}
