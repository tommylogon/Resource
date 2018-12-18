using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class ModelMeterPrice
    {
        public Guid ModelObjNo { get; set; }
        public Guid MeterObjNo { get; set; }
        public DateTime ValidFrom { get; set; }
        public decimal Price { get; set; }
        public string PriceType { get; set; }
        public Guid CustomerObjNo { get; set; }

        public Meter MeterObjNoNavigation { get; set; }
        public Model ModelObjNoNavigation { get; set; }
    }
}
