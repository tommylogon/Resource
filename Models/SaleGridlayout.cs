using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class SaleGridlayout
    {
        public Guid ObjNo { get; set; }
        public string LayoutName { get; set; }
        public byte[] LayoutFile { get; set; }
        public string GridOwner { get; set; }
        public string Language { get; set; }
        public string Application { get; set; }
        public DateTime? DateChanged { get; set; }

        public AppUser GridOwnerNavigation { get; set; }
    }
}
