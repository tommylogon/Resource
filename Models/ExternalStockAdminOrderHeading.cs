using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class ExternalStockAdminOrderHeading
    {
        public ExternalStockAdminOrderHeading()
        {
            ExternalStockAdminOrderLine = new HashSet<ExternalStockAdminOrderLine>();
        }

        public decimal OrderNo { get; set; }
        public string Company { get; set; }
        public DateTime? OrderDate { get; set; }
        public string SupplierNo { get; set; }
        public string OrderType { get; set; }
        public string Dept { get; set; }
        public string MeansOfDelivery { get; set; }
        public string SuppliersOrderNo { get; set; }
        public string DelCustomerNo { get; set; }
        public string DelAddress1 { get; set; }
        public string DelAddress2 { get; set; }
        public string DelPostalCode { get; set; }
        public string DelPostalDescription { get; set; }
        public string DelPhoneNo { get; set; }
        public string DelFaxNo { get; set; }
        public string DelContactName { get; set; }
        public string DelCountryNo { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string DirectDelivery { get; set; }
        public string DelAddressName { get; set; }
        public string Contact { get; set; }
        public string DelAddress3 { get; set; }
        public string Status { get; set; }
        public decimal? ExternalOrderNo { get; set; }
        public string ExternalStatus { get; set; }
        public string ExternalInfo { get; set; }

        public ICollection<ExternalStockAdminOrderLine> ExternalStockAdminOrderLine { get; set; }
    }
}
