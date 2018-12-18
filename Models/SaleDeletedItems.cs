using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class SaleDeletedItems
    {
        public Guid SourceObjNo { get; set; }
        public string ItemType { get; set; }
        public DateTime DateDeleted { get; set; }
    }
}
