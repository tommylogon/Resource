using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class ContractTemplateMeterPriceLevel
    {
        public int IdNum { get; set; }
        public Guid ContractTemplateObjNo { get; set; }
        public Guid MeterObjNo { get; set; }
        public decimal LevelNum { get; set; }
        public decimal LevelFromValue { get; set; }
        public decimal Price { get; set; }
        public decimal? Discount { get; set; }

        public ContractTemplate ContractTemplateObjNoNavigation { get; set; }
        public Meter MeterObjNoNavigation { get; set; }
    }
}
