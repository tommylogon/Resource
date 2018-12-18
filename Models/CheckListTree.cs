using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class CheckListTree
    {
        public string Company { get; set; }
        public string CheckListCode { get; set; }
        public string NodeKey { get; set; }
        public decimal TreeLevel { get; set; }
        public decimal NodeLevel { get; set; }
        public string ParentKey { get; set; }
        public string NodeText { get; set; }
        public int GroupType { get; set; }
        public int? DataType { get; set; }
        public string PreValues { get; set; }
        public string StdValue { get; set; }
        public string Mandatory { get; set; }
        public string History { get; set; }
        public string PrintOrder { get; set; }
        public string StdValueFromHistory { get; set; }
        public string MandatoryBeforeStart { get; set; }
        public string ExpandDefValue { get; set; }
        public string ExpandValue { get; set; }
        public string ShowStatGroup { get; set; }
        public string ShowComment { get; set; }
    }
}
