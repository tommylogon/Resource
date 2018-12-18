using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class Price
    {
        public Guid SourceObjNo { get; set; }
        public DateTime ValidFrom { get; set; }
        public decimal? Price1 { get; set; }
        public string PriceType { get; set; }
        public decimal? Discount { get; set; }
        public decimal? ActivePrice { get; set; }
    }
}
