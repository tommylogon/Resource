using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class AppRolePermission
    {
        public Guid RoleObjNo { get; set; }
        public Guid PermissionObjNo { get; set; }
        public string PermissionCode { get; set; }

        public AppPermissionObject PermissionObjNoNavigation { get; set; }
        public AppRole RoleObjNoNavigation { get; set; }
    }
}
