using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class TechnicianServicesArticles
    {
        public Guid TechnicianObjNo { get; set; }
        public string ArticleType { get; set; }
        public string UseAsDefault { get; set; }
        public string HourReg { get; set; }

        public Technician TechnicianObjNoNavigation { get; set; }
    }
}
