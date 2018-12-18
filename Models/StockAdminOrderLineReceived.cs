using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class StockAdminOrderLineReceived
    {
        public Guid OrderObjNo { get; set; }
        public decimal OrderLine { get; set; }
        public Guid ArticleObjNo { get; set; }
        public DateTime ReceivedDate { get; set; }
        public decimal QtaReceived { get; set; }
        public decimal? CostPrice { get; set; }
        public decimal? QtaRemaining { get; set; }
        public string PackingSlipNo { get; set; }
        public decimal PackingSlipLineNo { get; set; }
        public DateTime? SyncTime { get; set; }
        public DateTime? ObjDate { get; set; }
        public string Username { get; set; }
        public Guid? DeliveryBatchObjNo { get; set; }
    }
}
