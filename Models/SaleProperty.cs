using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class SaleProperty
    {
        public Guid ObjNo { get; set; }
        public Guid ObjNoSource { get; set; }
        public string PropertyOwner { get; set; }
        public string Property { get; set; }
        public string Value { get; set; }
        public bool? GlobalValue { get; set; }
        public DateTime? LastUpdated { get; set; }

        public AppUser PropertyOwnerNavigation { get; set; }
    }
}
