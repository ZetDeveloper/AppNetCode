using ApplicationNet.Features.Products.Commands;
using MediatR;
using Project2Api.Repositories;

namespace ApplicationNet.Features.Products.Handlers
{
    public class DeleteProductHandler : IRequestHandler<DeleteProductCommand, int>
    {
        private readonly IProductRepository _repository;

        public DeleteProductHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            await _repository.DeleteProductAsync(request.Id);
            await _repository.SaveChangesAsync();
            return request.Id;
        }


    }
}
