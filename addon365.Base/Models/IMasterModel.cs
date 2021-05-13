using System;
using System.Collections.Generic;
using System.Text;

namespace addon365.Base.Models
{
    public interface IMasterModel
    {       
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
