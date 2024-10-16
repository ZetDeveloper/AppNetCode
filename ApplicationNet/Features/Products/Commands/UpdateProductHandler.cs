using ApplicationNet.Models;
using MediatR;
using Project2Api.Repositories;

namespace ApplicationNet.Features.Products.Commands
{

    public class UpdateProductHandler : IRequestHandler<UpdateProductCommand, int>
    {
        private readonly IProductRepository _repository;

        public UpdateProductHandler(IProductRepository repository)
        {
            _repository = repository;
        }


        public async Task<int> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {

            var product = new Product
            {
                Id = request.Id,
                Name = request.Name,
                Price = request.Price
            };

            await _repository.UpdateProductAsync(product);
            await _repository.SaveChangesAsync();

            return request.Id;
        }
    }
}
