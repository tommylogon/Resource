using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class InvoicePayment
    {
        public string Company { get; set; }
        public decimal InvoiceNo { get; set; }
        public DateTime DateOfPayment { get; set; }
        public decimal? Amount { get; set; }
        public string StatusPayment { get; set; }
        public string Dept { get; set; }
        public string Info01 { get; set; }
        public string Info02 { get; set; }
        public string Info03 { get; set; }
        public string Info04 { get; set; }
        public string Info05 { get; set; }
        public string Info06 { get; set; }
    }
}
