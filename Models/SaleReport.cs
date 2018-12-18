using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class SaleReport
    {
        public Guid? ObjNo { get; set; }
        public string ReportOwner { get; set; }
        public string ReportType { get; set; }
        public string ReportName { get; set; }
        public string ReportDescription { get; set; }
        public int? DocumentType { get; set; }
        public decimal Index { get; set; }
        public string Sql { get; set; }
        public string GlobalReport { get; set; }
        public string ReportPassword { get; set; }
        public string ReportOpenIn { get; set; }
        public string ReportNode { get; set; }
        public string ReportTable { get; set; }
        public decimal? Keycolumns { get; set; }
        public string ShowLimitations { get; set; }
        public string UseMerging { get; set; }
    }
}
