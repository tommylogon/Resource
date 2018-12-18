using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class QuickOrderArticlesDefaultValues
    {
        public string Company { get; set; }
        public string ArticleSortGroupNo { get; set; }
        public string ArticleSortGroupValue { get; set; }
        public decimal? Qty1 { get; set; }
        public decimal? Qty2 { get; set; }
        public decimal? Qty3 { get; set; }
        public bool? UseInService { get; set; }
        public bool? UseInSales { get; set; }
        public bool? UseInWeb { get; set; }
    }
}
