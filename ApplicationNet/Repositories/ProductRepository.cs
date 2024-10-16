using ApplicationNet.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Project2Api.Data;
using Project2Api.Repositories;

namespace ApplicationNet.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task UpdateProductAsync(Product product)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product));

            var idParam = new SqlParameter("@Id", product.Id);
            var nameParam = new SqlParameter("@Name", product.Name);
            var priceParam = new SqlParameter("@Price", product.Price);

            await _context.Database.ExecuteSqlRawAsync(
                "EXEC sp_UpdateProduct @Id, @Name, @Price",
                idParam, nameParam, priceParam
            );
        }

        public async Task DeleteProductAsync(int id)
        {
            var idParam = new SqlParameter("@Id", id);
            await _context.Database.ExecuteSqlRawAsync(
                "EXEC sp_DeleteProduct @Id",
                idParam
            );
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
