using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class ContractInvoiceHeadingTemp
    {
        public ContractInvoiceHeadingTemp()
        {
            ContractInvoiceLineTemp = new HashSet<ContractInvoiceLineTemp>();
        }

        public string Owner { get; set; }
        public string PreviewType { get; set; }
        public string Company { get; set; }
        public Guid SourceObjNo { get; set; }
        public string Dept { get; set; }
        public Guid InvoiceCustomerObjNo { get; set; }
        public decimal InvoiceAddressRowNo { get; set; }
        public Guid CustomerObjNo { get; set; }
        public Guid DelCustomerObjNo { get; set; }
        public decimal DelAddressRowNo { get; set; }
        public Guid? CreditTermObjNo { get; set; }
        public string OrderType { get; set; }
        public string CustomerReference { get; set; }
        public string OurReference { get; set; }
        public string InvoiceInfo { get; set; }
        public Guid? SalesmanObjNo { get; set; }
        public string CalculateVat { get; set; }
        public string MeansOfDelivery { get; set; }
        public string DeliveryTerm { get; set; }
        public string Sortgroup1 { get; set; }
        public string Sortgroup2 { get; set; }
        public string SubContractNo { get; set; }
        public string Iban { get; set; }
        public string Bic { get; set; }
        public string MandateRefNo { get; set; }
        public string RowNumbers { get; set; }

        public ICollection<ContractInvoiceLineTemp> ContractInvoiceLineTemp { get; set; }
    }
}
