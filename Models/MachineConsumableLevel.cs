using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class MachineConsumableLevel
    {
        public Guid MachineObjNo { get; set; }
        public string ConsumableName { get; set; }
        public DateTime StatusDate { get; set; }
        public decimal? ConsumableLevel { get; set; }
        public decimal? ConsumableCoverage { get; set; }
        public decimal? OrderNo { get; set; }
        public decimal? CalculatedRemainingDays { get; set; }
        public decimal? PeakStatus { get; set; }
        public Guid? OrderLineObjNo { get; set; }
        public string Company { get; set; }
    }
}
