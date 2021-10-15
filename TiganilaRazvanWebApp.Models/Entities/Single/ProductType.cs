using System.Collections.Generic;
using TiganilaRazvanWebApp.Models;

namespace MagazinOnline.Models.Entities
{
    public partial class ProductType : IEntity<int>
    {
        public ProductType()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public string Country { get; set; }

        public string DescriptionProd { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
