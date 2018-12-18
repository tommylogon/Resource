using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class EpwIdSettings
    {
        public string Loginid { get; set; }
        public string Projectsummarysorting { get; set; }
        public string Countrycode { get; set; }
        public string Projectsummarycolumns { get; set; }
        public int? Projectsummaryamount { get; set; }
        public int? Searchamount { get; set; }
        public string Splittersizes { get; set; }
        public string Projectsummarylayout { get; set; }
    }
}
