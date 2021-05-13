using addon365.CatalogBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace addon365.Restaurant.Models
{
    public class RestaurantCatalog:Catalog
    {
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsVeg { get; set; }
    }
}
