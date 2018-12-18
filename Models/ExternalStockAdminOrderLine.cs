using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class ExternalStockAdminOrderLine
    {
        public decimal OrderNo { get; set; }
        public string Company { get; set; }
        public decimal OrderLine { get; set; }
        public string ArticleNo { get; set; }
        public string StockNo { get; set; }
        public decimal? QtaOrdered { get; set; }
        public decimal? QtaReceived { get; set; }
        public string AllReceived { get; set; }
        public decimal? ProjectNo { get; set; }
        public decimal? TaskNo { get; set; }
        public string MeansOfDelivery { get; set; }
        public string Express { get; set; }
        public DateTime? EstimatedArrival { get; set; }
        public string SuppliersInvoiceNo { get; set; }
        public decimal? CostPrice { get; set; }
        public Guid? ReplacementNo { get; set; }
        public string ReturnReference { get; set; }
        public string ReturnType { get; set; }
        public string MachineNo { get; set; }
        public decimal? SalesOrderNo { get; set; }
        public decimal? SalesOrderLineNo { get; set; }
        public string ReturnedSerialNo { get; set; }
        public string Description { get; set; }
        public decimal? DiscountCostPrice { get; set; }
        public decimal? DiscountCostPrice2 { get; set; }

        public ExternalStockAdminOrderHeading ExternalStockAdminOrderHeading { get; set; }
    }
}
