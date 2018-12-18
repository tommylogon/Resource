using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class ContractTypeGroups
    {
        public Guid ContractTypeObjNo { get; set; }
        public string Registry { get; set; }
        public string Code { get; set; }

        public ContractType ContractTypeObjNoNavigation { get; set; }
    }
}
