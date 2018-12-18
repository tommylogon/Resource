using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class StockAdminArticleSerialNo
    {
        public Guid StockAdminOrderObjNo { get; set; }
        public decimal StockAdminOrderLineNo { get; set; }
        public Guid ArticleObjNo { get; set; }
        public Guid StockObjNo { get; set; }
        public string SerialNo { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string Company { get; set; }
        public decimal? OrderNo { get; set; }
        public string Status { get; set; }
        public decimal? CostPrice { get; set; }
        public decimal? SalesPrice { get; set; }
        public decimal? WarrantyLength { get; set; }
        public string CalcAvgCostPrice { get; set; }
        public DateTime? WarrantyStart { get; set; }
        public string PackingSlipNo { get; set; }
        public decimal? PackingSlipLineNo { get; set; }
        public string BinLocation { get; set; }
        public string Type { get; set; }
        public Guid? DeliveryBatchObjNo { get; set; }
    }
}
