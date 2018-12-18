using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class TeamNodes
    {
        public Guid TeamObjNo { get; set; }
        public string Node { get; set; }

        public Team TeamObjNoNavigation { get; set; }
    }
}
