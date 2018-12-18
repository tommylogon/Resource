using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class SaleOrderLine
    {
        public SaleOrderLine()
        {
            SaleOrderLineMachine = new HashSet<SaleOrderLineMachine>();
        }

        public Guid CalcObjNo { get; set; }
        public decimal LineNo { get; set; }
        public Guid? ArticleObjNo { get; set; }
        public string Description { get; set; }
        public string Unit { get; set; }
        public decimal? CostPrice { get; set; }
        public decimal? SalesPrice { get; set; }
        public decimal? Discount { get; set; }
        public decimal? QtyDelivered { get; set; }
        public decimal? QtyNotDelivered { get; set; }
        public decimal? VatCode { get; set; }
        public Guid? MachineObjNo { get; set; }
        public Guid? StockObjNo { get; set; }
        public Guid? SalesmanObjNo { get; set; }
        public string Sortgroup1 { get; set; }
        public string Sortgroup2 { get; set; }
        public DateTime? LastUpdated { get; set; }
        public decimal? TargetPrice { get; set; }
        public string Distribute { get; set; }
        public decimal? LinkedLineNo { get; set; }
        public Guid? ModelObjNo { get; set; }
        public decimal? ProvisionPercent { get; set; }
        public decimal? MaxDiscount { get; set; }
        public decimal? Provision { get; set; }
        public decimal? ProvisionFactor { get; set; }
        public decimal? ContractRowNo { get; set; }
        public string MachineLocation { get; set; }
        public decimal? MachineAddrRow { get; set; }
        public Guid? ObjNo { get; set; }
        public decimal? DiscountCostPrice { get; set; }
        public decimal? DiscountCostPrice2 { get; set; }
        public string ArticleSerialNo { get; set; }
        public decimal? ManualFpPrice { get; set; }
        public Guid? ManualFpTemplateObjNo { get; set; }
        public DateTime? ManualFpStartDate { get; set; }
        public decimal? AutoFpPrice { get; set; }
        public decimal? ManualFpPeriod { get; set; }
        public Guid? AutoFpTemplateObjNo { get; set; }
        public bool? CalcAutoadjustFromSummary { get; set; }
        public bool? CalcChangeSalesprice { get; set; }
        public decimal? FeeLevel { get; set; }
        public string FeeCalculate { get; set; }
        public decimal? FeePrice { get; set; }
        public string AggregateArticleType { get; set; }
        public Guid? SupplierObjNo { get; set; }
        public string Info01 { get; set; }
        public string Info02 { get; set; }
        public string Info03 { get; set; }
        public string Info04 { get; set; }
        public string DirectSale { get; set; }
        public string LineType { get; set; }
        public string HideArticleNo { get; set; }
        public string OptionalLine { get; set; }
        public string TextBefore { get; set; }
        public Guid? OrderLineObjNo { get; set; }

        public SaleCalcHeading CalcObjNoNavigation { get; set; }
        public ICollection<SaleOrderLineMachine> SaleOrderLineMachine { get; set; }
    }
}
