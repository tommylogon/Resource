using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class OrderLineWorkHourListStatus
    {
        public Guid OrderLineObjNo { get; set; }
        public DateTime WorkHourListObjDate { get; set; }
        public decimal? WorkHourListQty { get; set; }
        public string WorkHourListStatus { get; set; }
        public string WorkHourListUsername { get; set; }
        public string WorkHourListComment { get; set; }
    }
}
