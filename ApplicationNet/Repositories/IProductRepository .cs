using ApplicationNet.Models;
using Microsoft.EntityFrameworkCore;
using Project2Api.Data;

namespace Project2Api.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        Task UpdateProductAsync(Product product);

        Task DeleteProductAsync(int id);
    }
}