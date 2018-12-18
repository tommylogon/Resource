using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class UserIdentity
    {
        public UserIdentity()
        {
            Technician = new HashSet<Technician>();
        }

        public int UserIdentityId { get; set; }
        public string AppUserLoginName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordResetToken { get; set; }
        public DateTime? PasswordResetRequestedOn { get; set; }

        public AppUser AppUserLoginNameNavigation { get; set; }
        public ICollection<Technician> Technician { get; set; }
    }
}
