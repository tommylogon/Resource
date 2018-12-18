using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class MachineConsumableMeterReading
    {
        public Guid MachineObjNo { get; set; }
        public Guid MeterObjNo { get; set; }
        public DateTime ReadingDate { get; set; }
        public decimal Counter { get; set; }
    }
}
