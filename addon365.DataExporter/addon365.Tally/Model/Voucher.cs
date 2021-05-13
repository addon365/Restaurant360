using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addon365.Tally.Model
{
    public class Voucher
    {
        public string Date { get; set; }
        public string Narration { get; set; }
        public string VoucherTypeName { get; set; }
        public string PartyledgerName { get; set; }
        public string PartyName { get; set; }
        public string BasePartyName { get; set; }
        public string CstFormIssueType { get; set; }
        public string CstFormRecvType { get; set; }
        public string VchGstClass { get; set; }
        public string DiffActualQty { get; set; }
        public string Audited { get; set; }
        public string ForJobCosting { get; set; }
        public string IsOptional { get; set; }
        public string EffectiveDate { get; set; }
        public string UseForInterest { get; set; }
        public string UseforGainLoss { get; set; }
        public string UseForGoDownTransfer { get; set; }
        public string UseforCompound { get; set; }
        public string IsCancelled { get; set; }
        public string HasCashFlow { get; set; }
        public string IsPostDated { get; set; }
        public string UseTrackingNumber { get; set; }
        public string IsInvoice { get; set; }
        public string MfgJournal { get; set; }
        public string HasDiscounts { get; set; }
        public string AsPaySlip { get; set; }
        public string IsDeleted { get; set; }
        public string AsOrginal { get; set; }
        public List<InvoiceIndent> InvoiceIndentList { get; set; }
        public List<LedgerEntry> LedgerEntries { get; set; }

    }
}
