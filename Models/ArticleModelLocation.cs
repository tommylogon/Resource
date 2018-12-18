using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class ArticleModelLocation
    {
        public Guid ObjNo { get; set; }
        public Guid ArticleObjNo { get; set; }
        public Guid ModelObjNo { get; set; }
        public string Location { get; set; }

        public Article ArticleObjNoNavigation { get; set; }
        public Model ModelObjNoNavigation { get; set; }
    }
}
