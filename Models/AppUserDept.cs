using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class AppUserDept
    {
        public string LoginName { get; set; }
        public string Company { get; set; }
        public string Dept { get; set; }

        public AppUser LoginNameNavigation { get; set; }
    }
}
