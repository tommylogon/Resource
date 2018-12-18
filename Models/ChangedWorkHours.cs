using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class ChangedWorkHours
    {
        public string Company { get; set; }
        public DateTime DateToChange { get; set; }
        public string Hours { get; set; }
        public Guid ObjNo { get; set; }
        public string Dept { get; set; }
        public Guid? SourceObjNo { get; set; }
    }
}
