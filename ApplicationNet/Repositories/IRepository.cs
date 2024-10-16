namespace Project2Api.Repositories
{

    public interface IRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);

        Task AddAsync(T entity);

        Task SaveChangesAsync();

        // Puedes agregar otros métodos genéricos si es necesario, por ejemplo:
        // Task<IEnumerable<T>> GetAllAsync();
        // Task UpdateAsync(T entity);
        // Task DeleteAsync(int id);
    }
}