using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class ArticleSortGroupDefaultValues
    {
        public string Company { get; set; }
        public string AccountNo { get; set; }
        public int? CalcSchemaNo { get; set; }
        public decimal? Costgroup { get; set; }
        public string StockTracking { get; set; }
        public Guid? SupplierObjNo { get; set; }
        public decimal? VatCode { get; set; }
        public string Unit { get; set; }
        public string UnitPurchase { get; set; }
        public int? UseSerialNo { get; set; }
        public int? IsModel { get; set; }
        public string Sg1Code { get; set; }
        public string Sg2Code { get; set; }
        public string Sg3Code { get; set; }
        public string Sg4Code { get; set; }
        public string Sg5Code { get; set; }
        public Guid ObjNo { get; set; }
        public decimal? WarrantyLength { get; set; }
        public string AccountNoPurchase { get; set; }
        public decimal? DiscountCostPrice { get; set; }
        public decimal? DiscountCostPrice2 { get; set; }
    }
}
