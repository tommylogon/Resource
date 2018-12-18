using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class MeterReadingValidation
    {
        public Guid ModelObjNo { get; set; }
        public Guid MeterObjNo { get; set; }
        public decimal? Upm { get; set; }
        public decimal? Mubv { get; set; }
    }
}
