using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class QuickOrderArticles
    {
        public Guid ModelObjNo { get; set; }
        public Guid ArticleObjNo { get; set; }
        public string Group1 { get; set; }
        public decimal? Qty1 { get; set; }
        public string Group2 { get; set; }
        public decimal? Qty2 { get; set; }
        public string Group3 { get; set; }
        public decimal? Qty3 { get; set; }
        public bool? UseInService { get; set; }
        public bool? UseInSales { get; set; }
        public bool? UseInWeb { get; set; }

        public Model ModelObjNoNavigation { get; set; }
    }
}
