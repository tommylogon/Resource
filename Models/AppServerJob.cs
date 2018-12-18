using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class AppServerJob
    {
        public Guid ObjNo { get; set; }
        public int JobType { get; set; }
        public string Parameters { get; set; }
        public DateTime? ObjDate { get; set; }
        public string Username { get; set; }
        public string Status { get; set; }
        public DateTime? ObjDateExecuted { get; set; }
        public string ExecutedInformation { get; set; }
    }
}
