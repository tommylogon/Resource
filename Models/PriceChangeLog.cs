using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class PriceChangeLog
    {
        public string Company { get; set; }
        public DateTime ObjDate { get; set; }
        public string PriceChangeType { get; set; }
        public Guid BatchObjNo { get; set; }
        public decimal LineNo { get; set; }
        public string Owner { get; set; }
        public string ContractNo { get; set; }
        public decimal? ContractRowNo { get; set; }
        public string PriceType { get; set; }
        public decimal? OldPrice { get; set; }
        public DateTime? OldPriceDate { get; set; }
        public decimal? NewPrice { get; set; }
        public DateTime? NewPriceDate { get; set; }
        public string MachineNo { get; set; }
        public string ModelType { get; set; }
        public string CustomerNo { get; set; }
        public string CustomerName { get; set; }
        public Guid? PriceSourceObjNo { get; set; }
    }
}
