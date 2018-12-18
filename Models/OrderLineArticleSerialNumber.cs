using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class OrderLineArticleSerialNumber
    {
        public Guid OrderLineObjNo { get; set; }
        public string SerialNo { get; set; }
        public decimal? QtyActDelivered { get; set; }
        public decimal? PackingSlipNo { get; set; }
        public string MachineCreatedOrChanged { get; set; }
        public Guid? PackingSlipMachineObjNo { get; set; }
        public string InvoiceDept { get; set; }
        public decimal? InvoiceNo { get; set; }
    }
}
