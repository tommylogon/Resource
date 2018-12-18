using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class LinkTransportLog
    {
        public Guid ObjNo { get; set; }
        public decimal ProjectNo { get; set; }
        public decimal? ProjectNoExternal { get; set; }
        public decimal TaskNo { get; set; }
        public decimal? TaskNoExternal { get; set; }
        public string Sent { get; set; }
        public string PartnerName { get; set; }
        public DateTime? AssignDate { get; set; }
        public DateTime SentDate { get; set; }
        public string StatusMsg { get; set; }
        public string StepType { get; set; }
        public Guid? PartnerObjNo { get; set; }
        public DateTime? ObjDate { get; set; }
    }
}
