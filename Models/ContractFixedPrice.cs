using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class ContractFixedPrice
    {
        public Guid ContractObjNo { get; set; }
        public decimal RowNo { get; set; }
        public Guid CustomerObjNo { get; set; }
        public decimal? AddressRowNo { get; set; }
        public Guid ArticleObjNo { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? InvoiceStartDate { get; set; }
        public DateTime? InvoicedToDate { get; set; }
        public DateTime? TerminatedDate { get; set; }
        public DateTime? PriceIncreaseAfter { get; set; }
        public Guid InvoiceLayoutObjNo { get; set; }
        public decimal? ContractPeriod { get; set; }
        public decimal? ExtensionPeriod { get; set; }
        public decimal? InvoiceFrequency { get; set; }
        public DateTime? ContractActiveFrom { get; set; }
        public DateTime? ContractActiveUntil { get; set; }
        public decimal? PricePrMonth { get; set; }
        public string Status { get; set; }
        public string InvoiceTime { get; set; }
        public Guid? MachineObjNo { get; set; }
        public Guid? ContractTypeObjNo { get; set; }
        public string AllowCredit { get; set; }
        public string Sortgroup1 { get; set; }
        public string Sortgroup2 { get; set; }
        public Guid? SalesmanObjNo { get; set; }
        public string RowInfo { get; set; }
        public string OneTimeInvoice { get; set; }
        public string InvoiceInfo { get; set; }
        public string NextInvoiceInfo { get; set; }
        public string ShowOnNext { get; set; }
        public DateTime? ObjDate { get; set; }
        public string Username { get; set; }
        public Guid? ObjNo { get; set; }
        public string MachineIncome { get; set; }
        public string Leasing { get; set; }
        public string LeasingDept { get; set; }
        public decimal? LeasingInvestedAmount { get; set; }
        public Guid? LeasingOwner { get; set; }
        public string LeasingOwnerContractNo { get; set; }
        public decimal? CustomerWarrantyMonths { get; set; }
        public DateTime? CustomerWarrantyDateFrom { get; set; }
        public DateTime? CustomerWarrantyDateTo { get; set; }
        public decimal? LeasingInvestedCostMachine { get; set; }
        public decimal? LeasingInvestedCostAccessories { get; set; }
        public decimal? LeasingFactor { get; set; }
        public decimal? LeasingRefiInvestedAmount { get; set; }
        public decimal? LeasingRefiContractPeriod { get; set; }
        public decimal? LeasingRefiFactor { get; set; }
        public string Invoiceable { get; set; }
        public decimal? CreditPercentage { get; set; }
        public decimal? CreditFixed { get; set; }
        public string CreditOnlyOnce { get; set; }
        public DateTime? CreditEndDate { get; set; }
        public string CreditEnabled { get; set; }
        public decimal? ItemsOnRow { get; set; }
        public int? UsePriceFromArticle { get; set; }
        public decimal? CostPrice { get; set; }
        public string CostPriceOnlyFirst { get; set; }
        public string Invoiced { get; set; }
        public decimal? SortingNo { get; set; }
        public string SubContractNo { get; set; }
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
        public decimal? PreTerminationLimit { get; set; }
        public DateTime? ContractEndDate { get; set; }
        public string Iban { get; set; }
        public string Bic { get; set; }
        public string MandateRefNo { get; set; }
        public Guid? CreditTerm { get; set; }
        public string OnHold { get; set; }
        public DateTime? OnHoldDate { get; set; }
        public string OnHoldInfo { get; set; }

        public Article ArticleObjNoNavigation { get; set; }
        public Contract ContractObjNoNavigation { get; set; }
        public ContractType ContractTypeObjNoNavigation { get; set; }
        public InvoiceLayout InvoiceLayoutObjNoNavigation { get; set; }
        public Salesman SalesmanObjNoNavigation { get; set; }
    }
}
