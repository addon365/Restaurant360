using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace addon365.Restaurant.ViewModels.Catalog
{
    public class CreateCatalogViewModel
    {
        public string  ItemNameSearch { get; set; }
        public string ItemNamePrint { get; set; }
        public string ItemNameShort { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsVeg { get; set; }
        public Guid CatalogCategoryId { get; set; }
    }
}
