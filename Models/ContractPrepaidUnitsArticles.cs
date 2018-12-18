using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class ContractPrepaidUnitsArticles
    {
        public Guid CpuObjNo { get; set; }
        public Guid ArticleObjNo { get; set; }
        public decimal? QtyFactor { get; set; }
    }
}
