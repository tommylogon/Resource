using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class LinkArticleMapping
    {
        public Guid ObjNo { get; set; }
        public Guid CustomerObjNo { get; set; }
        public string Company { get; set; }
        public string ArticleNoLocal { get; set; }
        public string ArticleNoExternal { get; set; }
        public string StepType { get; set; }
    }
}
