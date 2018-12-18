using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class ProjectPreorder
    {
        public Guid ObjNo { get; set; }
        public Guid TaskObjNo { get; set; }
        public Guid? ArticleObjNo { get; set; }
        public string ArticleDescription { get; set; }
        public decimal? No { get; set; }
        public decimal? Qty { get; set; }
        public string AggregateArticleType { get; set; }
        public Guid? DefaultStockObjNo { get; set; }
        public string SyncedStatus { get; set; }
    }
}
