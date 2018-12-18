using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class AppMobileLoginCheck
    {
        public Guid ResourceObjNo { get; set; }
        public DateTime? ObjDate { get; set; }
        public string SessionId { get; set; }
    }
}
