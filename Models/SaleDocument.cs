using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class SaleDocument
    {
        public Guid ObjNo { get; set; }
        public Guid? CustomerObjNo { get; set; }
        public Guid? DocumentType { get; set; }
        public string DocumentName { get; set; }
        public byte[] DocumentFile { get; set; }
        public string DocumentOwner { get; set; }
        public Guid? DocumentSale { get; set; }
        public decimal? ContactNo { get; set; }
        public DateTime? DocumentDateCreated { get; set; }
        public DateTime? DocumentDateChanged { get; set; }
        public decimal? DocumentSize { get; set; }
        public int? DocumentTypeid { get; set; }
        public string DocumentSeek { get; set; }
        public string DocNode { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string WriteAccessUsers { get; set; }
        public string DocumentCategory { get; set; }
        public string InfoCheckbox01 { get; set; }
        public string InfoCheckbox02 { get; set; }
        public string InfoCheckbox03 { get; set; }
        public string InfoCheckbox04 { get; set; }
        public string InfoCheckbox05 { get; set; }
    }
}
