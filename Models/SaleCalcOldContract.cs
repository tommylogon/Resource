using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class SaleCalcOldContract
    {
        public Guid ObjNo { get; set; }
        public Guid CalcObjNo { get; set; }
        public string ContractType { get; set; }
        public decimal? ContractPeriod { get; set; }
        public decimal? ContractTotal { get; set; }
        public string ContractDesc { get; set; }
        public decimal? ContractCost { get; set; }
        public decimal? Ppu { get; set; }
        public decimal? Volume { get; set; }
        public string ContractNo { get; set; }
        public DateTime? DateEnd { get; set; }
        public decimal? ProvisionFactor { get; set; }

        public SaleCalcHeading CalcObjNoNavigation { get; set; }
    }
}
