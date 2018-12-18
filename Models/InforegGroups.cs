using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class InforegGroups
    {
        public string Registry { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Company { get; set; }
        public int? Inactive { get; set; }
    }
}
