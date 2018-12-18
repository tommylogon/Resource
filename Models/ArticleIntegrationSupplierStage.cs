using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class ArticleIntegrationSupplierStage
    {
        public string Company { get; set; }
        public string ArticleNo { get; set; }
        public string SupplierNo { get; set; }
        public string ArticleNoSupplier { get; set; }
        public decimal? CostPrice { get; set; }
        public decimal? Qty { get; set; }
        public DateTime? ObjDate { get; set; }
    }
}
