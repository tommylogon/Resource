using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class ArticleFeeLevel
    {
        public string Company { get; set; }
        public string Code { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public decimal FeeLevel { get; set; }
    }
}
