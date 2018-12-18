using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class CustomerTechnician
    {
        public Guid CustomerObjNo { get; set; }
        public Guid TechnicianObjNo { get; set; }

        public Customer CustomerObjNoNavigation { get; set; }
        public Technician TechnicianObjNoNavigation { get; set; }
    }
}
