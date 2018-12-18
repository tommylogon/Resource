using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class MobileOrderLine
    {
        public int RowId { get; set; }
        public string Company { get; set; }
        public decimal OrderNo { get; set; }
        public decimal LineNo { get; set; }
        public Guid? ArticleObjNo { get; set; }
        public string Description { get; set; }
        public string Unit { get; set; }
        public decimal? CostPrice { get; set; }
        public decimal? SalesPrice { get; set; }
        public decimal? Discount { get; set; }
        public decimal? QtyDelivered { get; set; }
        public decimal? QtyNotDelivered { get; set; }
        public decimal? VatCode { get; set; }
        public Guid? MachineObjNo { get; set; }
        public Guid? StockObjNo { get; set; }
        public string RowType { get; set; }
        public Guid? SalesmanObjNo { get; set; }
        public Guid? TechnicianObjNo { get; set; }
        public DateTime? ActiveFrom { get; set; }
        public DateTime? ActiveTo { get; set; }
        public decimal? ContractRowNo { get; set; }
        public decimal? Volume { get; set; }
        public decimal? FromCounter { get; set; }
        public decimal? ToCounter { get; set; }
        public string Booking { get; set; }
        public Guid? SourceObjNo { get; set; }
        public string OrderLineSource { get; set; }
        public string Sortgroup1 { get; set; }
        public string Sortgroup2 { get; set; }
        public string Invoiceable { get; set; }
        public string ServicesArticleType { get; set; }
        public string StockTracking { get; set; }
    }
}
