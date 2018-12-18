using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class ProjectTaskCheckListTreeFiles
    {
        public string Company { get; set; }
        public string CheckListCode { get; set; }
        public decimal ProjectNo { get; set; }
        public decimal TaskNo { get; set; }
        public Guid ResourceObjNo { get; set; }
        public string CheckListNodeKey { get; set; }
        public string CheckListId { get; set; }
        public Guid MachineObjNo { get; set; }
        public decimal FileNo { get; set; }
        public string FileType { get; set; }
        public string FileTitle { get; set; }
        public DateTime? FileDate { get; set; }
        public byte[] FileData { get; set; }
        public DateTime? ObjDate { get; set; }
        public string Username { get; set; }
    }
}
