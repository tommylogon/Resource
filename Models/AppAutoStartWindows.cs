using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class AppAutoStartWindows
    {
        public Guid ObjNo { get; set; }
        public string Company { get; set; }
        public string Usermame { get; set; }
        public string OpenIn { get; set; }
        public string Parameters { get; set; }
        public DateTime? ObjDate { get; set; }
        public DateTime? ValidTo { get; set; }
        public int? Status { get; set; }
    }
}
