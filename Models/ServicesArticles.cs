using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class ServicesArticles
    {
        public string Company { get; set; }
        public string Dept { get; set; }
        public string ArticleType { get; set; }
        public Guid ArticleObjNo { get; set; }
        public decimal? CostPrice { get; set; }
        public decimal? SalesPrice { get; set; }
        public string Rounding { get; set; }
        public string FixedTravelChk { get; set; }
        public string TravelTimeChk { get; set; }
        public string KmChk { get; set; }
        public string ArticleTypedef { get; set; }
        public decimal? No { get; set; }
        public decimal? Qty { get; set; }
        public string Invoiceable { get; set; }
        public string Hide { get; set; }
        public string DefaultInMobile { get; set; }

        public Article ArticleObjNoNavigation { get; set; }
    }
}
