using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addon365.Tally.Model
{
    public class LedgerEntry
    {
        List<Decimal> BasicRateOfInvoiceTax = new List<Decimal>();
        public string LedgerName { get; set; }
        public string GSTClass { get; set; }
        public string IsDeemedPositive { get; set; }
        public string LedgerFromItem { get; set; }
        public string RemoveZeroEntries { get; set; }
        public string IsPartyLedger { get; set; }
        public decimal number { get; set; }

    }
}
