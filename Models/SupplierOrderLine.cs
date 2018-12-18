using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class SupplierOrderLine
    {
        public string Company { get; set; }
        public string InvoiceNo { get; set; }
        public Guid SupplierObjNo { get; set; }
        public decimal LineNo { get; set; }
        public Guid ArticleObjNo { get; set; }
        public string Description { get; set; }
        public decimal Qty { get; set; }
        public decimal? CostPrice { get; set; }
        public decimal? DiscountCostPrice { get; set; }
        public decimal? DiscountCostPrice2 { get; set; }
        public decimal? WarrantyLength { get; set; }
        public decimal? OrderLineNo { get; set; }
        public Guid OrderObjNo { get; set; }

        public SupplierOrderHeading SupplierOrderHeading { get; set; }
    }
}
