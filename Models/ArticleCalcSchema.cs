using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class ArticleCalcSchema
    {
        public string Company { get; set; }
        public int SchemaNo { get; set; }
        public decimal PriceFrom { get; set; }
        public decimal PriceTo { get; set; }
        public decimal? Price1 { get; set; }
        public decimal? Price2 { get; set; }
        public decimal? Price3 { get; set; }
        public decimal? Price4 { get; set; }
        public decimal? Price5 { get; set; }
    }
}
