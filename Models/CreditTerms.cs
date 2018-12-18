using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class CreditTerms
    {
        public CreditTerms()
        {
            Contract = new HashSet<Contract>();
            Customer = new HashSet<Customer>();
            OrderHeading = new HashSet<OrderHeading>();
        }

        public string Company { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal? NoOfDays { get; set; }
        public Guid ObjNo { get; set; }
        public decimal? NoOfDaysDiscount { get; set; }
        public string FromEndOfMonth { get; set; }
        public string CalculateDiscount { get; set; }
        public string DiscountComment { get; set; }
        public decimal? Discount { get; set; }
        public int? Sepa { get; set; }
        public int? NoOfDaysDirectDebit { get; set; }

        public Company CompanyNavigation { get; set; }
        public ICollection<Contract> Contract { get; set; }
        public ICollection<Customer> Customer { get; set; }
        public ICollection<OrderHeading> OrderHeading { get; set; }
    }
}
