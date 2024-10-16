using MediatR;

namespace ApplicationNet.Features.Products.Commands
{
    public record DeleteProductCommand(int Id) : IRequest<int>;
}
