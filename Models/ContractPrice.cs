using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class ContractPrice
    {
        public Guid ObjNo { get; set; }
        public string PriceCode { get; set; }
        public decimal? VolumeLimit { get; set; }
        public decimal? PriceLimit { get; set; }
    }
}
