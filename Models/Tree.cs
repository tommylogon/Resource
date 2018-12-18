using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class Tree
    {
        public string Company { get; set; }
        public string Dept { get; set; }
        public string TreeName { get; set; }
        public string NodeKey { get; set; }
        public decimal TreeLevel { get; set; }
        public decimal NodeLevel { get; set; }
        public string ParentKey { get; set; }
        public string NodeText { get; set; }
        public Guid? SourceObjNo { get; set; }
        public string NodeTag { get; set; }
    }
}
