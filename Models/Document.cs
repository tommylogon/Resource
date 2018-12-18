using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class Document
    {
        public Guid ObjNo { get; set; }
        public Guid? SourceObjNo { get; set; }
        public string DocumentTitle { get; set; }
        public decimal? DocumentSize { get; set; }
        public string DocumentType { get; set; }
        public DateTime DocumentDateCreated { get; set; }
        public byte[] DocumentFile { get; set; }
        public string UseInMobile { get; set; }
        public decimal? OrderNo { get; set; }
        public string UseInMeterReadingLetter { get; set; }
        public string InfoCheckbox01 { get; set; }
        public string InfoCheckbox02 { get; set; }
        public string InfoCheckbox03 { get; set; }
        public string InfoCheckbox04 { get; set; }
        public string InfoCheckbox05 { get; set; }
        public Guid? ResourceObjNo { get; set; }
        public string ReadOnlyAccess { get; set; }
        public Guid? TaskObjNo { get; set; }
        public string DocNode { get; set; }
    }
}
