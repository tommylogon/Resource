using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class MeterReadingLog
    {
        public Guid MachineObjNo { get; set; }
        public Guid MeterObjNo { get; set; }
        public DateTime ObjDate { get; set; }
        public string Username { get; set; }
        public string Source { get; set; }
        public string OldReadingType { get; set; }
        public DateTime OldReadingDate { get; set; }
        public decimal? OldCounter { get; set; }
        public decimal? OldReadingYear { get; set; }
        public decimal? OldProjectNo { get; set; }
        public decimal? OldTaskNo { get; set; }
        public decimal? OldReadingLap { get; set; }
        public string OldEstimated { get; set; }
        public string OldImported { get; set; }
        public string ChangeType { get; set; }
    }
}
