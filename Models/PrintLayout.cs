using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class PrintLayout
    {
        public Guid ObjNo { get; set; }
        public string ReportName { get; set; }
        public string LanguageId { get; set; }
        public byte[] FileData { get; set; }
        public Guid? SourceObjNo { get; set; }
        public DateTime? DateChanged { get; set; }
        public string Company { get; set; }
        public string OrderType { get; set; }
    }
}
