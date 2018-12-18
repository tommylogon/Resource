using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class SaleCalcHeading
    {
        public SaleCalcHeading()
        {
            SaleCalcOldContract = new HashSet<SaleCalcOldContract>();
            SaleOrderLine = new HashSet<SaleOrderLine>();
        }

        public Guid ObjNo { get; set; }
        public Guid SaleprojectObjNo { get; set; }
        public string Dept { get; set; }
        public string CalcType { get; set; }
        public decimal CalcNo { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string UseProjectPrice { get; set; }
        public decimal? ProjectPrice { get; set; }
        public string UseAutoSupplierFactor { get; set; }
        public Guid? SupplierObjNo { get; set; }
        public decimal? SupplierFactor { get; set; }
        public decimal? SpecialProvision { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public DateTime? LastUpdated { get; set; }
        public Guid? TemplateObjNo { get; set; }
        public string AllOnOneVolumeRow { get; set; }
        public DateTime? ContractStart { get; set; }
        public decimal? ContractPeriod { get; set; }
        public decimal? InternalContractPeriod { get; set; }
        public decimal? InternalContractTotal { get; set; }
        public DateTime? InternalContractEnd { get; set; }
        public string InternalContractDesc { get; set; }
        public decimal? ExternalContractTotal { get; set; }
        public string ExternalContractDesc { get; set; }
        public Guid? ContractObjNo { get; set; }
        public decimal? ExternalContractPeriod { get; set; }
        public DateTime? ExternalContractEnd { get; set; }
        public decimal? InternalContractCost { get; set; }
        public decimal? ExternalContractCost { get; set; }
        public decimal? CustomerProvFactor { get; set; }
        public decimal? ContractSpecialCosts { get; set; }
        public decimal? SupplierProvision { get; set; }
        public decimal? OrderNo { get; set; }
        public DateTime? DateGenerated { get; set; }
        public decimal? MaxHwDiscount { get; set; }
        public string Sortgroup1 { get; set; }
        public string Sortgroup2 { get; set; }
        public Guid? StockObjNo { get; set; }
        public Guid? SalesmanObjNo { get; set; }
        public string FeeCalculate { get; set; }
        public DateTime? ContractActiveFrom { get; set; }
        public decimal? OrderNoDirectSale { get; set; }

        public SaleSaleproject SaleprojectObjNoNavigation { get; set; }
        public ContractTemplate TemplateObjNoNavigation { get; set; }
        public ICollection<SaleCalcOldContract> SaleCalcOldContract { get; set; }
        public ICollection<SaleOrderLine> SaleOrderLine { get; set; }
    }
}
