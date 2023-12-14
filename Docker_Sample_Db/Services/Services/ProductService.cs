using AutoMapper;
using Docker_Sample_Db.Data;
using Docker_Sample_Db.Entities;
using Docker_Sample_Db.Repositories.IRepository;
using Docker_Sample_Db.Services.IServices;

namespace Docker_Sample_Db.Services.Services
{
    public class ProductService : BaseService<Product, int>, IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(Sql2Context dataContext, FirstMySqlContext firstMySqlContext, IMapper mapper, IProductRepository productRepository) : 
            base(dataContext, firstMySqlContext, mapper, productRepository)
        {
            _productRepository = productRepository;
        }

    }
}
