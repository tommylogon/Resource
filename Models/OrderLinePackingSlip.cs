using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class OrderLinePackingSlip
    {
        public string Company { get; set; }
        public decimal PackingSlipNo { get; set; }
        public DateTime DeliveryDate { get; set; }
        public decimal OrderNo { get; set; }
        public decimal LineNo { get; set; }
        public decimal QtyDelivered { get; set; }
        public string CustomerNode { get; set; }
        public Guid? PackingSlipMachineObjNo { get; set; }
        public string MachineCreatedOrChanged { get; set; }
    }
}
