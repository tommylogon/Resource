using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class Stock
    {
        public Stock()
        {
            Salesman = new HashSet<Salesman>();
            StockAdminArticle = new HashSet<StockAdminArticle>();
            StockQty = new HashSet<StockQty>();
            Technician = new HashSet<Technician>();
        }

        public Guid ObjNo { get; set; }
        public string Company { get; set; }
        public string StockNo { get; set; }
        public string Description { get; set; }
        public Guid? MainStockObjNo { get; set; }
        public string Dept { get; set; }
        public string StockStatus { get; set; }
        public string Type { get; set; }
        public string StockName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string PostalDescription { get; set; }
        public string State { get; set; }
        public string PhoneNo { get; set; }
        public string MobilePhoneNo { get; set; }
        public string Contact { get; set; }
        public string EMail1 { get; set; }
        public string Note { get; set; }

        public Company CompanyNavigation { get; set; }
        public ICollection<Salesman> Salesman { get; set; }
        public ICollection<StockAdminArticle> StockAdminArticle { get; set; }
        public ICollection<StockQty> StockQty { get; set; }
        public ICollection<Technician> Technician { get; set; }
    }
}
