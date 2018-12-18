using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class Meter
    {
        public Meter()
        {
            ContractMeterDetails = new HashSet<ContractMeterDetails>();
            ContractTemplateMeterPriceLevel = new HashSet<ContractTemplateMeterPriceLevel>();
            CustomerMachineModelMeterPrice = new HashSet<CustomerMachineModelMeterPrice>();
            MeterOnContract = new HashSet<MeterOnContract>();
            MeterReading = new HashSet<MeterReading>();
            MeterReadingEstimated = new HashSet<MeterReadingEstimated>();
            MeterReadingOldValues = new HashSet<MeterReadingOldValues>();
            ModelMeter = new HashSet<ModelMeter>();
            ModelMeterPrice = new HashSet<ModelMeterPrice>();
            SaleCalcIntervalMeter = new HashSet<SaleCalcIntervalMeter>();
        }

        public Guid ObjNo { get; set; }
        public string Company { get; set; }
        public string MeterType { get; set; }
        public string Description { get; set; }
        public string MeterVirtual { get; set; }

        public Company CompanyNavigation { get; set; }
        public ICollection<ContractMeterDetails> ContractMeterDetails { get; set; }
        public ICollection<ContractTemplateMeterPriceLevel> ContractTemplateMeterPriceLevel { get; set; }
        public ICollection<CustomerMachineModelMeterPrice> CustomerMachineModelMeterPrice { get; set; }
        public ICollection<MeterOnContract> MeterOnContract { get; set; }
        public ICollection<MeterReading> MeterReading { get; set; }
        public ICollection<MeterReadingEstimated> MeterReadingEstimated { get; set; }
        public ICollection<MeterReadingOldValues> MeterReadingOldValues { get; set; }
        public ICollection<ModelMeter> ModelMeter { get; set; }
        public ICollection<ModelMeterPrice> ModelMeterPrice { get; set; }
        public ICollection<SaleCalcIntervalMeter> SaleCalcIntervalMeter { get; set; }
    }
}
