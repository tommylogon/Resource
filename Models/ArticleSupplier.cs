using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class ArticleSupplier
    {
        public Guid ArticleObjNo { get; set; }
        public Guid SupplierObjNo { get; set; }
        public decimal? CostPrice { get; set; }
        public string UnitPurchase { get; set; }
        public decimal? CostListPrice { get; set; }
        public decimal? DiscountCostPrice { get; set; }
        public decimal? DiscountCostPrice2 { get; set; }
        public string SupplierArticleNo { get; set; }
        public decimal? ExternalAvailability { get; set; }
        public DateTime? ObjDate { get; set; }
        public string Username { get; set; }
    }
}
