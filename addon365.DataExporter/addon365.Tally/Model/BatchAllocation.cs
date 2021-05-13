using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addon365.Tally.Model
{
    public class BatchAllocation
    {
        public string GoDownName { get; set; }
        public string BatchName { get; set; }
        public string DestinationGoDownName { get; set; }
        public string IndentNo { get; set; }
        public string OrderNo { get; set; }
        public string TrackingNumber { get; set; }
        public string Amount { get; set; }
        public double ActualQty{get;set;}
        public double BilledQty { get; set; }
    }
}
