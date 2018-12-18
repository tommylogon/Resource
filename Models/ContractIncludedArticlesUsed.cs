using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class ContractIncludedArticlesUsed
    {
        public Guid ContractObjNo { get; set; }
        public decimal ContractRowNo { get; set; }
        public Guid ArticleObjNo { get; set; }
        public DateTime UsedFrom { get; set; }
        public DateTime? UsedTo { get; set; }
        public decimal? Amount { get; set; }
        public string ContractType { get; set; }
        public string AmountNotUsedMoved { get; set; }
    }
}
