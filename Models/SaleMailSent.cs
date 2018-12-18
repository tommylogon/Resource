using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class SaleMailSent
    {
        public Guid SourceObjNo { get; set; }
        public string EmailAdr { get; set; }
        public DateTime? DateSent { get; set; }
    }
}
