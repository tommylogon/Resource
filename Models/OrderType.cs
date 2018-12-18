using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class OrderType
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public string DebetCode { get; set; }
        public string CreditCode { get; set; }
        public string Company { get; set; }
    }
}
