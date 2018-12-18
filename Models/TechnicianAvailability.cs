using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class TechnicianAvailability
    {
        public Guid TechnicianObjNo { get; set; }
        public DateTime DateFrom { get; set; }
        public decimal? Duration { get; set; }
        public string BarText { get; set; }
        public string AvailabilityType { get; set; }
        public decimal AvailNo { get; set; }
        public string ExternalId { get; set; }
        public DateTime? LastUpdated { get; set; }

        public Technician TechnicianObjNoNavigation { get; set; }
    }
}
