using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class CompetenceGroup
    {
        public CompetenceGroup()
        {
            CompetenceGroupDetails = new HashSet<CompetenceGroupDetails>();
            TechnicianCompetence = new HashSet<TechnicianCompetence>();
        }

        public Guid ObjNo { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public DateTime? ObjDate { get; set; }
        public string Username { get; set; }
        public string Company { get; set; }

        public Company CompanyNavigation { get; set; }
        public ICollection<CompetenceGroupDetails> CompetenceGroupDetails { get; set; }
        public ICollection<TechnicianCompetence> TechnicianCompetence { get; set; }
    }
}
