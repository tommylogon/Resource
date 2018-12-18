using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class ProblemTask
    {
        public string Company { get; set; }
        public decimal ProblemNo { get; set; }
        public decimal ProjectNo { get; set; }
        public decimal TaskNo { get; set; }
        public string InternalText { get; set; }
        public int? MailWorkaround { get; set; }
        public int? MailSolution { get; set; }
        public int? MailDefault { get; set; }
        public string IncidentStatus { get; set; }

        public Problem Problem { get; set; }
        public ProjectTask ProjectTask { get; set; }
    }
}
