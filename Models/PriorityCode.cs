using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class PriorityCode
    {
        public string Company { get; set; }
        public string Dept { get; set; }
        public string PriorityCode1 { get; set; }
        public string PriorityText { get; set; }
        public decimal? Color { get; set; }
        public decimal? Pri { get; set; }
        public decimal? ResponseTime { get; set; }

        public Department Department { get; set; }
    }
}
