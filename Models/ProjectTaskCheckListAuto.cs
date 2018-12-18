using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class ProjectTaskCheckListAuto
    {
        public string Company { get; set; }
        public decimal ProjectNo { get; set; }
        public decimal TaskNo { get; set; }
        public string Code { get; set; }
        public string CheckListId { get; set; }
        public Guid MachineObjNo { get; set; }

        public CheckList Co { get; set; }
        public ProjectTaskAuto ProjectTaskAuto { get; set; }
    }
}
