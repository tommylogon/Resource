using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class ContactReference
    {
        public Guid SourceObjNo { get; set; }
        public Guid? ContactObjNo { get; set; }
        public string ContactCode { get; set; }
        public decimal ContactNo { get; set; }

        public Contact Contact { get; set; }
    }
}
