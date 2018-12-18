using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class SaleCalcLeasing
    {
        public Guid ObjNo { get; set; }
        public Guid SourceObjNo { get; set; }
        public decimal LeasingFactor { get; set; }
        public decimal? MonthFrom { get; set; }
        public decimal? MonthTo { get; set; }
        public decimal? CalcPriceFrom { get; set; }
        public decimal? CalcPriceTo { get; set; }
        public bool? Rental { get; set; }
        public bool? Leasing { get; set; }
        public string FactorDescription { get; set; }
    }
}
