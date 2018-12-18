using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class ProjectTaskUndoCheckOut
    {
        public decimal ProjectNo { get; set; }
        public decimal TaskNo { get; set; }
        public Guid ResourceObjNo { get; set; }
        public DateTime UndoTime { get; set; }
    }
}
