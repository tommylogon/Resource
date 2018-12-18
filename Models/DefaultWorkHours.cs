using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class DefaultWorkHours
    {
        public string Company { get; set; }
        public DateTime DateFrom { get; set; }
        public string HoursMon { get; set; }
        public string HoursTue { get; set; }
        public string HoursWed { get; set; }
        public string HoursThu { get; set; }
        public string HoursFri { get; set; }
        public string HoursSat { get; set; }
        public string HoursSun { get; set; }
        public Guid ObjNo { get; set; }
        public string Dept { get; set; }
        public Guid? SourceObjNo { get; set; }
    }
}
