using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class ExternalSoldItems
    {
        public string Company { get; set; }
        public string Dept { get; set; }
        public string InvoiceNo { get; set; }
        public string CustomerNo { get; set; }
        public string ArticleNo { get; set; }
        public decimal? QtyDelivered { get; set; }
        public decimal? SalesPrice { get; set; }
        public decimal? CostPrice { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string SerialNo { get; set; }
        public string ModelType { get; set; }
        public string Imported { get; set; }
        public Guid? MachineObjNo { get; set; }
        public decimal? ProjectNo { get; set; }
        public string ProjectCode { get; set; }
        public string PackingSlipNo { get; set; }
        public string StockNo { get; set; }
        public string Status { get; set; }
        public string StatusDescription { get; set; }
        public string Info01 { get; set; }
        public string Info02 { get; set; }
        public string Info03 { get; set; }
        public string Info04 { get; set; }
        public string Info05 { get; set; }
        public string DeliveryCustomerNo { get; set; }
        public string CustomerName { get; set; }
        public string CustomerName2 { get; set; }
        public string CustomerName3 { get; set; }
        public string CustomerName4 { get; set; }
        public string EMail { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string PostLocation { get; set; }
        public string AreaCode { get; set; }
        public string AreaDescription { get; set; }
        public string PhoneNo { get; set; }
        public string FaxNo { get; set; }
        public DateTime? ObjDate { get; set; }
        public string Username { get; set; }
        public string WarrantyText { get; set; }
        public DateTime? WarrantyEndDate { get; set; }
    }
}
