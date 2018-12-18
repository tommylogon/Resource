using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class ProblemMachine
    {
        public string Company { get; set; }
        public decimal ProblemNo { get; set; }
        public Guid MachineObjNo { get; set; }
        public int? MailWorkaround { get; set; }
        public int? MailSolution { get; set; }
        public int? MailDefault { get; set; }
        public string MachineStatus { get; set; }

        public Machine MachineObjNoNavigation { get; set; }
        public Problem Problem { get; set; }
    }
}
