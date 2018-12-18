using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class DatabaseLog
    {
        public Guid ObjNo { get; set; }
        public string LogType { get; set; }
        public Guid? SourceObjNo { get; set; }
        public decimal? SourceHeadingNo { get; set; }
        public decimal? SourceRowNo { get; set; }
        public DateTime? LogDate { get; set; }
        public string LogUser { get; set; }
        public string LogInfo { get; set; }
        public string LogComment { get; set; }
    }
}
