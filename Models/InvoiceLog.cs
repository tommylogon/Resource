using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class InvoiceLog
    {
        public decimal LogNo { get; set; }
        public DateTime? LogTime { get; set; }
        public string LogUser { get; set; }
        public string LogType { get; set; }
        public string LogDescr { get; set; }
        public string LogText { get; set; }
        public Guid? ContractObjNo { get; set; }
    }
}
