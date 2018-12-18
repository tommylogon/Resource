using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class EmpChecker
    {
        public Guid ResourceObjNo { get; set; }
        public DateTime? ObjDate { get; set; }
        public string Checker { get; set; }
        public string Description { get; set; }
    }
}
