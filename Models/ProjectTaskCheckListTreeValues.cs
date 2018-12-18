using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class ProjectTaskCheckListTreeValues
    {
        public string Company { get; set; }
        public string CheckListCode { get; set; }
        public decimal ProjectNo { get; set; }
        public decimal TaskNo { get; set; }
        public Guid ResourceObjNo { get; set; }
        public string CheckListNodeKey { get; set; }
        public string Status { get; set; }
        public DateTime? ObjDate { get; set; }
        public string Username { get; set; }
        public string Comment { get; set; }
        public string Value { get; set; }
        public string StatGroup { get; set; }
        public string CheckListId { get; set; }
        public Guid MachineObjNo { get; set; }
    }
}
