using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class Property
    {
        public Guid ObjNo { get; set; }
        public Guid SourceObjNo { get; set; }
        public string Code { get; set; }
        public string Value { get; set; }
    }
}
