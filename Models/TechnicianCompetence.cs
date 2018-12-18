using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class TechnicianCompetence
    {
        public Guid CompetenceGroupObjNo { get; set; }
        public Guid TechnicianObjNo { get; set; }

        public CompetenceGroup CompetenceGroupObjNoNavigation { get; set; }
        public Technician TechnicianObjNoNavigation { get; set; }
    }
}
