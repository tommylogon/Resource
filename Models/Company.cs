using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class Company
    {
        public Company()
        {
            ActionCode = new HashSet<ActionCode>();
            Area = new HashSet<Area>();
            Article = new HashSet<Article>();
            CheckList = new HashSet<CheckList>();
            CompetenceGroup = new HashSet<CompetenceGroup>();
            Contract = new HashSet<Contract>();
            ContractTemplate = new HashSet<ContractTemplate>();
            ContractType = new HashSet<ContractType>();
            CreditTerms = new HashSet<CreditTerms>();
            Customer = new HashSet<Customer>();
            Department = new HashSet<Department>();
            InvoiceLayout = new HashSet<InvoiceLayout>();
            Machine = new HashSet<Machine>();
            Meter = new HashSet<Meter>();
            Model = new HashSet<Model>();
            OrderDefaultArticles = new HashSet<OrderDefaultArticles>();
            OrderHeading = new HashSet<OrderHeading>();
            Project = new HashSet<Project>();
            ProjectAuto = new HashSet<ProjectAuto>();
            Salesman = new HashSet<Salesman>();
            Stock = new HashSet<Stock>();
            Supplier = new HashSet<Supplier>();
            Technician = new HashSet<Technician>();
            Warranty = new HashSet<Warranty>();
        }

        public string Company1 { get; set; }
        public string CompanyName { get; set; }
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
        public string PostalDescription { get; set; }

        public ICollection<ActionCode> ActionCode { get; set; }
        public ICollection<Area> Area { get; set; }
        public ICollection<Article> Article { get; set; }
        public ICollection<CheckList> CheckList { get; set; }
        public ICollection<CompetenceGroup> CompetenceGroup { get; set; }
        public ICollection<Contract> Contract { get; set; }
        public ICollection<ContractTemplate> ContractTemplate { get; set; }
        public ICollection<ContractType> ContractType { get; set; }
        public ICollection<CreditTerms> CreditTerms { get; set; }
        public ICollection<Customer> Customer { get; set; }
        public ICollection<Department> Department { get; set; }
        public ICollection<InvoiceLayout> InvoiceLayout { get; set; }
        public ICollection<Machine> Machine { get; set; }
        public ICollection<Meter> Meter { get; set; }
        public ICollection<Model> Model { get; set; }
        public ICollection<OrderDefaultArticles> OrderDefaultArticles { get; set; }
        public ICollection<OrderHeading> OrderHeading { get; set; }
        public ICollection<Project> Project { get; set; }
        public ICollection<ProjectAuto> ProjectAuto { get; set; }
        public ICollection<Salesman> Salesman { get; set; }
        public ICollection<Stock> Stock { get; set; }
        public ICollection<Supplier> Supplier { get; set; }
        public ICollection<Technician> Technician { get; set; }
        public ICollection<Warranty> Warranty { get; set; }
    }
}
