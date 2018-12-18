using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class ContractMeterArticleConsumable
    {
        public Guid ContractObjNo { get; set; }
        public Guid SourceObjNo { get; set; }
        public Guid MeterObjNo { get; set; }
        public Guid ArticleObjNo { get; set; }
        public decimal? UnitsPerToner { get; set; }
        public decimal? CoveredPercentage { get; set; }
        public string ConsumableName { get; set; }
        public Guid ObjNo { get; set; }
    }
}
