using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class SupplierOrderHeading
    {
        public SupplierOrderHeading()
        {
            SupplierOrderLine = new HashSet<SupplierOrderLine>();
        }

        public string Company { get; set; }
        public string InvoiceNo { get; set; }
        public Guid SupplierObjNo { get; set; }
        public DateTime InvoiceDate { get; set; }
        public Guid? CreditTerm { get; set; }
        public Guid OrderObjNo { get; set; }
        public string Status { get; set; }

        public ICollection<SupplierOrderLine> SupplierOrderLine { get; set; }
    }
}
