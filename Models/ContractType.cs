using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class ContractType
    {
        public ContractType()
        {
            ContractFixedPrice = new HashSet<ContractFixedPrice>();
            ContractTemplate = new HashSet<ContractTemplate>();
            ContractTypeArticle = new HashSet<ContractTypeArticle>();
            ContractTypeGroups = new HashSet<ContractTypeGroups>();
            MachineOnContract = new HashSet<MachineOnContract>();
        }

        public Guid ObjNo { get; set; }
        public string Company { get; set; }
        public string ContractCode { get; set; }
        public string Description { get; set; }
        public decimal? ResponseTime { get; set; }
        public int? Service { get; set; }
        public int? Support { get; set; }
        public int? Project { get; set; }
        public decimal? ResponseTimeSupport { get; set; }
        public decimal? SolutionTime { get; set; }
        public decimal? SolutionTimeSupport { get; set; }
        public int? UseResponseTime { get; set; }
        public int? UseSolutionTime { get; set; }
        public string Dept { get; set; }
        public bool? Active { get; set; }
        public string Sg1QuickOrderNotShowIfInvoiceable { get; set; }
        public string Sg2QuickOrderNotShowIfInvoiceable { get; set; }
        public string Sg3QuickOrderNotShowIfInvoiceable { get; set; }
        public string Sg4QuickOrderNotShowIfInvoiceable { get; set; }
        public string Sg5QuickOrderNotShowIfInvoiceable { get; set; }

        public Company CompanyNavigation { get; set; }
        public ICollection<ContractFixedPrice> ContractFixedPrice { get; set; }
        public ICollection<ContractTemplate> ContractTemplate { get; set; }
        public ICollection<ContractTypeArticle> ContractTypeArticle { get; set; }
        public ICollection<ContractTypeGroups> ContractTypeGroups { get; set; }
        public ICollection<MachineOnContract> MachineOnContract { get; set; }
    }
}
