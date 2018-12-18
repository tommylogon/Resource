using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class MobileOrderHeading
    {
        public int RowId { get; set; }
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
    }
}
