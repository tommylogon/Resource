using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class CheckListSymptomDependencies
    {
        public string CheckListCode { get; set; }
        public decimal? SymptomCodeNo { get; set; }
        public string SymptomCode { get; set; }
        public string AutoAdd { get; set; }
        public string Mandatory { get; set; }
        public string Company { get; set; }
        public string SymptomCode1 { get; set; }
        public string SymptomCode2 { get; set; }
        public string SymptomCode3 { get; set; }
    }
}
