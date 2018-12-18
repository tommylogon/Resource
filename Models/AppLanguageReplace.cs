using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class AppLanguageReplace
    {
        public Guid? ObjNo { get; set; }
        public string LanguageId { get; set; }
        public string OrigionalText { get; set; }
        public string ReplaceText { get; set; }
        public decimal? OrderBy { get; set; }
    }
}
