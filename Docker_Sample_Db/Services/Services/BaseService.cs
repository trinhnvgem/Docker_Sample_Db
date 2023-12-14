using AutoMapper;
using Docker_Sample_Db.Data;
using Docker_Sample_Db.Repositories.IRepository;
using Docker_Sample_Db.Services.IServices;
using Microsoft.EntityFrameworkCore;

namespace Docker_Sample_Db.Services.Services
{
    public class BaseService<T, K> : IBaseService<T, K> where T : class
    {
        protected readonly Sql2Context _dataContext;
        protected readonly FirstMySqlContext _firstMySqlContext;
        protected readonly DbSet<T> _dbSet;
        protected readonly DbSet<T> _dbSet2;
        protected readonly IMapper _mapper;
        protected readonly IBaseRepository<T, K> _baseRepo;

        public BaseService(Sql2Context dataContext, FirstMySqlContext firstMySqlContext, IMapper mapper, IBaseRepository<T, K> baseRepo)
        {
            _firstMySqlContext = firstMySqlContext;
            _dbSet2 = _firstMySqlContext.Set<T>();
            _dataContext = dataContext;
            _dbSet = _dataContext.Set<T>();
            _mapper = mapper;
            _baseRepo = baseRepo;
        }

        public async Task<T> CreateAsync(T entity)
        {
            return await _baseRepo.CreateAsync(entity); ;
        }

        public async Task DeleteAsync(K id)
        {
            await _baseRepo.DeleteAsync(id);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _baseRepo.GetAllAsync();
        }
        public async Task<IEnumerable<T>> GetAllAsync2()
        {
            return await _baseRepo.GetAllAsync2();
        }
        public async Task<T> GetByIdAsync(K id)
        {
            return await _baseRepo.GetByIdAsync(id);
        }

        public async Task<T> UpdateAsync(T entity)
        {
            return await _baseRepo.UpdateAsync(entity);
        }
    }
}
