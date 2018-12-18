using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class AppSettingsSearch
    {
        public string LoginName { get; set; }
        public string SearchType { get; set; }
        public string SearchName { get; set; }
        public decimal RowIndex { get; set; }
        public string RowContents { get; set; }

        public AppUser LoginNameNavigation { get; set; }
    }
}
