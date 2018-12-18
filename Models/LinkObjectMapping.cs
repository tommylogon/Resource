using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class LinkObjectMapping
    {
        public Guid ObjNo { get; set; }
        public string Company { get; set; }
        public string ObjectLocal { get; set; }
        public string ObjectExternal { get; set; }
        public string StepType { get; set; }
        public string MapType { get; set; }
        public string ArticleNoLocal { get; set; }
        public string ArticleNoExternal { get; set; }
        public Guid? CustomerObjNo { get; set; }
    }
}
