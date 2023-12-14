using Docker_Sample_Db.Data;
using Docker_Sample_Db.Entities;
using Docker_Sample_Db.Repositories.IRepository;

namespace Docker_Sample_Db.Repositories.Repository
{
    public class ProductRepository : BaseRepository<Product, int>, IProductRepository
    {
        public ProductRepository(Sql2Context dataContext, FirstMySqlContext firstMySqlContext) : base(dataContext, firstMySqlContext)
        {

        }
    }
}
