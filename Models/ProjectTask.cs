using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class ProjectTask
    {
        public ProjectTask()
        {
            ProblemTask = new HashSet<ProblemTask>();
            ProjectTaskCheckList = new HashSet<ProjectTaskCheckList>();
            ProjectTaskResource = new HashSet<ProjectTaskResource>();
            ProjectTaskStartStop = new HashSet<ProjectTaskStartStop>();
        }

        public decimal ProjectNo { get; set; }
        public decimal TaskNo { get; set; }
        public Guid? MachineObjNo { get; set; }
        public Guid? CustomerObjNo { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Location { get; set; }
        public string PostalCode { get; set; }
        public Guid? AreaObjNo { get; set; }
        public string Contact { get; set; }
        public string ContactEmail { get; set; }
        public string ReceivedBy { get; set; }
        public DateTime ReceivedDate { get; set; }
        public decimal? ResponseTime { get; set; }
        public DateTime? ResponseDate { get; set; }
        public string SymptomCode1 { get; set; }
        public string SymptomCode2 { get; set; }
        public string SymptomCode3 { get; set; }
        public string PriorityCode { get; set; }
        public string Node { get; set; }
        public string Status { get; set; }
        public string ActionCode1 { get; set; }
        public string ActionCode2 { get; set; }
        public string ActionCode3 { get; set; }
        public DateTime? DateReported { get; set; }
        public DateTime? ObjDate { get; set; }
        public string Username { get; set; }
        public string Country { get; set; }
        public string PhoneNo { get; set; }
        public string FaxNo { get; set; }
        public DateTime? DateResponse { get; set; }
        public decimal? TimeEstimate { get; set; }
        public string AddressName { get; set; }
        public Guid? ObjNo { get; set; }
        public string ColorCode { get; set; }
        public decimal? CoordX { get; set; }
        public decimal? CoordY { get; set; }
        public string CheckedOut { get; set; }
        public string CheckedOutBy { get; set; }
        public DateTime? CheckedOutDate { get; set; }
        public DateTime? CheckedInDate { get; set; }
        public string ProjectTaskStatus { get; set; }
        public string SymptomTag { get; set; }
        public string PostalDescription { get; set; }
        public decimal? FixedPrice { get; set; }
        public decimal? ResourcePriority { get; set; }
        public Guid? ContractTypeObjNo { get; set; }
        public string CustomerNode { get; set; }
        public string Address3 { get; set; }
        public int Type { get; set; }
        public Guid? RespCustomerObjNo { get; set; }
        public DateTime? OnHold { get; set; }
        public string SymptomCode4 { get; set; }
        public string ActionCode4 { get; set; }
        public string OrgNode { get; set; }
        public string OrgPriorityCode { get; set; }
        public Guid? SourceObjNo { get; set; }
        public decimal? ExternalProjectNo { get; set; }
        public decimal? ExternalTaskNo { get; set; }
        public string ExternalReplyMailAddress { get; set; }
        public string ExternalStatus { get; set; }
        public string Info01 { get; set; }
        public string Info02 { get; set; }
        public string Info03 { get; set; }
        public string Info04 { get; set; }
        public string Info05 { get; set; }
        public string Info06 { get; set; }
        public string LanguageId { get; set; }
        public decimal? CostPrice { get; set; }
        public string State { get; set; }
        public string TaskTitle { get; set; }
        public string OrderInformation { get; set; }
        public string MobilePhoneNo { get; set; }
        public Guid? ContractObjNo { get; set; }
        public decimal? SolutionTime { get; set; }
        public DateTime? SolutionDate { get; set; }
        public Guid? CpuObjNo { get; set; }
        public string ServicesCode { get; set; }
        public string CustomerSignatureName { get; set; }
        public string AddressPhoneNo { get; set; }
        public string IncidentStatus { get; set; }
        public string ClosureCode { get; set; }
        public Guid? ExternalSystemObjNo { get; set; }
        public int? CustomerSatisfaction { get; set; }
        public string ActionText { get; set; }
        public string CommentInternal { get; set; }
        public string SymptomText { get; set; }

        public Area AreaObjNoNavigation { get; set; }
        public Customer CustomerObjNoNavigation { get; set; }
        public Machine MachineObjNoNavigation { get; set; }
        public Project ProjectNoNavigation { get; set; }
        public Customer RespCustomerObjNoNavigation { get; set; }
        public ICollection<ProblemTask> ProblemTask { get; set; }
        public ICollection<ProjectTaskCheckList> ProjectTaskCheckList { get; set; }
        public ICollection<ProjectTaskResource> ProjectTaskResource { get; set; }
        public ICollection<ProjectTaskStartStop> ProjectTaskStartStop { get; set; }
    }
}
