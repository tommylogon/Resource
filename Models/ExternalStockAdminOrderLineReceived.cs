using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class ExternalStockAdminOrderLineReceived
    {
        public decimal OrderNo { get; set; }
        public string Company { get; set; }
        public decimal OrderLine { get; set; }
        public string ArticleNo { get; set; }
        public DateTime ReceivedDate { get; set; }
        public decimal QtaReceived { get; set; }
        public decimal? CostPrice { get; set; }
        public decimal? QtaRemaining { get; set; }
        public string PackingSlipNo { get; set; }
        public decimal PackingSlipLineNo { get; set; }
    }
}
