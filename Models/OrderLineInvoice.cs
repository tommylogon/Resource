using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class OrderLineInvoice
    {
        public string Company { get; set; }
        public decimal InvoiceNo { get; set; }
        public decimal OrderNo { get; set; }
        public decimal LineNo { get; set; }
        public decimal? QtyInvoiced { get; set; }
        public string Dept { get; set; }

        public InvoiceHeading InvoiceHeading { get; set; }
        public OrderHeading OrderHeading { get; set; }
    }
}
