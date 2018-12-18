using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class FrequenceList
    {
        public Guid ModelObjNo { get; set; }
        public Guid ArticleObjNo { get; set; }
        public decimal? Quantity { get; set; }

        public Model ModelObjNoNavigation { get; set; }
    }
}
