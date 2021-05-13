using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addon365.Tally.Model
{
    public class AllInventoryEntry
    {
        public string StockItemName { get; set; }
        public string IsDeemedPositive { get; set; }
        public string IsAutoneGate { get; set; }
        public string Rate { get; set; }
        public string Amount { get; set; }
        public string ActualQty { get; set; }
        public string BilledQty { get; set; }
        public List<LedgerEntry> AccountingAllocations { get; set; }
        public List<BatchAllocation> BatchAllocations { get; set; }

    }
}
