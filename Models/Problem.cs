using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class Problem
    {
        public Problem()
        {
            ProblemMachine = new HashSet<ProblemMachine>();
            ProblemTask = new HashSet<ProblemTask>();
        }

        public string Company { get; set; }
        public Guid ObjNo { get; set; }
        public decimal ProblemNo { get; set; }
        public string TaskStatus { get; set; }
        public int? Status { get; set; }
        public int ProblemStatus { get; set; }
        public DateTime ProblemCreated { get; set; }
        public DateTime? ProblemReported { get; set; }
        public string ProblemUrl { get; set; }
        public int ProblemType { get; set; }
        public string ProblemName { get; set; }
        public string ProblemDescription { get; set; }
        public string ProblemManager { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public string SymptomCode1 { get; set; }
        public string SymptomCode2 { get; set; }
        public string SymptomCode3 { get; set; }
        public string SymptomCode4 { get; set; }
        public string ActionCode1 { get; set; }
        public string ActionCode2 { get; set; }
        public string ActionCode3 { get; set; }
        public string ActionCode4 { get; set; }
        public Guid? ModelObjNo { get; set; }
        public DateTime? ExpectedEndDate { get; set; }
        public string WorkaroundLog { get; set; }
        public string WorkaroundInernalDesc { get; set; }
        public string WorkaroundCustomerDesc { get; set; }
        public string AnalysisLog { get; set; }
        public string SolutionInternalDesc { get; set; }
        public string SolutionCustomerDesc { get; set; }
        public int? WorkaroundStatus { get; set; }
        public int? AnalysisStatus { get; set; }
        public int? SolutionStatus { get; set; }
        public int? ShowTasks { get; set; }
        public int? ShowMachines { get; set; }
        public string MachineNoFrom { get; set; }
        public string MachineNoTo { get; set; }
        public DateTime? InstallationDateFrom { get; set; }
        public DateTime? InstallationDateTo { get; set; }

        public Model ModelObjNoNavigation { get; set; }
        public ICollection<ProblemMachine> ProblemMachine { get; set; }
        public ICollection<ProblemTask> ProblemTask { get; set; }
    }
}
