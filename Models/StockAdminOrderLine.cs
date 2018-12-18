using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class StockAdminOrderLine
    {
        public Guid OrderObjNo { get; set; }
        public decimal OrderLine { get; set; }
        public Guid? ArticleObjNo { get; set; }
        public Guid? StockObjNo { get; set; }
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
        public Guid? ReplacementObjNo { get; set; }
        public string ReturnReference { get; set; }
        public string ReturnType { get; set; }
        public Guid? MachineObjNo { get; set; }
        public decimal? SalesOrderNo { get; set; }
        public decimal? SalesOrderLineNo { get; set; }
        public string ReturnedSerialNo { get; set; }
        public string Description { get; set; }
        public decimal? DiscountCostPrice { get; set; }
        public decimal? DiscountCostPrice2 { get; set; }
        public string LineSource { get; set; }
        public DateTime? LineProposalObjDate { get; set; }
        public string LineProposalUsername { get; set; }
        public string Status { get; set; }
        public string StatusInformation { get; set; }

        public StockAdminOrderHeading OrderObjNoNavigation { get; set; }
    }
}
