using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class SaleBookmark
    {
        public Guid ObjNo { get; set; }
        public string BookmarkName { get; set; }
        public string BookmarkValue { get; set; }
        public bool? BookmarkGlobal { get; set; }
        public string BookmarkOwner { get; set; }
        public int? BookmarkType { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string Dept { get; set; }
        public string Company { get; set; }

        public AppUser BookmarkOwnerNavigation { get; set; }
    }
}
