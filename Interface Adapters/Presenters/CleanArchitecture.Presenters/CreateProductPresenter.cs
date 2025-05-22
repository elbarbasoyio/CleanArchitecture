using CleanArchitecture.DTOs;
using CleanArchitecture.UseCasesPorts;

namespace CleanArchitecture.Presenters
{
    public class CreateProductPresenter : ICreateProductOutputPort, IPresenter<ProductDTO>
    {
        public ProductDTO Content { get; private set; } = new ProductDTO();

        public Task Handle(ProductDTO product)
        {
            Content = product;
            return Task.CompletedTask;
        }
    }
}
