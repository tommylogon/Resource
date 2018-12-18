using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class AreaResource
    {
        public Guid AreaObjNo { get; set; }
        public Guid TechnicianObjNo { get; set; }

        public Area AreaObjNoNavigation { get; set; }
        public Technician TechnicianObjNoNavigation { get; set; }
    }
}
