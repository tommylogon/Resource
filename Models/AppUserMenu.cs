using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class AppUserMenu
    {
        public string Company { get; set; }
        public string LoginName { get; set; }
        public string MenuId { get; set; }
        public bool? OnMenu { get; set; }
        public bool? OnToolbar { get; set; }
        public decimal? OrderBy { get; set; }
    }
}
