using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class AppRolePermissionDetails
    {
        public Guid RoleObjNo { get; set; }
        public Guid PermissionObjNo { get; set; }
        public decimal DetailType { get; set; }
        public string DetailCode { get; set; }
    }
}
