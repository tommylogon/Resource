using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class Technician
    {
        public Technician()
        {
            AreaResource = new HashSet<AreaResource>();
            CustomerTechnician = new HashSet<CustomerTechnician>();
            MobileSession = new HashSet<MobileSession>();
            ProjectTaskResource = new HashSet<ProjectTaskResource>();
            ProjectTaskResourceAuto = new HashSet<ProjectTaskResourceAuto>();
            ProjectTaskStartStop = new HashSet<ProjectTaskStartStop>();
            TechnicianAvailability = new HashSet<TechnicianAvailability>();
            TechnicianCompetence = new HashSet<TechnicianCompetence>();
            TechnicianPlannerNode = new HashSet<TechnicianPlannerNode>();
            TechnicianPushLog = new HashSet<TechnicianPushLog>();
            TechnicianPushToken = new HashSet<TechnicianPushToken>();
            TechnicianServicesArticles = new HashSet<TechnicianServicesArticles>();
            TechnicianServicesArticlesPrice = new HashSet<TechnicianServicesArticlesPrice>();
            TechnicianTeams = new HashSet<TechnicianTeams>();
        }

        public Guid ObjNo { get; set; }
        public string Company { get; set; }
        public string Dept { get; set; }
        public string TechnicianNo { get; set; }
        public string TechnicianName { get; set; }
        public string PhoneNo { get; set; }
        public string FaxNo { get; set; }
        public string MobilePhoneNo { get; set; }
        public Guid? StockObjNo { get; set; }
        public string Node { get; set; }
        public Guid? SalesmanObjNo { get; set; }
        public string Status { get; set; }
        public string EMail { get; set; }
        public decimal? CoordX { get; set; }
        public decimal? CoordY { get; set; }
        public string MsgText { get; set; }
        public DateTime? MsgObjDate { get; set; }
        public string MsgUsername { get; set; }
        public int? UseMobile { get; set; }
        public string MsgTextIn { get; set; }
        public DateTime? MsgObjDateIn { get; set; }
        public string MsgUsernameIn { get; set; }
        public string WorkStatus { get; set; }
        public DateTime? WorkStatusObjDate { get; set; }
        public string MsgTextRead { get; set; }
        public string MobilePassword { get; set; }
        public int Type { get; set; }
        public string SupportNode { get; set; }
        public string SupportAllowToAssignOther { get; set; }
        public string SupportShowOnHold { get; set; }
        public string SupportAdministrator { get; set; }
        public decimal? SupportMaximumNumberOfTasks { get; set; }
        public decimal? SupportMaximumNumberOfTasksEachGroup { get; set; }
        public string SupportAllowSeeAssignedTasks { get; set; }
        public string SupportAllowSeeAssignedTasksOthers { get; set; }
        public string SupportAllowSort { get; set; }
        public string Info01 { get; set; }
        public string Info02 { get; set; }
        public string Info03 { get; set; }
        public string Info04 { get; set; }
        public string Info05 { get; set; }
        public string Info06 { get; set; }
        public string Info07 { get; set; }
        public string Info08 { get; set; }
        public string Info09 { get; set; }
        public string Info10 { get; set; }
        public string Sortgroup1 { get; set; }
        public string Sortgroup2 { get; set; }
        public string Sortgroup3 { get; set; }
        public string Sortgroup4 { get; set; }
        public string Sortgroup5 { get; set; }
        public Guid? ResponsibleTechnicianObjNo { get; set; }
        public int? MobilePlannerMode { get; set; }
        public int? UseMobilePc { get; set; }
        public int? UseMobileTomtom { get; set; }
        public int? UseMobilePhone { get; set; }
        public DateTime? LastMobileActionObjDate { get; set; }
        public string SupportAllowDelete { get; set; }
        public string EmpFunction { get; set; }
        public DateTime? ObjDate { get; set; }
        public string Username { get; set; }
        public string SupportAllowNotSolved { get; set; }
        public string ShowPriorityAlertMessage { get; set; }
        public string AutosyncBasicData { get; set; }
        public string AutosyncArticleData { get; set; }
        public int? UseMobileEma { get; set; }
        public string SupportAllowChangeNode { get; set; }
        public int? MobileMachineEdit { get; set; }
        public int? UseMobileEmw { get; set; }
        public int? MobileCreateProject { get; set; }
        public DateTime? GpsObjDate { get; set; }
        public decimal? GpsCoordX { get; set; }
        public decimal? GpsCoordY { get; set; }
        public string Layout { get; set; }
        public int? UserIdentityId { get; set; }

        public Company CompanyNavigation { get; set; }
        public Department Department { get; set; }
        public Salesman SalesmanObjNoNavigation { get; set; }
        public Stock StockObjNoNavigation { get; set; }
        public UserIdentity UserIdentity { get; set; }
        public ICollection<AreaResource> AreaResource { get; set; }
        public ICollection<CustomerTechnician> CustomerTechnician { get; set; }
        public ICollection<MobileSession> MobileSession { get; set; }
        public ICollection<ProjectTaskResource> ProjectTaskResource { get; set; }
        public ICollection<ProjectTaskResourceAuto> ProjectTaskResourceAuto { get; set; }
        public ICollection<ProjectTaskStartStop> ProjectTaskStartStop { get; set; }
        public ICollection<TechnicianAvailability> TechnicianAvailability { get; set; }
        public ICollection<TechnicianCompetence> TechnicianCompetence { get; set; }
        public ICollection<TechnicianPlannerNode> TechnicianPlannerNode { get; set; }
        public ICollection<TechnicianPushLog> TechnicianPushLog { get; set; }
        public ICollection<TechnicianPushToken> TechnicianPushToken { get; set; }
        public ICollection<TechnicianServicesArticles> TechnicianServicesArticles { get; set; }
        public ICollection<TechnicianServicesArticlesPrice> TechnicianServicesArticlesPrice { get; set; }
        public ICollection<TechnicianTeams> TechnicianTeams { get; set; }
    }
}
