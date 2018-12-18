using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class MobileSession
    {
        public int MobileSessionId { get; set; }
        public Guid MobileSessionObjNo { get; set; }
        public Guid TechnicianObjNo { get; set; }
        public DateTime StartedAt { get; set; }
        public DateTime ExpiresAt { get; set; }
        public string EmVersion { get; set; }
        public string EmsVersion { get; set; }
        public string Cordova { get; set; }
        public string Platform { get; set; }
        public string Uuid { get; set; }
        public string Model { get; set; }
        public string Version { get; set; }

        public Technician TechnicianObjNoNavigation { get; set; }
    }
}
