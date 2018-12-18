using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class ArticleAggregated
    {
        public Guid OwnerObjNo { get; set; }
        public Guid ArticleObjNo { get; set; }
        public decimal? SortOrder { get; set; }
        public decimal? Qty { get; set; }
        public Guid? DefaultStockObjNo { get; set; }
    }
}
