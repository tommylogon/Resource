using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class WebErrorLogins
    {
        public Guid ObjNo { get; set; }
        public string LoginName { get; set; }
        public DateTime? LoginTime { get; set; }
    }
}
