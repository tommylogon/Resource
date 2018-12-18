using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class OrderLinePartCreditChanges
    {
        public Guid ObjNo { get; set; }
        public string Owner { get; set; }
        public string PreviewType { get; set; }
        public string Company { get; set; }
        public string Dept { get; set; }
        public decimal? InvoiceNo { get; set; }
        public decimal? OrderNo { get; set; }
        public decimal? LineNo { get; set; }
        public decimal? Qty { get; set; }
        public decimal? SalesPrice { get; set; }
        public string Invoiceable { get; set; }
        public decimal? Discount { get; set; }
        public DateTime? NewInvoiceDate { get; set; }
    }
}
