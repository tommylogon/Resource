using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class CustomerMachineModelMeterPrice
    {
        public Guid CustomerObjNo { get; set; }
        public Guid MachineObjNo { get; set; }
        public Guid ModelObjNo { get; set; }
        public Guid MeterObjNo { get; set; }
        public Guid ObjNo { get; set; }

        public Customer CustomerObjNoNavigation { get; set; }
        public Machine MachineObjNoNavigation { get; set; }
        public Meter MeterObjNoNavigation { get; set; }
        public Model ModelObjNoNavigation { get; set; }
    }
}
