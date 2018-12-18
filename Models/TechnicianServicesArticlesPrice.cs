using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class TechnicianServicesArticlesPrice
    {
        public string Company { get; set; }
        public string Dept { get; set; }
        public string ArticleType { get; set; }
        public string ArticleTypedef { get; set; }
        public Guid TechnicianObjNo { get; set; }
        public decimal? CostPrice { get; set; }
        public decimal? SalesPrice { get; set; }

        public Technician TechnicianObjNoNavigation { get; set; }
    }
}
