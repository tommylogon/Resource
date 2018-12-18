using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class AppPermissionObject
    {
        public AppPermissionObject()
        {
            AppRolePermission = new HashSet<AppRolePermission>();
        }

        public Guid ObjNo { get; set; }
        public string PermissionName { get; set; }
        public string Description { get; set; }

        public ICollection<AppRolePermission> AppRolePermission { get; set; }
    }
}
