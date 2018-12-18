using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class TempOldProjectTaskCheckListValues
    {
        public string Company { get; set; }
        public decimal ProjectNo { get; set; }
        public decimal TaskNo { get; set; }
        public Guid ResourceObjNo { get; set; }
        public Guid CheckListLineObjNo { get; set; }
        public string Status { get; set; }
        public string Comment { get; set; }
        public string Diff { get; set; }
        public string Value { get; set; }
    }
}
