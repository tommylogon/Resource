using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class TechnicianPushToken
    {
        public int Id { get; set; }
        public string Token { get; set; }
        public Guid TechnicianObjNo { get; set; }
        public string Platform { get; set; }
        public DateTime? ObjDate { get; set; }
        public string Language { get; set; }
        public bool? GpsTracking { get; set; }

        public Technician TechnicianObjNoNavigation { get; set; }
    }
}
