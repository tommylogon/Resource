using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class IncidentStatus
    {
        public string Company { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string SolutionTime { get; set; }
        public string AllowClose { get; set; }
        public int? Inactive { get; set; }
    }
}
