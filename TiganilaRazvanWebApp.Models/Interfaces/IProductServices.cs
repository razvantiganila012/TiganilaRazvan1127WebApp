
using System.Collections.Generic;
using TiganilaRazvanWebApp.Models.DTOs;
using TiganilaRazvanWebApp.Models.DTOs.VM;

namespace TiganilaRazvanWebApp.Models.Interfaces
{
    public interface IProductServices
    {
        IEnumerable<ProductVM> GetAllProducts();
        ProductVM GetProduct(int id);
        void AddProduct(ProductVM dto);
        void UpdateProduct(int id, ProductVM dto);
        void DeleteProduct(int id);
        List<IdNameDto> GetProductTypes();
    }
}
