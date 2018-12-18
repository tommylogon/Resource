using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class PriceLevel
    {
        public int IdNum { get; set; }
        public Guid SourceObjNo { get; set; }
        public decimal LevelNum { get; set; }
        public decimal LevelFromValue { get; set; }
        public DateTime ValidFrom { get; set; }
        public decimal Price { get; set; }
        public decimal? Discount { get; set; }
    }
}
