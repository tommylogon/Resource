using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class StockAdminArticle
    {
        public Guid ArticleObjNo { get; set; }
        public Guid StockObjNo { get; set; }
        public string Location { get; set; }
        public decimal? OrderPoint { get; set; }
        public decimal? OrderAmount { get; set; }
        public decimal? AmountOnStock { get; set; }
        public decimal? MaxAmount { get; set; }
        public decimal? MeanCostPrice { get; set; }

        public Article ArticleObjNoNavigation { get; set; }
        public Stock StockObjNoNavigation { get; set; }
    }
}
