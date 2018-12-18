using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class Salesman
    {
        public Salesman()
        {
            ContractFixedPrice = new HashSet<ContractFixedPrice>();
            Customer = new HashSet<Customer>();
            FollowUp = new HashSet<FollowUp>();
            OrderHeading = new HashSet<OrderHeading>();
            Technician = new HashSet<Technician>();
        }

        public Guid ObjNo { get; set; }
        public string Company { get; set; }
        public string SalesmanCode { get; set; }
        public string SalesmanName { get; set; }
        public Guid? StockObjNo { get; set; }
        public Guid? AreaObjNo { get; set; }
        public string Active { get; set; }

        public Area AreaObjNoNavigation { get; set; }
        public Company CompanyNavigation { get; set; }
        public Stock StockObjNoNavigation { get; set; }
        public ICollection<ContractFixedPrice> ContractFixedPrice { get; set; }
        public ICollection<Customer> Customer { get; set; }
        public ICollection<FollowUp> FollowUp { get; set; }
        public ICollection<OrderHeading> OrderHeading { get; set; }
        public ICollection<Technician> Technician { get; set; }
    }
}
