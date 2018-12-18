using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class Contract
    {
        public Contract()
        {
            ArticleDiscount = new HashSet<ArticleDiscount>();
            ContractFixedPrice = new HashSet<ContractFixedPrice>();
            ContractInvoiceFee = new HashSet<ContractInvoiceFee>();
            ContractPeriodVolume = new HashSet<ContractPeriodVolume>();
            ContractPrepaidUnits = new HashSet<ContractPrepaidUnits>();
        }

        public Guid ObjNo { get; set; }
        public string Company { get; set; }
        public string Dept { get; set; }
        public string ContractNo { get; set; }
        public Guid CustomerObjNo { get; set; }
        public decimal? AddressRowNo { get; set; }
        public Guid? DeliveryCustomerObjNo { get; set; }
        public decimal? DeliveryAddressRowNo { get; set; }
        public string Sortgroup1 { get; set; }
        public string Sortgroup2 { get; set; }
        public string Sortgroup3 { get; set; }
        public string Sortgroup4 { get; set; }
        public string Sortgroup5 { get; set; }
        public Guid? CreditTerm { get; set; }
        public string ContractInfo { get; set; }
        public string InvoiceInfo { get; set; }
        public string OrderType { get; set; }
        public DateTime? ObjDate { get; set; }
        public string Username { get; set; }
        public string InvoiceWithMeterReading { get; set; }
        public string InvoiceFee { get; set; }
        public string Status { get; set; }
        public string PrintInvoiceAsOneLine { get; set; }
        public string MeterReadingLetterOneLetter { get; set; }
        public Guid? ArticleObjNoOneRow { get; set; }
        public string OnHold { get; set; }
        public DateTime? OnHoldDate { get; set; }
        public Guid? CreditCustomerObjNo { get; set; }
        public string CreditEnabled { get; set; }
        public decimal? CreditPercentage { get; set; }
        public decimal? CreditFixed { get; set; }
        public string CreditOnlyOnce { get; set; }
        public DateTime? CreditEndDate { get; set; }
        public string MakeXmlFileOfInvoice { get; set; }
        public string CalculateAllRowsAsTotalVolume { get; set; }
        public string UseInvoicedToVolume { get; set; }
        public string OnHoldInfo { get; set; }
        public string CreditVirtual { get; set; }
        public Guid? CreditTermMr { get; set; }
        public string OrderTypeMr { get; set; }
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
        public string PaymentType { get; set; }
        public string PaymentTypeMr { get; set; }
        public string CreditEstimated { get; set; }
        public decimal? ConsumableOrderRemainingDays { get; set; }
        public decimal? ConsumableOrderSoonDays { get; set; }
        public decimal? ConsumableOrderMinimumLevel { get; set; }
        public string CustomerReference { get; set; }
        public string Iban { get; set; }
        public string Bic { get; set; }
        public string MandateRefNo { get; set; }
        public string IbanMr { get; set; }
        public string BicMr { get; set; }
        public string MandateRefNoMr { get; set; }

        public Company CompanyNavigation { get; set; }
        public Customer CreditCustomerObjNoNavigation { get; set; }
        public CreditTerms CreditTermNavigation { get; set; }
        public Customer CustomerObjNoNavigation { get; set; }
        public Department Department { get; set; }
        public ICollection<ArticleDiscount> ArticleDiscount { get; set; }
        public ICollection<ContractFixedPrice> ContractFixedPrice { get; set; }
        public ICollection<ContractInvoiceFee> ContractInvoiceFee { get; set; }
        public ICollection<ContractPeriodVolume> ContractPeriodVolume { get; set; }
        public ICollection<ContractPrepaidUnits> ContractPrepaidUnits { get; set; }
    }
}
