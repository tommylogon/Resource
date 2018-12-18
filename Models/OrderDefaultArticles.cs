using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class OrderDefaultArticles
    {
        public string Company { get; set; }
        public string ArticleType { get; set; }
        public Guid ArticleObjNo { get; set; }
        public decimal? Qty { get; set; }

        public Article ArticleObjNoNavigation { get; set; }
        public Company CompanyNavigation { get; set; }
    }
}
