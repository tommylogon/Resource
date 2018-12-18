using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class PropertyValues
    {
        public string Company { get; set; }
        public string Registry { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string DropdownValues { get; set; }
        public int? UseValues { get; set; }
        public string DataType { get; set; }
        public int? MinLen { get; set; }
        public int? MaxLen { get; set; }
        public int? Mandatory { get; set; }
        public int? SyncToMobile { get; set; }
    }
}
