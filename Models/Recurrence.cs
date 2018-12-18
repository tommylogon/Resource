using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class Recurrence
    {
        public Guid ObjNo { get; set; }
        public Guid SourceObjNo { get; set; }
        public decimal? DayOfMonth { get; set; }
        public decimal? DayOfWeekMask { get; set; }
        public decimal? Duration { get; set; }
        public DateTime? EndTime { get; set; }
        public decimal? Instance { get; set; }
        public decimal? Interval { get; set; }
        public decimal? MonthOfYear { get; set; }
        public bool? NoEndDate { get; set; }
        public decimal? Occurences { get; set; }
        public DateTime? PatternEndDate { get; set; }
        public DateTime? PatternStartDate { get; set; }
        public decimal? RecurrenceType { get; set; }
        public bool? Regenerate { get; set; }
        public DateTime? StartTime { get; set; }
        public decimal? NumDaysAhead { get; set; }
        public DateTime? ObjDate { get; set; }
        public string ServiceIntervalOn { get; set; }
        public decimal? ServiceInterval { get; set; }
        public string ServiceIntervalOnly { get; set; }
        public string ServiceIntervalUseEstimated { get; set; }
        public decimal? ServiceIntervalFirstCounter { get; set; }
    }
}
