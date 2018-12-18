using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class ContractIncludedArticles
    {
        public Guid ContractObjNo { get; set; }
        public decimal ContractRowNo { get; set; }
        public Guid ArticleObjNo { get; set; }
        public DateTime? ValidFrom { get; set; }
        public decimal? Frequence { get; set; }
        public decimal? Amount { get; set; }
        public string ContractType { get; set; }
        public string SaveNotUsed { get; set; }
        public decimal? AmountNotUsed { get; set; }
    }
}
