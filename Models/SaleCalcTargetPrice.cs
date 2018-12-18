using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class SaleCalcTargetPrice
    {
        public string Code { get; set; }
        public decimal? Factor { get; set; }
        public string Description { get; set; }
    }
}
