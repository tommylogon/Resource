using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class SaleSaleproject
    {
        public SaleSaleproject()
        {
            SaleCalcHeading = new HashSet<SaleCalcHeading>();
        }

        public Guid ObjNo { get; set; }
        public string SaleProject { get; set; }
        public Guid SaleCustomer { get; set; }
        public DateTime? SaleDate { get; set; }
        public decimal? SaleAmount { get; set; }
        public decimal? SaleProfit { get; set; }
        public int? SaleProbability { get; set; }
        public string SaleOwner { get; set; }
        public bool? SaleExpire { get; set; }
        public DateTime? SaleExpiredate { get; set; }
        public Guid? FollowUp1 { get; set; }
        public Guid? FollowUp2 { get; set; }
        public Guid? FollowUp3 { get; set; }
        public string Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public Guid? CalcObjNo { get; set; }
        public DateTime? DecisionDate { get; set; }
        public string CustomerNode { get; set; }
        public string Contact { get; set; }
        public string CustomerReference { get; set; }
        public decimal? ContactNo { get; set; }
        public decimal? SaleProjectNo { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ObjDate { get; set; }
        public string Username { get; set; }
        public Guid? ProjectOrderLink { get; set; }
        public string ProjectNotes { get; set; }

        public Customer SaleCustomerNavigation { get; set; }
        public ICollection<SaleCalcHeading> SaleCalcHeading { get; set; }
    }
}
