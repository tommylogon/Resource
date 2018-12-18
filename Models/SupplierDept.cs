using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class SupplierDept
    {
        public Guid SupplierObjNo { get; set; }
        public string Company { get; set; }
        public string Dept { get; set; }

        public Supplier SupplierObjNoNavigation { get; set; }
    }
}
