using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class MachineLeasingInformation
    {
        public Guid MachineObjNo { get; set; }
        public string Leasing { get; set; }
        public DateTime? LeasingStartDate { get; set; }
        public decimal? LeasingInvestedAmount { get; set; }
        public Guid? LeasingOwner { get; set; }
        public string LeasingOwnerContractNo { get; set; }
        public decimal? LeasingInvestedCostMachine { get; set; }
        public decimal? LeasingInvestedCostAccessories { get; set; }
        public decimal? LeasingFactor { get; set; }
        public decimal? LeasingRefiInvestedAmount { get; set; }
        public decimal? LeasingRefiContractPeriod { get; set; }
        public decimal? LeasingRefiFactor { get; set; }
    }
}
