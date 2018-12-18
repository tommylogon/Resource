using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class TechnicianTeams
    {
        public Guid TechnicianObjNo { get; set; }
        public Guid TeamObjNo { get; set; }
        public int Type { get; set; }

        public Team TeamObjNoNavigation { get; set; }
        public Technician TechnicianObjNoNavigation { get; set; }
    }
}
