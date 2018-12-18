using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class ProjectTaskStartStop
    {
        public string Company { get; set; }
        public decimal ProjectNo { get; set; }
        public decimal TaskNo { get; set; }
        public Guid? TechnicianObjNo { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime StopTime { get; set; }
        public string Type { get; set; }
        public string InvoiceText { get; set; }
        public decimal? Qty { get; set; }
        public string Invoiceable { get; set; }
        public Guid? ArticleObjNo { get; set; }
        public decimal SeqNo { get; set; }
        public string Descr { get; set; }
        public string Status { get; set; }
        public decimal? OrderNo { get; set; }
        public decimal? LineNo { get; set; }
        public Guid? CpuObjNo { get; set; }
        public string ServicesCode { get; set; }

        public ProjectTask ProjectTask { get; set; }
        public Technician TechnicianObjNoNavigation { get; set; }
    }
}
