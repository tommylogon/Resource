using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class ProjectTemplateTasks
    {
        public Guid ObjNo { get; set; }
        public decimal TaskNo { get; set; }
        public string TaskTitle { get; set; }
        public string SymptomCode1 { get; set; }
        public string SymptomCode2 { get; set; }
        public string SymptomCode3 { get; set; }
        public string SymptomCode4 { get; set; }
        public string SymptomText { get; set; }
        public string PriorityCode { get; set; }
        public decimal? ResponseTime { get; set; }
        public decimal? TimeEstimate { get; set; }
        public string CheckListCode { get; set; }
    }
}
