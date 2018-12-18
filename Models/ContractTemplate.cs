using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class ContractTemplate
    {
        public ContractTemplate()
        {
            ContractTemplateMeterPriceLevel = new HashSet<ContractTemplateMeterPriceLevel>();
            SaleCalcHeading = new HashSet<SaleCalcHeading>();
        }

        public Guid ObjNo { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public Guid ContractTypeObjNo { get; set; }
        public string CalculateMethod { get; set; }
        public string IncludedDesc { get; set; }
        public string ExcludedDesc { get; set; }
        public decimal? MaxDiscount { get; set; }
        public decimal? ProvisionPercent { get; set; }
        public Guid? InvoiceLayoutLetterObjNo { get; set; }
        public Guid? InvoiceLayoutObjNo { get; set; }
        public decimal? InvoiceFrequency { get; set; }
        public decimal? ReadingFrequency { get; set; }
        public Guid? PvArticleObjNo { get; set; }
        public Guid? MrArticleObjNo { get; set; }
        public string InvoiceTime { get; set; }
        public decimal? ContractFactor { get; set; }
        public Guid? InvoiceLayoutFpObjNo { get; set; }
        public Guid? FpArticleObjNo { get; set; }
        public string InvoiceExcessCopies { get; set; }
        public string InvoiceCreditCopies { get; set; }
        public string AutomaticAdjustVolume { get; set; }
        public string ReadingRunningYear { get; set; }
        public string Company { get; set; }
        public int? UsePriceFromArticle { get; set; }
        public string CalculateAllRowsAsTotalVolume { get; set; }
        public string Sortgroup1 { get; set; }
        public string Sortgroup2 { get; set; }
        public string Sortgroup3 { get; set; }
        public string Sortgroup4 { get; set; }
        public string Sortgroup5 { get; set; }
        public string Sortgroup1Pv { get; set; }
        public string Sortgroup2Pv { get; set; }
        public string InvoiceWithMeterReading { get; set; }
        public string MeterReadingLetterOneLetter { get; set; }
        public string UseInvoicedToVolume { get; set; }
        public string MakeXmlFileOfInvoice { get; set; }
        public string PrintInvoiceAsOneLine { get; set; }
        public string CreditEstimated { get; set; }
        public Guid? ArticleObjNoOneRow { get; set; }

        public Company CompanyNavigation { get; set; }
        public ContractType ContractTypeObjNoNavigation { get; set; }
        public InvoiceLayout InvoiceLayoutLetterObjNoNavigation { get; set; }
        public InvoiceLayout InvoiceLayoutObjNoNavigation { get; set; }
        public Article MrArticleObjNoNavigation { get; set; }
        public Article PvArticleObjNoNavigation { get; set; }
        public ICollection<ContractTemplateMeterPriceLevel> ContractTemplateMeterPriceLevel { get; set; }
        public ICollection<SaleCalcHeading> SaleCalcHeading { get; set; }
    }
}
