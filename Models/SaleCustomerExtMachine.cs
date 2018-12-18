using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class SaleCustomerExtMachine
    {
        public Guid ObjNo { get; set; }
        public string Company { get; set; }
        public Guid CustomerObjNo { get; set; }
        public string MachineNo { get; set; }
        public Guid ModelObjNo { get; set; }
        public DateTime? InstallationDate { get; set; }
        public decimal? ContactNo { get; set; }
        public Guid? SupplierObjNo { get; set; }
        public int? SaleProbability { get; set; }
        public decimal? AddressRowNo { get; set; }
        public bool? Contract { get; set; }
        public string ContractNo { get; set; }
        public bool? TotalContract { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal? Volume { get; set; }
        public decimal? FixedPrice { get; set; }
        public decimal? Ppu { get; set; }
        public decimal? Ppeu { get; set; }
        public string Information { get; set; }
        public string Sortgroup1 { get; set; }
        public string Sortgroup2 { get; set; }
        public string Sortgroup3 { get; set; }
        public decimal? NoticeTime { get; set; }
        public string Sortgroup4 { get; set; }
        public string Sortgroup5 { get; set; }
    }
}
