using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class SaleCalcIntervalGroup
    {
        public SaleCalcIntervalGroup()
        {
            SaleCalcIntervalMeter = new HashSet<SaleCalcIntervalMeter>();
        }

        public Guid ObjNo { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string Company { get; set; }

        public ICollection<SaleCalcIntervalMeter> SaleCalcIntervalMeter { get; set; }
    }
}
