using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class AppRole
    {
        public AppRole()
        {
            AppRolePermission = new HashSet<AppRolePermission>();
            AppUser = new HashSet<AppUser>();
        }

        public Guid ObjNo { get; set; }
        public string RoleName { get; set; }
        public string Description { get; set; }
        public string SettingsAccess { get; set; }

        public ICollection<AppRolePermission> AppRolePermission { get; set; }
        public ICollection<AppUser> AppUser { get; set; }
    }
}
