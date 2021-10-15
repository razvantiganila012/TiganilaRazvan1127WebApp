
using System.Collections.Generic;
using TiganilaRazvanWebApp.Models.DTOs.VM;

namespace TiganilaRazvanWebApp.Models.Interfaces
{
    public interface IProductTypeService
    {
        IEnumerable<ProductTypeVM> GetAllProductType();
        ProductTypeVM GetProductType(int id);
        void AddProductType(ProductTypeVM dto);
        void UpdateProductType(int id, ProductTypeVM dto);
        void DeleteProductType(int id);



    }
}
