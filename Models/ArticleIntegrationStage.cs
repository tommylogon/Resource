using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class ArticleIntegrationStage
    {
        public string Company { get; set; }
        public string ArticleNo { get; set; }
        public string ArticleDescription { get; set; }
        public int? SerialNoRequired { get; set; }
        public string Sortgroup1 { get; set; }
        public string Sortgroup1Desc { get; set; }
        public string Sortgroup2 { get; set; }
        public string Sortgroup2Desc { get; set; }
        public string Sortgroup3 { get; set; }
        public string Sortgroup3Desc { get; set; }
        public string Sortgroup4 { get; set; }
        public string Sortgroup4Desc { get; set; }
        public string Sortgroup5 { get; set; }
        public string Sortgroup5Desc { get; set; }
        public DateTime? ObjDate { get; set; }
    }
}
