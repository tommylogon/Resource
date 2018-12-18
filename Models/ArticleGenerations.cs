using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class ArticleGenerations
    {
        public Guid SourceObjNo { get; set; }
        public string ArticleNo { get; set; }
        public DateTime? RegDate { get; set; }
        public string Description { get; set; }

        public Article SourceObjNoNavigation { get; set; }
    }
}
