using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class Article
    {
        public Article()
        {
            Accessories = new HashSet<Accessories>();
            ArticleDiscount = new HashSet<ArticleDiscount>();
            ArticleGenerations = new HashSet<ArticleGenerations>();
            ArticleModelLocation = new HashSet<ArticleModelLocation>();
            ContractFixedPrice = new HashSet<ContractFixedPrice>();
            ContractMeterDetailsMrArticleObjNoNavigation = new HashSet<ContractMeterDetails>();
            ContractMeterDetailsPvArticleObjNoNavigation = new HashSet<ContractMeterDetails>();
            ContractTemplateMrArticleObjNoNavigation = new HashSet<ContractTemplate>();
            ContractTemplatePvArticleObjNoNavigation = new HashSet<ContractTemplate>();
            ContractTypeArticle = new HashSet<ContractTypeArticle>();
            Model = new HashSet<Model>();
            OrderDefaultArticles = new HashSet<OrderDefaultArticles>();
            OrderLine = new HashSet<OrderLine>();
            ServicesArticles = new HashSet<ServicesArticles>();
            StockAdminArticle = new HashSet<StockAdminArticle>();
            Warranty = new HashSet<Warranty>();
        }

        public Guid ObjNo { get; set; }
        public string Company { get; set; }
        public string ArticleNo { get; set; }
        public string ArticleSearchname { get; set; }
        public string ArticleDescription { get; set; }
        public string Unit { get; set; }
        public decimal? VatCode { get; set; }
        public string ArticleStatus { get; set; }
        public string Sortgroup1 { get; set; }
        public string Sortgroup2 { get; set; }
        public string Sortgroup3 { get; set; }
        public string Sortgroup4 { get; set; }
        public string Sortgroup5 { get; set; }
        public Guid? SupplierObjNo { get; set; }
        public string ArticleNoSupplier { get; set; }
        public string AccountNo { get; set; }
        public decimal? CostPrice { get; set; }
        public decimal? SalesPrice1 { get; set; }
        public decimal? SalesPrice2 { get; set; }
        public decimal? SalesPrice3 { get; set; }
        public decimal? SalesPrice4 { get; set; }
        public decimal? SalesPrice5 { get; set; }
        public decimal? ProcentOfCost1 { get; set; }
        public decimal? ProcentOfCost2 { get; set; }
        public decimal? ProcentOfCost3 { get; set; }
        public decimal? ProcentOfCost4 { get; set; }
        public decimal? ProcentOfCost5 { get; set; }
        public DateTime? LastChangePrice1 { get; set; }
        public DateTime? LastChangePrice2 { get; set; }
        public DateTime? LastChangePrice3 { get; set; }
        public DateTime? LastChangePrice4 { get; set; }
        public DateTime? LastChangePrice5 { get; set; }
        public string AdjustSalesprices { get; set; }
        public string CampainNo { get; set; }
        public string ArticleNoForward { get; set; }
        public string ArticleDescrForward { get; set; }
        public DateTime? DateForwarded { get; set; }
        public DateTime? ObjDate { get; set; }
        public string Username { get; set; }
        public string StockTracking { get; set; }
        public decimal? CostGroup { get; set; }
        public bool? InSalemanual { get; set; }
        public bool? CodeInSalemanual { get; set; }
        public bool? OldContractDistribute { get; set; }
        public decimal? MaxDiscountPercent { get; set; }
        public decimal? ProvisionPercent { get; set; }
        public string TargetPriceCode { get; set; }
        public string ArticleInfo { get; set; }
        public DateTime? LastChangeCostPrice { get; set; }
        public string EanNo { get; set; }
        public decimal? DiscountCostPrice { get; set; }
        public decimal? DiscountCostPrice2 { get; set; }
        public int? SerialNo { get; set; }
        public string UnitPurchase { get; set; }
        public int? UnitPurchaseAmount { get; set; }
        public int? UnitAmount { get; set; }
        public int? UseCalcSchema { get; set; }
        public int? CalcSchemaNo { get; set; }
        public DateTime? CampaignFrom { get; set; }
        public DateTime? CampaignTo { get; set; }
        public decimal? CampaignPrice { get; set; }
        public decimal? CostListPrice { get; set; }
        public string AccountNoPurchase { get; set; }
        public decimal? WarrantyLength { get; set; }
        public string UseInMobile { get; set; }
        public int? NotUseTargetPrice { get; set; }
        public decimal? NumOfDecimals { get; set; }
        public bool? CalcAutoadjustFromSummary { get; set; }
        public bool? CalcChangeSalesprice { get; set; }
        public decimal? FeeLevel { get; set; }
        public string FeeCalculate { get; set; }
        public string AggregatedArticle { get; set; }
        public string ArticleInfoInternal { get; set; }
        public decimal? Weight { get; set; }
        public string WeightUnit { get; set; }
        public string StockAdminStopOrder { get; set; }
        public DateTime? StockAdminStopOrderDate { get; set; }
        public decimal? MeanCostPrice { get; set; }
        public string ExternalId { get; set; }
        public string ExternalSystemOn { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string AccountNoStock { get; set; }
        public string EcoTaxCalculate { get; set; }
        public string EcoTaxCode { get; set; }

        public Company CompanyNavigation { get; set; }
        public Supplier SupplierObjNoNavigation { get; set; }
        public ContractCreditArticle ContractCreditArticle { get; set; }
        public ICollection<Accessories> Accessories { get; set; }
        public ICollection<ArticleDiscount> ArticleDiscount { get; set; }
        public ICollection<ArticleGenerations> ArticleGenerations { get; set; }
        public ICollection<ArticleModelLocation> ArticleModelLocation { get; set; }
        public ICollection<ContractFixedPrice> ContractFixedPrice { get; set; }
        public ICollection<ContractMeterDetails> ContractMeterDetailsMrArticleObjNoNavigation { get; set; }
        public ICollection<ContractMeterDetails> ContractMeterDetailsPvArticleObjNoNavigation { get; set; }
        public ICollection<ContractTemplate> ContractTemplateMrArticleObjNoNavigation { get; set; }
        public ICollection<ContractTemplate> ContractTemplatePvArticleObjNoNavigation { get; set; }
        public ICollection<ContractTypeArticle> ContractTypeArticle { get; set; }
        public ICollection<Model> Model { get; set; }
        public ICollection<OrderDefaultArticles> OrderDefaultArticles { get; set; }
        public ICollection<OrderLine> OrderLine { get; set; }
        public ICollection<ServicesArticles> ServicesArticles { get; set; }
        public ICollection<StockAdminArticle> StockAdminArticle { get; set; }
        public ICollection<Warranty> Warranty { get; set; }
    }
}
