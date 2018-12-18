using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class MeterReadingEstimated
    {
        public Guid ContractObjNo { get; set; }
        public decimal RowNo { get; set; }
        public Guid MachineObjNo { get; set; }
        public Guid MeterObjNo { get; set; }
        public decimal InvoiceYear { get; set; }
        public int InvoicePeriod { get; set; }
        public DateTime ReadingDate { get; set; }
        public decimal? Counter { get; set; }
        public decimal? CounterCorrected { get; set; }
        public decimal? ReadingLap { get; set; }
        public string Status { get; set; }

        public MachineOnContract MachineOnContract { get; set; }
        public Meter MeterObjNoNavigation { get; set; }
    }
}
