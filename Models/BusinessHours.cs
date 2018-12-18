using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class BusinessHours
    {
        public Guid SourceObjNo { get; set; }
        public decimal Day { get; set; }
        public string Hours { get; set; }
        public string Lunch { get; set; }
        public string Info { get; set; }
    }
}
