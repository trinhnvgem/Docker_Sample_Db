using Docker_Sample_Db.Data;
using Docker_Sample_Db.Repositories.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Docker_Sample_Db.Repositories.Repository
{
    public class BaseRepository<T, K> : IBaseRepository<T, K> where T : class
    {
        protected readonly Sql2Context _dataContext;
        protected readonly FirstMySqlContext _firstMySqlContext;
        protected readonly DbSet<T> _dbSet;
        protected readonly DbSet<T> _dbSet2;

        public BaseRepository(Sql2Context dataContext, FirstMySqlContext firstMySqlContext)
        {
            _dataContext = dataContext;
            _firstMySqlContext = firstMySqlContext;
            _dbSet = _dataContext.Set<T>();
            _dbSet2 = _firstMySqlContext.Set<T>();
        }

        public async Task<T> CreateAsync(T entity)
        {
            _dbSet2.Add(entity);
            _dbSet.Add(entity);
            await _dataContext.SaveChangesAsync();
            await _firstMySqlContext.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(K id)
        {
            var existingEntity = await _dbSet.FindAsync(id);
            if (existingEntity != null)
            {
                _dbSet.Remove(existingEntity);
                await _dataContext.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            var result = await _dbSet.ToListAsync();
            return result;
        }
        public async Task<IEnumerable<T>> GetAllAsync2()
        {
            var result = await _dbSet2.ToListAsync();
            return result;
        }
        public async Task<T> GetByIdAsync(K id)
        {
            var result = await _dbSet.FindAsync(id);
            return result!;
        }

        public async Task<T> UpdateAsync(T entity)
        {
            var entry = _dbSet.Update(entity);
            await _dataContext.SaveChangesAsync();
            return entry.Entity;
        }
    }
}
