using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class TempOldCheckListValues
    {
        public string Company { get; set; }
        public string Code { get; set; }
        public Guid LineObjNo { get; set; }
        public string Description { get; set; }
        public int? LineNo { get; set; }
        public string Mandatory { get; set; }
        public string Value { get; set; }

        public CheckList Co { get; set; }
    }
}
