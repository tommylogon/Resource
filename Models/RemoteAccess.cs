using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class RemoteAccess
    {
        public Guid SourceObjNo { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string AccessType { get; set; }
        public int? MainAccess { get; set; }
        public Guid? MachineObjNo { get; set; }
        public DateTime? ObjDate { get; set; }
        public string Username { get; set; }
        public string ConnectionType { get; set; }

        public Customer SourceObjNoNavigation { get; set; }
    }
}
