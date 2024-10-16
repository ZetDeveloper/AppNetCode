using MediatR;

namespace ApplicationNet.Features.Products.Commands
{
    public record UpdateProductCommand(int Id, string Name, decimal Price) : IRequest<int>;
}
