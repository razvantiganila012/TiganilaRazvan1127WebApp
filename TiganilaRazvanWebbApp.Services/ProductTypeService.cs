

using AutoMapper;
using MagazinOnline.Models.Entities;
using System.Collections.Generic;
using TiganilaRazvanWebApp.DataAcces.Interfaces;
using TiganilaRazvanWebApp.Models.DTOs.VM;
using TiganilaRazvanWebApp.Models.Interfaces;

namespace TiganilaRazvanWebbApp.Services
{
    public class ProductTypeService : IProductTypeService
    {

        private readonly IRepository<ProductType, int> productTypeRep;
        private readonly IMapper mapper;

        public ProductTypeService(IRepository<ProductType, int> productTypeRep, IMapper mapper)
        {
            this.productTypeRep = productTypeRep;
            this.mapper = mapper;
        }


        public void AddProductType(ProductTypeVM dto)
        {
            var entity = mapper.Map<ProductType>(dto);
            productTypeRep.Add(entity);
        }

        public void DeleteProductType(int id)
        {
            var entity = productTypeRep.GetInstance(id);
            if (entity == null)
                return;

            productTypeRep.Delete(entity);
        }

        public IEnumerable<ProductTypeVM> GetAllProductType()
        {
            var products = productTypeRep.GetAll();
            return mapper.Map<List<ProductTypeVM>>(products);
        }

        public ProductTypeVM GetProductType(int id)
        {
            var entity = productTypeRep.GetInstance(id);
            return mapper.Map<ProductTypeVM>(entity);
        }

        public void UpdateProductType(int id, ProductTypeVM dto)
        {
            var entity = productTypeRep.GetInstance(id);
            if (entity == null)
                return;

            mapper.Map(dto, entity);
            productTypeRep.Update(entity);
        }
    }
}
