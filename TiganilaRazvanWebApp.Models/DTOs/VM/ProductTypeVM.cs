using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiganilaRazvanWebApp.Models.DTOs.VM
{
   public class ProductTypeVM
    {

        public int Id { get; set; }

        [Required]
        [MaxLength(255)]

        public string Name { get; set; }

        [Required]
        [MaxLength(255)]
        public string Country { get; set; }

        [Required]
        [MaxLength(255)]
        public string DescriptionProd { get; set; }



    }
}
