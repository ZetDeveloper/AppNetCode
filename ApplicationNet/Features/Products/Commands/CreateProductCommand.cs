using MediatR;

namespace ApplicationNet.Features.Products.Commands
{
    public record CreateProductCommand(string Name, decimal Price) : IRequest<int>;
}
