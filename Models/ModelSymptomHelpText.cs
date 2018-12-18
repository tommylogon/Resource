using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class ModelSymptomHelpText
    {
        public Guid ModelObjNo { get; set; }
        public decimal SymptomCodeNo { get; set; }
        public string SymptomCode { get; set; }
        public string HelpText { get; set; }
    }
}
