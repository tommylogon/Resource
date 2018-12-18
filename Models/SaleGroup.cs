using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class SaleGroup
    {
        public SaleGroup()
        {
            SaleGroupSelected = new HashSet<SaleGroupSelected>();
        }

        public Guid ObjNo { get; set; }
        public string GroupName { get; set; }
        public int? GroupType { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? LastUpdated { get; set; }
        public decimal? RowNo { get; set; }
        public string Company { get; set; }

        public ICollection<SaleGroupSelected> SaleGroupSelected { get; set; }
    }
}
