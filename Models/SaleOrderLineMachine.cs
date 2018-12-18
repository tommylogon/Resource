using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class SaleOrderLineMachine
    {
        public Guid CalcObjNo { get; set; }
        public decimal LineNo { get; set; }
        public Guid MachineObjNo { get; set; }

        public SaleOrderLine SaleOrderLine { get; set; }
    }
}
