using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class InformationLink
    {
        public string Company { get; set; }
        public int TextType { get; set; }
        public decimal TextNo { get; set; }
        public Guid SourceObjNo { get; set; }
    }
}
