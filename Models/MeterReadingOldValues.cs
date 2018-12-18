using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class MeterReadingOldValues
    {
        public Guid MachineObjNo { get; set; }
        public Guid MeterObjNo { get; set; }
        public DateTime ReadingDate { get; set; }
        public decimal? Counter { get; set; }
        public string ReadingType { get; set; }
        public decimal? ReadingYear { get; set; }
        public decimal? ProjectNo { get; set; }
        public decimal? TaskNo { get; set; }
        public decimal? ReadingLap { get; set; }
        public string Estimated { get; set; }
        public string Imported { get; set; }
        public int? ReportCounter { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedSource { get; set; }
        public DateTime? ObjDate { get; set; }
        public string Username { get; set; }
        public string Source { get; set; }

        public Machine MachineObjNoNavigation { get; set; }
        public Meter MeterObjNoNavigation { get; set; }
    }
}
