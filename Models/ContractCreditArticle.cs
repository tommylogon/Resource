using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class ContractCreditArticle
    {
        public Guid ArticleObjNoInvoice { get; set; }
        public Guid? ArticleObjNoCredit { get; set; }

        public Article ArticleObjNoInvoiceNavigation { get; set; }
    }
}
