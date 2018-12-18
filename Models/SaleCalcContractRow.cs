using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class SaleCalcContractRow
    {
        public Guid CalcObjNo { get; set; }
        public decimal ContractRowNo { get; set; }
        public Guid TemplateObjNo { get; set; }
    }
}
