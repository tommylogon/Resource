using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class InvoiceSetupDetail
    {
        public string Owner { get; set; }
        public string PreviewType { get; set; }
        public string Company { get; set; }
        public Guid ContractObjNo { get; set; }
        public Guid InvoiceCustomerObjNo { get; set; }
        public decimal InvoiceAddressRowNo { get; set; }
        public string SubContractNo { get; set; }
        public string MrSubContractNo { get; set; }
    }
}
