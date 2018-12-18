using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class ContractMeterDetails
    {
        public Guid ContractObjNo { get; set; }
        public decimal RowNo { get; set; }
        public Guid MeterObjNo { get; set; }
        public Guid? PvArticleObjNo { get; set; }
        public Guid? MrArticleObjNo { get; set; }
        public string Status { get; set; }
        public string UseHighestPrice { get; set; }
        public decimal? PriceNegativeCopies { get; set; }
        public decimal? MaxcopiesToCredit { get; set; }
        public decimal? Volume { get; set; }
        public decimal? MeterStart { get; set; }
        public Guid? ObjNo { get; set; }
        public decimal? Price1 { get; set; }
        public decimal? Level1 { get; set; }
        public decimal? Price2 { get; set; }
        public decimal? Level2 { get; set; }
        public decimal? Price3 { get; set; }
        public decimal? Level3 { get; set; }
        public string InvoiceExcessCopies { get; set; }
        public string InvoiceCreditCopies { get; set; }
        public string AutomaticAdjustVolume { get; set; }
        public decimal? CreditPercentage { get; set; }
        public decimal? CreditFixed { get; set; }
        public string CreditOnlyOnce { get; set; }
        public DateTime? CreditEndDate { get; set; }
        public string CreditEnabled { get; set; }
        public string VolumePerPeriod { get; set; }
        public string AllUnitsOnMaxLevel { get; set; }
        public decimal? CreditPercentageMr { get; set; }
        public decimal? CreditFixedMr { get; set; }
        public string UnitPriceCredit { get; set; }
        public string UseHiddenVolume { get; set; }
        public decimal? HiddenVolume { get; set; }
        public string UseAdvancedLevels { get; set; }
        public decimal? AdvancedLevelsDiscount { get; set; }

        public ContractPeriodVolume ContractPeriodVolume { get; set; }
        public Meter MeterObjNoNavigation { get; set; }
        public Article MrArticleObjNoNavigation { get; set; }
        public Article PvArticleObjNoNavigation { get; set; }
    }
}
