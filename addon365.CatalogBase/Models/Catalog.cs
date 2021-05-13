using addon365.Base.Models;
using addon365.MultiTenant.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace addon365.CatalogBase.Models
{
    public class Catalog:IMultiTenantModel,IMasterModel
    {
        [Key]
        public Guid CatalogId { get; set; }
        public string ItemNameSearch { get; set; }
        public string ItemNamePrint { get; set; }
        public string ItemNameShort { get; set; }
        public Guid CatalogCategoryId { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Guid TenantId { get; set; }
    }
}
