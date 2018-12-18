using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class MachineOnContract
    {
        public MachineOnContract()
        {
            MeterOnContract = new HashSet<MeterOnContract>();
            MeterReadingEstimated = new HashSet<MeterReadingEstimated>();
        }

        public Guid ContractObjNo { get; set; }
        public decimal RowNo { get; set; }
        public Guid MachineObjNo { get; set; }
        public Guid ContractTypeObjNo { get; set; }
        public DateTime? ContractActiveFrom { get; set; }
        public DateTime? ContractActiveUntil { get; set; }
        public DateTime? MeterDateGenerated { get; set; }
        public DateTime? MeterDateReminded { get; set; }
        public string MeterIdentification { get; set; }
        public decimal? CustomerWarrantyMonths { get; set; }
        public DateTime? CustomerWarrantyDateFrom { get; set; }
        public DateTime? CustomerWarrantyDateTo { get; set; }
        public Guid? MeterCustObjNo { get; set; }
        public decimal? MeterAddressRowNo { get; set; }
        public string MeterSendLetterBy { get; set; }
        public string MeterSendLetterByValue { get; set; }
        public string MeterContact { get; set; }
        public Guid? InvoiceTextAddressCustomerObjNo { get; set; }
        public decimal? InvoiceTextAddressRowNo { get; set; }
        public string InvoiceTextLocation { get; set; }
        public int? CreditEstimatedLastYearInvoiced { get; set; }
        public int? CreditEstimatedLastPeriodInvoiced { get; set; }
        public string CreditEstimated { get; set; }
        public decimal? CreditEstimatedFixed { get; set; }
        public string ConsumableOrder { get; set; }
        public decimal? ConsumableOrderRemainingDays { get; set; }
        public decimal? ConsumableOrderSoonDays { get; set; }
        public decimal? ConsumableOrderMinimumLevel { get; set; }
        public string ConsumableOrderSplitOnLocation { get; set; }

        public ContractPeriodVolume ContractPeriodVolume { get; set; }
        public ContractType ContractTypeObjNoNavigation { get; set; }
        public Machine MachineObjNoNavigation { get; set; }
        public ICollection<MeterOnContract> MeterOnContract { get; set; }
        public ICollection<MeterReadingEstimated> MeterReadingEstimated { get; set; }
    }
}
