using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class ModelVirtualMeterDependencies
    {
        public Guid ModelObjNo { get; set; }
        public Guid VirtualMeterObjNo { get; set; }
        public Guid MeterObjNo { get; set; }

        public ModelMeter M { get; set; }
        public ModelMeter ModelMeter { get; set; }
    }
}
