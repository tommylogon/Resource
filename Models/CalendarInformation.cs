using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class CalendarInformation
    {
        public string Company { get; set; }
        public Guid ObjNo { get; set; }
        public Guid UserLinkObjNo { get; set; }
        public string CalendarType { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public string CalendarText { get; set; }
        public Guid? SourceObjNo { get; set; }
    }
}
