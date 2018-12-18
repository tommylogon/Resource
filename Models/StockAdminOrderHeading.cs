using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class StockAdminOrderHeading
    {
        public StockAdminOrderHeading()
        {
            StockAdminOrderLine = new HashSet<StockAdminOrderLine>();
        }

        public Guid ObjNo { get; set; }
        public decimal? OrderNo { get; set; }
        public string Company { get; set; }
        public DateTime? OrderDate { get; set; }
        public Guid SupplierObjNo { get; set; }
        public string OrderType { get; set; }
        public string Dept { get; set; }
        public string MeansOfDelivery { get; set; }
        public string SuppliersOrderNo { get; set; }
        public Guid? DelCustomerObjNo { get; set; }
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
        public DateTime? ObjDateCreate { get; set; }
        public string UsernameCreate { get; set; }
        public DateTime? ObjDate { get; set; }
        public string Username { get; set; }
        public string Information { get; set; }
        public string StatusInformation { get; set; }
        public string DelState { get; set; }

        public ICollection<StockAdminOrderLine> StockAdminOrderLine { get; set; }
    }
}
