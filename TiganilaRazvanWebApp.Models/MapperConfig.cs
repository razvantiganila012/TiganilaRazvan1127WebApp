
using AutoMapper;
using MagazinOnline.Models.Entities;
using TiganilaRazvanWebApp.Models.DTOs.VM;

namespace TiganilaRazvanWebApp.Models
{
   public static class MapperConfig
    {
        public static IMapper GetMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ProductType, ProductTypeVM>();
                cfg.CreateMap<ProductTypeVM, ProductType>();

                cfg.CreateMap<Product, ProductVM>();
                cfg.CreateMap<ProductVM, Product>();
            });

            return config.CreateMapper();
        }
    }
}
