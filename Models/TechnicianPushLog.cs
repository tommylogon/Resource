using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class TechnicianPushLog
    {
        public int Id { get; set; }
        public Guid TechnicianObjNo { get; set; }
        public int PushType { get; set; }
        public int PushBadge { get; set; }
        public DateTime PushTime { get; set; }
        public bool Active { get; set; }

        public Technician TechnicianObjNoNavigation { get; set; }
    }
}
