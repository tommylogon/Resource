using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class ProjectAuto
    {
        public ProjectAuto()
        {
            ProjectTaskAuto = new HashSet<ProjectTaskAuto>();
        }

        public decimal ProjectNo { get; set; }
        public string Company { get; set; }
        public string Dept { get; set; }
        public string Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Owner { get; set; }
        public Guid? CustomerObjNo { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string PostalCode { get; set; }
        public Guid? AreaObjNo { get; set; }
        public string Contact { get; set; }
        public string ContactEmail { get; set; }
        public string PhoneNo { get; set; }
        public string FaxNo { get; set; }
        public string Country { get; set; }
        public string Status { get; set; }
        public Guid? ObjNo { get; set; }
        public string CustomerName { get; set; }
        public string PostalDescription { get; set; }
        public string CustomerReference { get; set; }
        public string Address3 { get; set; }
        public string Info01 { get; set; }
        public string Info02 { get; set; }
        public string Info03 { get; set; }
        public string Info04 { get; set; }
        public string Info05 { get; set; }
        public string Info06 { get; set; }
        public string State { get; set; }
        public string MobilePhoneNo { get; set; }
        public string ObjectOpen { get; set; }
        public string ObjectOpenedBy { get; set; }
        public DateTime? ObjectOpenedDate { get; set; }
        public string CustomerReferenceInfo { get; set; }

        public Area AreaObjNoNavigation { get; set; }
        public Company CompanyNavigation { get; set; }
        public Customer CustomerObjNoNavigation { get; set; }
        public Department Department { get; set; }
        public ICollection<ProjectTaskAuto> ProjectTaskAuto { get; set; }
    }
}
