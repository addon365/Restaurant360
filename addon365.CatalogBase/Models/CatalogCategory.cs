using addon365.Base.Models;
using addon365.MultiTenant.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace addon365.CatalogBase.Models
{
    public class CatalogCategory : IMultiTenantModel, IMasterModel
    {
        [Key]
        public Guid CatalogCategoryId { get; set; }
        public string CategoryName { get; set; }
        public Guid TenantId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
