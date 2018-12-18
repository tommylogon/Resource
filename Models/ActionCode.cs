using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class ActionCode
    {
        public string Company { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        public Company CompanyNavigation { get; set; }
    }
}
