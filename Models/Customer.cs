using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class Customer
    {
        public Customer()
        {
            ArticleDiscount = new HashSet<ArticleDiscount>();
            ContractCreditCustomer = new HashSet<ContractCreditCustomer>();
            ContractCreditCustomerObjNoNavigation = new HashSet<Contract>();
            ContractCustomerObjNoNavigation = new HashSet<Contract>();
            CustomerMachineModelMeterPrice = new HashSet<CustomerMachineModelMeterPrice>();
            CustomerMailFormat = new HashSet<CustomerMailFormat>();
            CustomerTechnician = new HashSet<CustomerTechnician>();
            Machine = new HashSet<Machine>();
            OrderHeading = new HashSet<OrderHeading>();
            Project = new HashSet<Project>();
            ProjectAuto = new HashSet<ProjectAuto>();
            ProjectAutoTask = new HashSet<ProjectAutoTask>();
            ProjectTaskAuto = new HashSet<ProjectTaskAuto>();
            ProjectTaskCustomerObjNoNavigation = new HashSet<ProjectTask>();
            ProjectTaskRespCustomerObjNoNavigation = new HashSet<ProjectTask>();
            RemoteAccess = new HashSet<RemoteAccess>();
            SaleSaleproject = new HashSet<SaleSaleproject>();
            Supplier = new HashSet<Supplier>();
            Warranty = new HashSet<Warranty>();
        }

        public Guid ObjNo { get; set; }
        public string Company { get; set; }
        public string Dept { get; set; }
        public string CustomerNo { get; set; }
        public string SearchName { get; set; }
        public string CustomerName { get; set; }
        public Guid? InvCustomerObjNo { get; set; }
        public Guid? SalesmanObjNo { get; set; }
        public string Http { get; set; }
        public string OrganizationNo { get; set; }
        public string Sortgroup1 { get; set; }
        public string Sortgroup2 { get; set; }
        public string Sortgroup3 { get; set; }
        public string Sortgroup4 { get; set; }
        public string Sortgroup5 { get; set; }
        public Guid? CreditTerm { get; set; }
        public string DeliveryTerm { get; set; }
        public string MeansOfDelivery { get; set; }
        public decimal? CreditLimit { get; set; }
        public decimal? FixedDiscount { get; set; }
        public decimal? InvoiceTax { get; set; }
        public string PriceList { get; set; }
        public string OpenForInvoice { get; set; }
        public string CalculateVat { get; set; }
        public DateTime? ObjDate { get; set; }
        public string Username { get; set; }
        public string GenerateRemainder { get; set; }
        public string CalculateInterest { get; set; }
        public decimal? Employees { get; set; }
        public string BusinessCode { get; set; }
        public decimal? Sales { get; set; }
        public string Established { get; set; }
        public string Status { get; set; }
        public string Information { get; set; }
        public string InvoiceFee { get; set; }
        public string BankId { get; set; }
        public string BankName { get; set; }
        public string AccountNo { get; set; }
        public string CustomerName2 { get; set; }
        public string CustomerName3 { get; set; }
        public string CustomerName4 { get; set; }
        public string EMail { get; set; }
        public string InformationAlwaysOn { get; set; }
        public string XmlFormatOrderLineGroup { get; set; }
        public string MakeXmlFileOfInvoice { get; set; }
        public string VatCode { get; set; }
        public string AmalgamateOrders { get; set; }
        public string CustomerType { get; set; }
        public decimal? InvCustomerAddressRowNo { get; set; }
        public string CustomerLink { get; set; }
        public Guid? MainOfficeCustomerObjNo { get; set; }
        public string WebPassword { get; set; }
        public string SupportMandatoryContact { get; set; }
        public string SupportMandatoryPhone { get; set; }
        public string SupportMandatoryEmail { get; set; }
        public string SupportMandatoryPhoneOrEmail { get; set; }
        public string SupportClockPausedTime { get; set; }
        public string HideInstallationNode { get; set; }
        public string PaymentType { get; set; }
        public string NotAllowPartlyDeliver { get; set; }
        public string ExternalSystemKey { get; set; }
        public string CustomerNotes { get; set; }

        public Company CompanyNavigation { get; set; }
        public CreditTerms CreditTermNavigation { get; set; }
        public Department Department { get; set; }
        public Salesman SalesmanObjNoNavigation { get; set; }
        public CustomerBalance CustomerBalance { get; set; }
        public ICollection<ArticleDiscount> ArticleDiscount { get; set; }
        public ICollection<ContractCreditCustomer> ContractCreditCustomer { get; set; }
        public ICollection<Contract> ContractCreditCustomerObjNoNavigation { get; set; }
        public ICollection<Contract> ContractCustomerObjNoNavigation { get; set; }
        public ICollection<CustomerMachineModelMeterPrice> CustomerMachineModelMeterPrice { get; set; }
        public ICollection<CustomerMailFormat> CustomerMailFormat { get; set; }
        public ICollection<CustomerTechnician> CustomerTechnician { get; set; }
        public ICollection<Machine> Machine { get; set; }
        public ICollection<OrderHeading> OrderHeading { get; set; }
        public ICollection<Project> Project { get; set; }
        public ICollection<ProjectAuto> ProjectAuto { get; set; }
        public ICollection<ProjectAutoTask> ProjectAutoTask { get; set; }
        public ICollection<ProjectTaskAuto> ProjectTaskAuto { get; set; }
        public ICollection<ProjectTask> ProjectTaskCustomerObjNoNavigation { get; set; }
        public ICollection<ProjectTask> ProjectTaskRespCustomerObjNoNavigation { get; set; }
        public ICollection<RemoteAccess> RemoteAccess { get; set; }
        public ICollection<SaleSaleproject> SaleSaleproject { get; set; }
        public ICollection<Supplier> Supplier { get; set; }
        public ICollection<Warranty> Warranty { get; set; }
    }
}
