using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class CustomerPayment
    {
        public string Company { get; set; }
        public decimal OrderNo { get; set; }
        public DateTime DateOfPayment { get; set; }
        public decimal? Amount { get; set; }
        public string StatusPayment { get; set; }

        public OrderHeading OrderHeading { get; set; }
    }
}
