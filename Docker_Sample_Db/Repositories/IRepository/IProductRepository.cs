using Docker_Sample_Db.Entities;

namespace Docker_Sample_Db.Repositories.IRepository
{
    public interface IProductRepository : IBaseRepository<Product, int>
    {
    }
}
