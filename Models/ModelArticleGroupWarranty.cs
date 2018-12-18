using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class ModelArticleGroupWarranty
    {
        public Guid ModelObjNo { get; set; }
        public decimal SortGroupNo { get; set; }
        public string SortGroupText { get; set; }
        public decimal? WarrantyMonthsNewMachine { get; set; }
        public decimal? WarrantyUnitsNewMachine { get; set; }
        public decimal? WarrantyMonths { get; set; }
        public decimal? WarrantyUnits { get; set; }
    }
}
