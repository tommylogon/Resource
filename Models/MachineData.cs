using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class MachineData
    {
        public Guid MachineObjNo { get; set; }
        public Guid? ContractTypeObjNo { get; set; }
        public DateTime? ActiveFrom { get; set; }
        public DateTime? ActiveTo { get; set; }
        public decimal? Result { get; set; }
        public DateTime? LastVisit { get; set; }
        public decimal? Activities { get; set; }
    }
}
