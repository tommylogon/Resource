using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class ContractPeriodVolume
    {
        public ContractPeriodVolume()
        {
            ContractMeterDetails = new HashSet<ContractMeterDetails>();
            MachineOnContract = new HashSet<MachineOnContract>();
        }

        public Guid ContractObjNo { get; set; }
        public decimal RowNo { get; set; }
        public Guid CustomerObjNo { get; set; }
        public decimal? AddressRowNo { get; set; }
        public string CalculateMethod { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime NextInvoiceFrom { get; set; }
        public DateTime? NextInvoiceTo { get; set; }
        public DateTime? TerminatedDate { get; set; }
        public DateTime? PriceIncreaseAfter { get; set; }
        public Guid? InvoiceLayoutLetterObjNo { get; set; }
        public Guid? InvoiceLayoutObjNo { get; set; }
        public decimal? ContractPeriod { get; set; }
        public decimal? ExtensionPeriod { get; set; }
        public decimal InvoiceFrequency { get; set; }
        public string InvoiceTime { get; set; }
        public string AllowCredit { get; set; }
        public string RowInfo { get; set; }
        public string InvoiceInfo { get; set; }
        public string NextInvoiceInfo { get; set; }
        public string ShowOnNextInvoice { get; set; }
        public Guid? SalesmanObjNo { get; set; }
        public string Sortgroup1 { get; set; }
        public string Sortgroup2 { get; set; }
        public Guid? MeterInvCustObjNo { get; set; }
        public decimal? MeterInvAddressRowNo { get; set; }
        public Guid? MeterCustObjNo { get; set; }
        public decimal? MeterAddressRowNo { get; set; }
        public string MeterSendLetterBy { get; set; }
        public string MeterSendLetterByValue { get; set; }
        public DateTime? MeterNextLetterDate { get; set; }
        public decimal? ReadingFrequence { get; set; }
        public DateTime? ObjDate { get; set; }
        public string Username { get; set; }
        public string Status { get; set; }
        public string MeterCheckInvoice { get; set; }
        public string MeterContact { get; set; }
        public string ReadingRunningYear { get; set; }
        public string FirstInvoiceOnStartCounter { get; set; }
        public string UseLastCounter { get; set; }
        public decimal? ReadingFrequenceOtherFirst { get; set; }
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
        public string MrSubContractNo { get; set; }
        public string Iban { get; set; }
        public string Bic { get; set; }
        public string MandateRefNo { get; set; }
        public Guid? CreditTerm { get; set; }
        public string IbanMr { get; set; }
        public string BicMr { get; set; }
        public string MandateRefNoMr { get; set; }
        public Guid? CreditTermMr { get; set; }
        public string OnHold { get; set; }
        public DateTime? OnHoldDate { get; set; }
        public string OnHoldInfo { get; set; }
        public decimal? MinimumPrice { get; set; }

        public Contract ContractObjNoNavigation { get; set; }
        public InvoiceLayout InvoiceLayoutLetterObjNoNavigation { get; set; }
        public InvoiceLayout InvoiceLayoutObjNoNavigation { get; set; }
        public ICollection<ContractMeterDetails> ContractMeterDetails { get; set; }
        public ICollection<MachineOnContract> MachineOnContract { get; set; }
    }
}
