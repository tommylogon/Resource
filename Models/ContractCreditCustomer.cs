using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class ContractCreditCustomer
    {
        public Guid ObjNo { get; set; }
        public Guid SourceObjNo { get; set; }
        public Guid CustomerObjNo { get; set; }
        public decimal? CreditPercentage { get; set; }
        public decimal? CreditPercentageMr { get; set; }
        public decimal? CreditFixed { get; set; }
        public decimal? CreditFixedMr { get; set; }
        public string CreditOnlyOnce { get; set; }
        public DateTime? CreditEndDate { get; set; }
        public string CreditEnabled { get; set; }
        public string CreditVirtual { get; set; }
        public string UnitPriceCredit { get; set; }

        public Customer CustomerObjNoNavigation { get; set; }
    }
}
