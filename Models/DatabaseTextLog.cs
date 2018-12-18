using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class DatabaseTextLog
    {
        public string LogType { get; set; }
        public Guid SourceObjNo { get; set; }
        public string LogUser { get; set; }
        public DateTime LogDate { get; set; }
        public string LogText { get; set; }
    }
}
