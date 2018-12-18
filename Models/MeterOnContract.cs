using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class MeterOnContract
    {
        public Guid ContractObjNo { get; set; }
        public decimal RowNo { get; set; }
        public Guid MachineObjNo { get; set; }
        public Guid MeterObjNo { get; set; }
        public DateTime StartDate { get; set; }
        public decimal Counter { get; set; }
        public decimal? VolumeOfTotal { get; set; }
        public DateTime? TerminateDate { get; set; }
        public decimal? TerminateCounter { get; set; }
        public string UseNextPeriod { get; set; }
        public decimal? ReadingCounterLap { get; set; }
        public decimal? ReadingTerminateLap { get; set; }
        public decimal? MeterVolume { get; set; }
        public decimal? MaxCounter { get; set; }
        public string MeterLetterReported { get; set; }
        public string CreditEstimatedTerminatedLastInvoiced { get; set; }

        public MachineOnContract MachineOnContract { get; set; }
        public Meter MeterObjNoNavigation { get; set; }
    }
}
