using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class SymptomCode
    {
        public string Company { get; set; }
        public string Registry { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string PriorityCode { get; set; }
        public string ResponseTimeCalc { get; set; }
        public int? Inactive { get; set; }
    }
}
