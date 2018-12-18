using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class PriorityCodeSupport
    {
        public string Company { get; set; }
        public string PriorityCode { get; set; }
        public string PriorityText { get; set; }
        public decimal? Color { get; set; }
        public decimal? Pri { get; set; }
        public decimal? ResponseTime { get; set; }
    }
}
