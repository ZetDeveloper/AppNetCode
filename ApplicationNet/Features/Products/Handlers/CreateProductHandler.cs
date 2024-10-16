using ApplicationNet.Features.Products.Commands;
using ApplicationNet.Models;
using MediatR;
using Project2Api.Repositories;

namespace ApplicationNet.Features.Products.Handlers
{
    public class CreateProductHandler : IRequestHandler<CreateProductCommand, int>
    {
        private readonly IProductRepository _repository;

        public CreateProductHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product
            {
                Name = request.Name,
                Price = request.Price
            };

            await _repository.AddAsync(product);
            await _repository.SaveChangesAsync();

            return product.Id;
        }
    }
}
