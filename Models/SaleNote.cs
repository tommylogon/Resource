using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class SaleNote
    {
        public Guid ObjNo { get; set; }
        public string NoteText { get; set; }
        public Guid SourceObjNo { get; set; }
        public DateTime DateCreated { get; set; }
        public decimal? ContactNo { get; set; }
    }
}
