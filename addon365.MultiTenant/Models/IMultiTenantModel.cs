using System;
using System.Collections.Generic;
using System.Text;

namespace addon365.MultiTenant.Models
{
    public interface IMultiTenantModel
    {
        public Guid TenantId  { get; set; }
    }
}
