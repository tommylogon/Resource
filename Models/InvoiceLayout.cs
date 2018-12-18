using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class InvoiceLayout
    {
        public InvoiceLayout()
        {
            ContractFixedPrice = new HashSet<ContractFixedPrice>();
            ContractPeriodVolumeInvoiceLayoutLetterObjNoNavigation = new HashSet<ContractPeriodVolume>();
            ContractPeriodVolumeInvoiceLayoutObjNoNavigation = new HashSet<ContractPeriodVolume>();
            ContractTemplateInvoiceLayoutLetterObjNoNavigation = new HashSet<ContractTemplate>();
            ContractTemplateInvoiceLayoutObjNoNavigation = new HashSet<ContractTemplate>();
        }

        public Guid ObjNo { get; set; }
        public string Company { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal? ContractNoCheck { get; set; }
        public string ContractNo { get; set; }
        public decimal? DateRangeCheck { get; set; }
        public string DateRange { get; set; }
        public decimal? FrequencyCheck { get; set; }
        public string Frequency { get; set; }
        public decimal? FixedPriceCheck { get; set; }
        public string FixedPrice { get; set; }
        public decimal? MachineNoCheck { get; set; }
        public string MachineNo { get; set; }
        public decimal? ModelCheck { get; set; }
        public string Model { get; set; }
        public decimal? LocationCheck { get; set; }
        public string Location { get; set; }
        public decimal? MeterReadingCheck { get; set; }
        public string MeterReading { get; set; }
        public decimal? PricePrCopyCheck { get; set; }
        public string PricePrCopy { get; set; }
        public decimal? NoOfCopiesCheck { get; set; }
        public string NoOfCopies { get; set; }
        public decimal? PrevMetReadDateCheck { get; set; }
        public string PrevMetReadDate { get; set; }
        public decimal? PrevMetReadCountCheck { get; set; }
        public string PrevMetReadCount { get; set; }
        public decimal? PrevServMetDateCheck { get; set; }
        public string PrevServMetDate { get; set; }
        public decimal? PrevServMetCountCheck { get; set; }
        public string PrevServMetCount { get; set; }
        public string MeterReadingDate { get; set; }
        public decimal? MeterReadingDateCheck { get; set; }
        public string UsedCopies { get; set; }
        public decimal? UsedCopiesCheck { get; set; }
        public string CopiesIncluded { get; set; }
        public decimal? CopiesIncludedCheck { get; set; }
        public string ExcessCopies { get; set; }
        public decimal? ExcessCopiesCheck { get; set; }
        public string InvoicedFromTo { get; set; }
        public decimal? InvoicedFromToCheck { get; set; }
        public string ContractRowTerminated { get; set; }
        public decimal? ContractRowTerminatedCheck { get; set; }
        public string MeterName { get; set; }
        public decimal? MeterNameCheck { get; set; }
        public string Estimated { get; set; }
        public decimal? EstimatedCheck { get; set; }
        public string MachineVolume { get; set; }
        public decimal? MachineVolumeCheck { get; set; }
        public string MachineFixed { get; set; }
        public decimal? MachineFixedCheck { get; set; }
        public string MachineTotal { get; set; }
        public decimal? MachineTotalCheck { get; set; }
        public string InvoiceTotal { get; set; }
        public decimal? InvoiceTotalCheck { get; set; }
        public string InvoiceOverviewRowBefore { get; set; }
        public decimal? InvoiceOverviewRowBeforeCheck { get; set; }
        public string InvoiceOverviewHeading { get; set; }
        public decimal? InvoiceOverviewHeadingCheck { get; set; }
        public string MachineRowBefore { get; set; }
        public decimal? MachineRowBeforeCheck { get; set; }
        public string InvoiceTotalRowBefore { get; set; }
        public decimal? InvoiceTotalRowBeforeCheck { get; set; }
        public string MachineAddress { get; set; }
        public decimal? MachineAddressCheck { get; set; }
        public decimal? MeterInfoOnOverviewCheck { get; set; }
        public string InvoicedFromToTotal { get; set; }
        public decimal? InvoicedFromToTotalCheck { get; set; }
        public string NoOfCopiesTotal { get; set; }
        public decimal? NoOfCopiesTotalCheck { get; set; }
        public string DateRangeMeterReadingLetter { get; set; }
        public decimal? DateRangeMeterReadingLetterCheck { get; set; }
        public decimal? DateRangeOnTopCheck { get; set; }
        public decimal? DateRangeMrlOnTopCheck { get; set; }
        public decimal? SubContractNoCheck { get; set; }
        public string SubContractNo { get; set; }
        public decimal? CopiesIncludedTotalCheck { get; set; }
        public string CopiesIncludedTotal { get; set; }
        public decimal? MachineIdNoCheck { get; set; }
        public string MachineIdNo { get; set; }
        public decimal? NoOfHiddenCopiesCheck { get; set; }
        public string NoOfHiddenCopies { get; set; }
        public decimal? DateRangeOverviewCheck { get; set; }
        public string DateRangeOverview { get; set; }
        public decimal? MachineAddressCheckAlways { get; set; }
        public string MachineAddressNotOverview { get; set; }
        public decimal? MachineAddressNotOverviewCheck { get; set; }
        public decimal? MachineAddressNotOverviewCheckAlways { get; set; }
        public decimal? MinimumPriceCheck { get; set; }
        public string MinimumPrice { get; set; }
        public decimal? MinimumPriceBrackets { get; set; }

        public Company CompanyNavigation { get; set; }
        public ICollection<ContractFixedPrice> ContractFixedPrice { get; set; }
        public ICollection<ContractPeriodVolume> ContractPeriodVolumeInvoiceLayoutLetterObjNoNavigation { get; set; }
        public ICollection<ContractPeriodVolume> ContractPeriodVolumeInvoiceLayoutObjNoNavigation { get; set; }
        public ICollection<ContractTemplate> ContractTemplateInvoiceLayoutLetterObjNoNavigation { get; set; }
        public ICollection<ContractTemplate> ContractTemplateInvoiceLayoutObjNoNavigation { get; set; }
    }
}
