using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class PriceChangeProjectAutoLog
    {
        public string Company { get; set; }
        public DateTime ObjDate { get; set; }
        public string PriceChangeType { get; set; }
        public Guid BatchObjNo { get; set; }
        public decimal LineNo { get; set; }
        public string Owner { get; set; }
        public decimal ProjectNo { get; set; }
        public decimal TaskNo { get; set; }
        public decimal? OldPrice { get; set; }
        public decimal? OldCostPrice { get; set; }
        public decimal? NewPrice { get; set; }
        public decimal? NewCostPrice { get; set; }
        public string MachineNo { get; set; }
        public string ModelType { get; set; }
        public string CustomerNo { get; set; }
        public string CustomerName { get; set; }
        public Guid? SourceObjNo { get; set; }
    }
}
