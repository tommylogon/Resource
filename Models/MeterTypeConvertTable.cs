using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class MeterTypeConvertTable
    {
        public string Company { get; set; }
        public string Parameter1 { get; set; }
        public string Parameter2 { get; set; }
        public string Parameter3 { get; set; }
        public string Description { get; set; }
        public Guid? MeterObjNo { get; set; }
    }
}
