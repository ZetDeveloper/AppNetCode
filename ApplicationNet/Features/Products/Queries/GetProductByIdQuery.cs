using ApplicationNet.Models;
using MediatR;

namespace ApplicationNet.Features.Products.Queries
{
    public record GetProductByIdQuery(int Id) : IRequest<Product>;
}
