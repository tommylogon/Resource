using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class Department
    {
        public Department()
        {
            Area = new HashSet<Area>();
            Contract = new HashSet<Contract>();
            Customer = new HashSet<Customer>();
            Machine = new HashSet<Machine>();
            OrderHeading = new HashSet<OrderHeading>();
            PriorityCode = new HashSet<PriorityCode>();
            Project = new HashSet<Project>();
            ProjectAuto = new HashSet<ProjectAuto>();
            ProjectAutoTask = new HashSet<ProjectAutoTask>();
            Technician = new HashSet<Technician>();
        }

        public string Company { get; set; }
        public string Dept { get; set; }
        public string DepartmentName { get; set; }
        public string PhoneNo { get; set; }
        public string FaxNo { get; set; }
        public string BankAccountNo { get; set; }
        public string PostAccountNo { get; set; }
        public string CompanyNo { get; set; }
        public decimal? InvoiceNo { get; set; }
        public decimal? OrderNo { get; set; }
        public string Country { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string PostalCode { get; set; }
        public string OrderTypeOrder { get; set; }
        public string OrderTypeContract { get; set; }
        public string OrderTypeProject { get; set; }
        public string PostalDescription { get; set; }
        public string OrderTypeContractMr { get; set; }
        public string CreditorId { get; set; }
        public string Iban { get; set; }
        public string Bic { get; set; }

        public Company CompanyNavigation { get; set; }
        public ICollection<Area> Area { get; set; }
        public ICollection<Contract> Contract { get; set; }
        public ICollection<Customer> Customer { get; set; }
        public ICollection<Machine> Machine { get; set; }
        public ICollection<OrderHeading> OrderHeading { get; set; }
        public ICollection<PriorityCode> PriorityCode { get; set; }
        public ICollection<Project> Project { get; set; }
        public ICollection<ProjectAuto> ProjectAuto { get; set; }
        public ICollection<ProjectAutoTask> ProjectAutoTask { get; set; }
        public ICollection<Technician> Technician { get; set; }
    }
}
