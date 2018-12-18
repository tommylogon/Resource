using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class MachineRelation
    {
        public Guid PrimaryObjNo { get; set; }
        public Guid RelationObjNo { get; set; }
        public decimal? SortOrder { get; set; }
        public DateTime? ObjDate { get; set; }
        public string ObjUser { get; set; }
        public decimal? TreeLevel { get; set; }
    }
}
