using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class OrderHeading
    {
        public OrderHeading()
        {
            CustomerPayment = new HashSet<CustomerPayment>();
            OrderLine = new HashSet<OrderLine>();
            OrderLineInvoice = new HashSet<OrderLineInvoice>();
        }

        public string Company { get; set; }
        public decimal OrderNo { get; set; }
        public string Dept { get; set; }
        public decimal InvoiceNo { get; set; }
        public string InvoiceType { get; set; }
        public string Status { get; set; }
        public Guid CustomerObjNo { get; set; }
        public string OrderType { get; set; }
        public string DeliveryName { get; set; }
        public string DeliveryAddress1 { get; set; }
        public string DeliveryAddress2 { get; set; }
        public string DeliveryPostalcode { get; set; }
        public Guid? CreditTerm { get; set; }
        public string MeansOfDelivery { get; set; }
        public string DeliveryTerm { get; set; }
        public Guid? SalesmanObjNo { get; set; }
        public string CustomerReference { get; set; }
        public string OurReference { get; set; }
        public string CalculateVat { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public DateTime? DueDate { get; set; }
        public Guid? SourceObjNo { get; set; }
        public decimal? InvoiceAddressRowNo { get; set; }
        public string DeliveryPostlocation { get; set; }
        public string OrderSource { get; set; }
        public string Sortgroup1 { get; set; }
        public string Sortgroup2 { get; set; }
        public DateTime? InterestCalcTo { get; set; }
        public string ReminderNo { get; set; }
        public string AllPaid { get; set; }
        public string OrderTag { get; set; }
        public string InvoiceFee { get; set; }
        public string Info01 { get; set; }
        public string Info02 { get; set; }
        public string Info03 { get; set; }
        public string Info04 { get; set; }
        public string Info05 { get; set; }
        public string Info06 { get; set; }
        public string Info07 { get; set; }
        public string Info08 { get; set; }
        public string Info09 { get; set; }
        public string Info10 { get; set; }
        public decimal? OrderNoCredit { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string StatusPayment { get; set; }
        public string Information { get; set; }
        public Guid? DelCustomerObjNo { get; set; }
        public string DeliveryAddressId { get; set; }
        public string MakeXmlFileOfInvoice { get; set; }
        public Guid? InvoiceCustomerObjNo { get; set; }
        public string CustomerNode { get; set; }
        public string AmalgamateOrders { get; set; }
        public string InvoiceName { get; set; }
        public string InvoiceAddress1 { get; set; }
        public string InvoiceAddress2 { get; set; }
        public string InvoicePostalcode { get; set; }
        public string InvoicePostlocation { get; set; }
        public string DeliveryAddress3 { get; set; }
        public string DeliveryCountry { get; set; }
        public string InvoiceAddress3 { get; set; }
        public string InvoiceCountry { get; set; }
        public decimal? InvoiceNoCredit { get; set; }
        public Guid? ObjNo { get; set; }
        public string DeliveryState { get; set; }
        public string InvoiceState { get; set; }
        public string ObjectOpen { get; set; }
        public string ObjectOpenedBy { get; set; }
        public DateTime? ObjectOpenedDate { get; set; }
        public decimal? OrderNoOnAccount { get; set; }
        public string InvoiceAsEmail { get; set; }
        public string InvoiceAsEmailAddress { get; set; }
        public string CustomerReferenceInfo { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ObjDate { get; set; }
        public string Username { get; set; }
        public string PaymentType { get; set; }
        public Guid? CpuObjNo { get; set; }
        public string InvoiceDeptCredit { get; set; }
        public DateTime? DirectDebitDate { get; set; }
        public string Iban { get; set; }
        public string Bic { get; set; }
        public string MandateRefNo { get; set; }
        public string NotAllowPartlyDeliver { get; set; }

        public Company CompanyNavigation { get; set; }
        public CreditTerms CreditTermNavigation { get; set; }
        public Customer CustomerObjNoNavigation { get; set; }
        public Department Department { get; set; }
        public Salesman SalesmanObjNoNavigation { get; set; }
        public ICollection<CustomerPayment> CustomerPayment { get; set; }
        public ICollection<OrderLine> OrderLine { get; set; }
        public ICollection<OrderLineInvoice> OrderLineInvoice { get; set; }
    }
}
