using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class SaleCalcIntervalMeter
    {
        public Guid ObjNo { get; set; }
        public Guid IntervalObjNo { get; set; }
        public Guid MeterObjNo { get; set; }
        public string Company { get; set; }
        public decimal IntervalFrom { get; set; }
        public decimal IntervalTo { get; set; }
        public decimal Ppu { get; set; }
        public decimal Ppeu { get; set; }

        public SaleCalcIntervalGroup IntervalObjNoNavigation { get; set; }
        public Meter MeterObjNoNavigation { get; set; }
    }
}
