using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class StockQty
    {
        public Guid ArticleObjNo { get; set; }
        public Guid StockObjNo { get; set; }
        public decimal? QtyInStock { get; set; }
        public decimal? QtyInOrder { get; set; }
        public decimal? OrderLimit { get; set; }
        public DateTime? LastSalesDate { get; set; }
        public string Location { get; set; }

        public Stock StockObjNoNavigation { get; set; }
    }
}
