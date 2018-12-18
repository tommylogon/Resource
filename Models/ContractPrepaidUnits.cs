using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class ContractPrepaidUnits
    {
        public Guid ContractObjNo { get; set; }
        public int RowNo { get; set; }
        public Guid ObjNo { get; set; }
        public string PuName { get; set; }
        public string PuDescription { get; set; }
        public decimal Units { get; set; }
        public decimal UnitPrice { get; set; }
        public DateTime ValidTo { get; set; }
        public DateTime InvoiceDate { get; set; }
        public Guid ArticleObjNo { get; set; }
        public int? AutoInvoice { get; set; }
        public Guid? InvCustomerObjNo { get; set; }
        public int? InvAddressRowNo { get; set; }
        public string InvoiceInfo { get; set; }
        public string NextInvoiceInfo { get; set; }
        public string ShowOnNext { get; set; }
        public decimal? OrderNo { get; set; }
        public decimal? ContractPeriod { get; set; }
        public int? Status { get; set; }

        public Contract ContractObjNoNavigation { get; set; }
    }
}
