using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class TechnicianPlannerNode
    {
        public Guid TechnicianObjNo { get; set; }
        public string Node { get; set; }

        public Technician TechnicianObjNoNavigation { get; set; }
    }
}
