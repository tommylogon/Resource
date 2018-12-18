using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class InvoiceHeading
    {
        public InvoiceHeading()
        {
            OrderLineInvoice = new HashSet<OrderLineInvoice>();
        }

        public string Company { get; set; }
        public decimal InvoiceNo { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string InvoiceStatus { get; set; }
        public string ReminderNo { get; set; }
        public string AllPaid { get; set; }
        public string StatusPayment { get; set; }
        public string CustomerNode { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? InterestCalcTo { get; set; }
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
        public string DeliveryState { get; set; }
        public string InvoiceState { get; set; }
        public string InvoiceAsEmail { get; set; }
        public string InvoiceAsEmailAddress { get; set; }
        public string CustomerReferenceInfo { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string PaymentType { get; set; }
        public string InvoiceCustomerName { get; set; }
        public string InvoiceCustomerName2 { get; set; }
        public string InvoiceCustomerName3 { get; set; }
        public string InvoiceCustomerName4 { get; set; }
        public string DeliveryCustomerName { get; set; }
        public string DeliveryCustomerName2 { get; set; }
        public string DeliveryCustomerName3 { get; set; }
        public string DeliveryCustomerName4 { get; set; }
        public string Dept { get; set; }
        public DateTime? DirectDebitDate { get; set; }
        public string Iban { get; set; }
        public string Bic { get; set; }
        public string MandateRefNo { get; set; }

        public ICollection<OrderLineInvoice> OrderLineInvoice { get; set; }
    }
}
