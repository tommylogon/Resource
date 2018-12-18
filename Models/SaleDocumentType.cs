using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class SaleDocumentType
    {
        public Guid ObjNo { get; set; }
        public string TemplateOwner { get; set; }
        public string GroupName { get; set; }
        public bool? SystemGroup { get; set; }
        public string TemplateName { get; set; }
        public byte[] TemplateFile { get; set; }
        public bool? UseTemplate { get; set; }
        public int? TemplateType { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string Node { get; set; }
        public string ProtectedPassword { get; set; }
        public string Company { get; set; }

        public AppUser TemplateOwnerNavigation { get; set; }
    }
}
