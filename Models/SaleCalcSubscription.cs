using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class SaleCalcSubscription
    {
        public Guid ObjNo { get; set; }
        public Guid CalcObjNo { get; set; }
        public Guid? ArticleObjNo { get; set; }
        public string ArticleDescription { get; set; }
        public decimal LineNo { get; set; }
        public decimal? SalesPrice { get; set; }
        public decimal? CostPrice { get; set; }
        public string CostPriceOnlyFirst { get; set; }
        public decimal? ItemsOnRow { get; set; }
        public DateTime? StartDate { get; set; }
        public decimal? ContractPeriod { get; set; }
        public decimal? InvoiceFrequency { get; set; }
        public Guid? ContractTypeObjNo { get; set; }
        public string CreateMachine { get; set; }
        public Guid? MachineObjNo { get; set; }
        public DateTime? ObjDate { get; set; }
    }
}
