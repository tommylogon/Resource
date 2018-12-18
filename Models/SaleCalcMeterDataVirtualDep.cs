using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class SaleCalcMeterDataVirtualDep
    {
        public Guid CalcObjNo { get; set; }
        public decimal ContractRowNo { get; set; }
        public Guid LineObjNo { get; set; }
        public Guid VirtualMeterObjNo { get; set; }
        public Guid MeterObjNo { get; set; }
        public decimal Volume { get; set; }
    }
}
