using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class CompetenceGroupDetails
    {
        public Guid CompetenceGroupObjNo { get; set; }
        public Guid ModelObjNo { get; set; }

        public CompetenceGroup CompetenceGroupObjNoNavigation { get; set; }
        public Model ModelObjNoNavigation { get; set; }
    }
}
