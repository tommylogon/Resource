using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class AreaPostalCode
    {
        public Guid ObjNo { get; set; }
        public string Company { get; set; }
        public Guid AreaObjNo { get; set; }
        public string FromCountry { get; set; }
        public string FromPostalCode { get; set; }
        public string ToCountry { get; set; }
        public string ToPostalCode { get; set; }
    }
}
