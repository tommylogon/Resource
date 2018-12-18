using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class SdVersion
    {
        public string ProductName { get; set; }
        public string VersionNo { get; set; }
        public DateTime? VersionDate { get; set; }
        public string Comment { get; set; }
    }
}
