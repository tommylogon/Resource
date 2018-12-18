using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class SaleCalcMeterData
    {
        public Guid CalcObjNo { get; set; }
        public decimal ContractRowNo { get; set; }
        public Guid MeterObjNo { get; set; }
        public decimal? PricePrUnit { get; set; }
        public decimal? Volume { get; set; }
        public decimal? ServicePrice { get; set; }
        public decimal? Discount { get; set; }
        public decimal? Provision { get; set; }
        public decimal? Ppeu { get; set; }
        public decimal? DiscountProvFactor { get; set; }
        public Guid? TemplateObjNo { get; set; }
        public decimal? LineNo { get; set; }
        public decimal? ContractProvisionPercent { get; set; }
        public decimal? PpeuDiscount { get; set; }
        public Guid LineObjNo { get; set; }
    }
}
