using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class SaleGroupSelected
    {
        public Guid SourceObjNo { get; set; }
        public Guid GroupObjNo { get; set; }
        public decimal? ContactNo { get; set; }
        public DateTime? LastUpdated { get; set; }
        public decimal IdColumn { get; set; }

        public SaleGroup GroupObjNoNavigation { get; set; }
    }
}
