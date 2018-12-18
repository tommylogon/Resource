using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class ContractTypeArticle
    {
        public Guid ObjNo { get; set; }
        public Guid? ContractTypeObjNo { get; set; }
        public Guid? ArticleObjNo { get; set; }
        public string ArticleSortgroup { get; set; }
        public DateTime? ObjDate { get; set; }
        public string Username { get; set; }
        public string ArticleSortgroupNo { get; set; }

        public Article ArticleObjNoNavigation { get; set; }
        public ContractType ContractTypeObjNoNavigation { get; set; }
    }
}
