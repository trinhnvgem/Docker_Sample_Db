namespace Docker_Sample_Db.Repositories.IRepository
{
    public interface IBaseRepository<T, K>
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> GetAllAsync2();
        Task<T> GetByIdAsync(K id);
        Task<T> CreateAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task DeleteAsync(K id);
    }
}
