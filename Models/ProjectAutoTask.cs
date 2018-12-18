using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class ProjectAutoTask
    {
        public Guid ObjNo { get; set; }
        public string Company { get; set; }
        public string Dept { get; set; }
        public Guid? CustomerObjNo { get; set; }
        public Guid? MachineObjNo { get; set; }
        public decimal? AddressRowNo { get; set; }
        public string PriorityCode { get; set; }
        public string SymptomCode1 { get; set; }
        public string SymptomText { get; set; }
        public string Node { get; set; }
        public DateTime? StartDate { get; set; }
        public decimal? DaysBeetween { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? LastCheck { get; set; }
        public DateTime? LastTask { get; set; }
        public Guid? LastTaskObjNo { get; set; }
        public string Owner { get; set; }
        public Guid? ResourceObjNo { get; set; }
        public string PlannedHourOfDay { get; set; }
        public decimal? PlannedDuration { get; set; }
        public decimal? NumDaysAhead { get; set; }

        public Customer CustomerObjNoNavigation { get; set; }
        public Department Department { get; set; }
        public Machine MachineObjNoNavigation { get; set; }
    }
}
