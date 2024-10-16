using ApplicationNet.Features.Products.Queries;
using ApplicationNet.Models;
using MediatR;
using Project2Api.Repositories;

namespace ApplicationNet.Features.Products.Handlers
{
    public class GetProductByIdHandler : IRequestHandler<GetProductByIdQuery, Product>
    {
        private readonly IProductRepository _repository;

        public GetProductByIdHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var product = await _repository.GetByIdAsync(request.Id);

            return product;
        }
    }
}
