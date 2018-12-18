using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class CustomerInvoicingMeterDetails
    {
        public decimal LineNo { get; set; }
        public decimal CiNo { get; set; }
        public string Company { get; set; }
        public decimal OrderNo { get; set; }
        public Guid? MachineObjNo { get; set; }
        public Guid? MeterObjNo { get; set; }
        public DateTime? ReadingDateFrom { get; set; }
        public decimal? FromCounter { get; set; }
        public DateTime? ReadingDateTo { get; set; }
        public decimal? ToCounter { get; set; }
        public string EstimatedFrom { get; set; }
        public string EstimatedTo { get; set; }

        public CustomerInvoicing CustomerInvoicing { get; set; }
    }
}
