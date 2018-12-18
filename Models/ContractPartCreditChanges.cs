using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class ContractPartCreditChanges
    {
        public Guid ObjNo { get; set; }
        public string Owner { get; set; }
        public string PreviewType { get; set; }
        public string Company { get; set; }
        public decimal OrderNo { get; set; }
        public decimal CustomerInvoicingNo { get; set; }
        public Guid ContractObjNo { get; set; }
        public decimal RowNo { get; set; }
        public string RowType { get; set; }
        public string Status { get; set; }
        public Guid? MachineObjNo { get; set; }
        public Guid? MeterObjNo { get; set; }
        public string MeterVirtual { get; set; }
        public string MeterVirtualDependency { get; set; }
        public string Terminated { get; set; }
        public DateTime? OldReadingDate { get; set; }
        public decimal? OldCounter { get; set; }
        public DateTime? NewReadingDate { get; set; }
        public decimal? NewCounter { get; set; }
        public string StatusMessage { get; set; }
        public decimal? NewOrderNo { get; set; }
        public DateTime? NewInvoiceDate { get; set; }
    }
}
