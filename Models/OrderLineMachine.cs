using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class OrderLineMachine
    {
        public string Company { get; set; }
        public decimal OrderNo { get; set; }
        public decimal LineNo { get; set; }
        public Guid MachineObjNo { get; set; }

        public OrderLine OrderLine { get; set; }
    }
}
