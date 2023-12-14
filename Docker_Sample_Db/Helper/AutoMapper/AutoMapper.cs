using AutoMapper;
using Docker_Sample_Db.Entities;
using Docker_Sample_Db.Models;

namespace Docker_Sample_Db.Helper.AutoMapper
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<Product, ProductModel>().ReverseMap();     
        }
    }
}
