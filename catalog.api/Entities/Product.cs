using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace catalog.api.Entities
{
    public class Product : IId
    {
        public int Id { get; set; }
        [Required]
        [StringLength(120)]
        public string Name { get; set; }
        [StringLength(300)]
        public string Description { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public double PurchasePrice { get; set; }
        [Required]
        public double SalePrice { get; set; }

        

    }
}
