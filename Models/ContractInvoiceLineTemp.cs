using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class ContractInvoiceLineTemp
    {
        public string Owner { get; set; }
        public string PreviewType { get; set; }
        public string Company { get; set; }
        public Guid SourceObjNo { get; set; }
        public Guid InvoiceCustomerObjNo { get; set; }
        public decimal InvoiceAddressRowNo { get; set; }
        public decimal InvoiceLineNo { get; set; }
        public Guid? ArticleObjNo { get; set; }
        public string ArticleNo { get; set; }
        public string Description { get; set; }
        public string Unit { get; set; }
        public decimal? SalesPrice { get; set; }
        public decimal? Discount { get; set; }
        public decimal? QtyDelivered { get; set; }
        public decimal? VatCode { get; set; }
        public decimal? LineSum { get; set; }
        public string Sortgroup1 { get; set; }
        public string Sortgroup2 { get; set; }
        public Guid? SalesmanObjNo { get; set; }
        public decimal? ContractRowNo { get; set; }
        public string Source { get; set; }
        public string MeterReadingLetter { get; set; }
        public string SubContractNo { get; set; }

        public ContractInvoiceHeadingTemp ContractInvoiceHeadingTemp { get; set; }
    }
}
