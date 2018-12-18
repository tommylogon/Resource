using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class OrderSupportMateriel
    {
        public string TypeOfOrder { get; set; }
        public decimal LevelSum { get; set; }
        public decimal? LevelPrc { get; set; }
    }
}
