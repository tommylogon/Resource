using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class DocumentTrans
    {
        public Guid ObjNo { get; set; }
        public byte[] DocumentFile { get; set; }
        public string DocumentTitle { get; set; }
    }
}
