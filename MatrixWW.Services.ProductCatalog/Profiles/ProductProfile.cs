using AutoMapper;
using MatrixWW.Services.ProductCatalog.Entities;
using MatrixWW.Services.ProductCatalog.Models;

namespace MatrixWW.Services.ProductCatalog.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductDTO>().ForMember(dest => dest.CategoryName, opts => opts.MapFrom(product => product.Category.Name));
            CreateMap<Product, ProductDTO>().ForMember(dest => dest.BrandName, opts => opts.MapFrom(product => product.Brand.Name));
        }
    }
}
