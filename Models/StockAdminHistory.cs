using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class StockAdminHistory
    {
        public DateTime DateHistory { get; set; }
        public Guid StockObjNo { get; set; }
        public Guid ArticleObjNo { get; set; }
        public decimal QtyOnStock { get; set; }
        public decimal? ValueOnStock { get; set; }
    }
}
