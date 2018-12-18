using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class ArticleDiscount
    {
        public Guid ObjNo { get; set; }
        public Guid? CustomerObjNo { get; set; }
        public Guid? ArticleObjNo { get; set; }
        public decimal? Discount { get; set; }
        public string ArticleSortgroup { get; set; }
        public decimal? MinQty { get; set; }
        public DateTime? ObjDate { get; set; }
        public string Username { get; set; }
        public decimal? FixedAmount { get; set; }
        public decimal? CostPriceFixed { get; set; }
        public decimal? SalesPriceFixed { get; set; }
        public string Dept { get; set; }
        public string ArticleSortgroupNo { get; set; }
        public Guid? ContractObjNo { get; set; }
        public DateTime? EndDate { get; set; }
        public string Comment { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }

        public Article ArticleObjNoNavigation { get; set; }
        public Contract ContractObjNoNavigation { get; set; }
        public Customer CustomerObjNoNavigation { get; set; }
    }
}
