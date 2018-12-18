using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class PackingSlipHeading
    {
        public string Company { get; set; }
        public decimal PackingSlipNo { get; set; }
        public Guid? InvoiceCustomerObjNo { get; set; }
        public string InvoiceName { get; set; }
        public string InvoiceAddress1 { get; set; }
        public string InvoiceAddress2 { get; set; }
        public string InvoiceAddress3 { get; set; }
        public string InvoiceCountry { get; set; }
        public string InvoicePostalcode { get; set; }
        public string InvoicePostlocation { get; set; }
        public string CustomerReference { get; set; }
        public string OurReference { get; set; }
        public Guid? DeliveryCustomerObjNo { get; set; }
        public string DeliveryName { get; set; }
        public string DeliveryAddress1 { get; set; }
        public string DeliveryAddress2 { get; set; }
        public string DeliveryAddress3 { get; set; }
        public string DeliveryCountry { get; set; }
        public string DeliveryPostalcode { get; set; }
        public string DeliveryPostlocation { get; set; }
        public string DeliveryContactName { get; set; }
        public string TrackingNumber { get; set; }
        public string CustomerReferenceInfo { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string InvoiceCustomerName { get; set; }
        public string InvoiceCustomerName2 { get; set; }
        public string InvoiceCustomerName3 { get; set; }
        public string InvoiceCustomerName4 { get; set; }
        public string DeliveryCustomerName { get; set; }
        public string DeliveryCustomerName2 { get; set; }
        public string DeliveryCustomerName3 { get; set; }
        public string DeliveryCustomerName4 { get; set; }
        public string PackingSlipStatus { get; set; }
        public DateTime? PackingSlipStatusDate { get; set; }
        public string PackingSlipStatusUser { get; set; }
        public string InvoiceState { get; set; }
        public string DeliveryState { get; set; }
    }
}
