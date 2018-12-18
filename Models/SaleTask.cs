using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class SaleTask
    {
        public Guid ObjNo { get; set; }
        public string TaskSubject { get; set; }
        public string TaskLevelId { get; set; }
        public string TaskCathegoryId { get; set; }
        public DateTime? TaskDateStart { get; set; }
        public DateTime? TaskDateEnd { get; set; }
        public bool? TaskCompleted { get; set; }
        public short? TaskPriority { get; set; }
        public bool? TaskReminder { get; set; }
        public DateTime? TaskReminderDatetime { get; set; }
        public string TaskOwner { get; set; }
        public Guid? TaskSale { get; set; }
        public int? TaskTypeid { get; set; }
        public bool? TaskUseTime { get; set; }
        public Guid? TaskCustomer { get; set; }
        public string ToOthers { get; set; }
        public bool? SendMail1 { get; set; }
        public bool? SendMail2 { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string CreatedBy { get; set; }
        public string TaskNode { get; set; }
        public string ExternalId { get; set; }
        public decimal? ContactNo { get; set; }
        public string TaskReminderOpenIn { get; set; }
        public string PrivateTask { get; set; }
        public string ToOthersReminder { get; set; }
        public string TaskText { get; set; }
        public Guid? ParentObjNo { get; set; }
        public string StatusText { get; set; }
        public Guid? SourceObjNo { get; set; }
        public string CustomerNode { get; set; }
        public Guid? RecurrenceObjNo { get; set; }
    }
}
