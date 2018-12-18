using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class CustomerBalance
    {
        public Guid CustomerObjNo { get; set; }
        public decimal? Balance { get; set; }

        public Customer CustomerObjNoNavigation { get; set; }
    }
}
