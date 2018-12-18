using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class MeterReadingImport
    {
        public string Company { get; set; }
        public DateTime ObjDate { get; set; }
        public Guid BatchObjNo { get; set; }
        public decimal LineNo { get; set; }
        public string Owner { get; set; }
        public string ContractNo { get; set; }
        public string CustomerNo { get; set; }
        public string CustomerName { get; set; }
        public string MachineNo { get; set; }
        public string ModelType { get; set; }
        public string MeterType { get; set; }
        public DateTime? ReportDate { get; set; }
        public decimal? NewReading { get; set; }
        public string Estimated { get; set; }
        public DateTime? StatusObjDate { get; set; }
        public int? StatusImported { get; set; }
        public string StatusComment { get; set; }
        public Guid? StatusMachineObjNo { get; set; }
        public Guid? StatusMeterObjNo { get; set; }
        public Guid? StatusContractObjNo { get; set; }
        public decimal? StatusContractRowNo { get; set; }
        public int? RowHidden { get; set; }
    }
}
