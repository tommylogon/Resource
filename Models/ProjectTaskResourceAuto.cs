using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class ProjectTaskResourceAuto
    {
        public decimal ProjectNo { get; set; }
        public decimal TaskNo { get; set; }
        public decimal ResourceNo { get; set; }
        public Guid ResourceObjNo { get; set; }
        public DateTime? AssignDate { get; set; }
        public string AssignTime { get; set; }
        public string CheckedOut { get; set; }
        public DateTime? CheckedOutDate { get; set; }
        public DateTime? CheckedInDate { get; set; }
        public string TeamLeader { get; set; }

        public ProjectTaskAuto ProjectTaskAuto { get; set; }
        public Technician ResourceObjNoNavigation { get; set; }
    }
}
