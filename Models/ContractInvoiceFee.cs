using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class ContractInvoiceFee
    {
        public Guid ContractObjNo { get; set; }
        public decimal FeeRowNo { get; set; }
        public Guid ArticleObjNo { get; set; }
        public decimal? Price { get; set; }
        public string OnlyNextInvoice { get; set; }
        public string Leasing { get; set; }
        public string Active { get; set; }
        public decimal? Qty { get; set; }

        public Contract ContractObjNoNavigation { get; set; }
    }
}
