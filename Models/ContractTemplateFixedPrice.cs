using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class ContractTemplateFixedPrice
    {
        public Guid ContractTemplateObjNo { get; set; }
        public int? RowNo { get; set; }
        public Guid ArticleObjNo { get; set; }
        public string UsePriceFromArticle { get; set; }
        public decimal? Price { get; set; }
        public string Sortgroup1 { get; set; }
        public string Sortgroup2 { get; set; }
        public string InvoiceTime { get; set; }
        public int? InvoiceFrequency { get; set; }
        public Guid? InvoiceLayoutObjNo { get; set; }
    }
}
