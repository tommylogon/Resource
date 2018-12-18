using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class Team
    {
        public Team()
        {
            TeamNodes = new HashSet<TeamNodes>();
            TechnicianTeams = new HashSet<TechnicianTeams>();
        }

        public Guid ObjNo { get; set; }
        public string Company { get; set; }
        public string TeamCode { get; set; }
        public string TeamDescription { get; set; }
        public int? Type { get; set; }
        public Guid? TeamOwner { get; set; }
        public string Dept { get; set; }

        public ICollection<TeamNodes> TeamNodes { get; set; }
        public ICollection<TechnicianTeams> TechnicianTeams { get; set; }
    }
}
