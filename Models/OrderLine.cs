using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class OrderLine
    {
        public OrderLine()
        {
            OrderLineMachine = new HashSet<OrderLineMachine>();
        }

        public string Company { get; set; }
        public decimal OrderNo { get; set; }
        public decimal LineNo { get; set; }
        public Guid? ArticleObjNo { get; set; }
        public string Description { get; set; }
        public string Unit { get; set; }
        public decimal? CostPrice { get; set; }
        public decimal? SalesPrice { get; set; }
        public decimal? Discount { get; set; }
        public decimal? QtyDelivered { get; set; }
        public decimal? QtyNotDelivered { get; set; }
        public decimal? VatCode { get; set; }
        public Guid? MachineObjNo { get; set; }
        public Guid? StockObjNo { get; set; }
        public string RowType { get; set; }
        public Guid? SalesmanObjNo { get; set; }
        public Guid? TechnicianObjNo { get; set; }
        public DateTime? ActiveFrom { get; set; }
        public DateTime? ActiveTo { get; set; }
        public decimal? ContractRowNo { get; set; }
        public decimal? Volume { get; set; }
        public decimal? FromCounter { get; set; }
        public decimal? ToCounter { get; set; }
        public string Booking { get; set; }
        public Guid? SourceObjNo { get; set; }
        public string OrderLineSource { get; set; }
        public string Sortgroup1 { get; set; }
        public string Sortgroup2 { get; set; }
        public string Invoiceable { get; set; }
        public string ServicesArticleType { get; set; }
        public string StockTracking { get; set; }
        public string Warrenty { get; set; }
        public decimal? QtyActDelivered { get; set; }
        public string ArticleSerialNo { get; set; }
        public Guid? DelCustomerObjNo { get; set; }
        public string DelAddress1 { get; set; }
        public string DelAddressName { get; set; }
        public string DelAddress2 { get; set; }
        public string DelPostalCode { get; set; }
        public string DelPostalDescription { get; set; }
        public string DelContactName { get; set; }
        public string DelCountryNo { get; set; }
        public string HideLine { get; set; }
        public string Info01 { get; set; }
        public string Info02 { get; set; }
        public string SerialNoOld { get; set; }
        public string SerialNoNew { get; set; }
        public decimal? RmaNo { get; set; }
        public string WarrantyStatus { get; set; }
        public string WarrantyComment { get; set; }
        public string WarrantyCommentIn { get; set; }
        public string WarrantyCommentOut { get; set; }
        public string WarrantyCommentInternal { get; set; }
        public DateTime? WarrantyPartReceived { get; set; }
        public DateTime? WarrantyPartSent { get; set; }
        public bool? WarrantyAccepted { get; set; }
        public string WarrantyComplete { get; set; }
        public string ExternalId { get; set; }
        public string DelAddress3 { get; set; }
        public DateTime? ObjDate { get; set; }
        public Guid? MeterObjNo { get; set; }
        public Guid? ObjNo { get; set; }
        public decimal? WorkHourListQty { get; set; }
        public string WorkHourListStatus { get; set; }
        public DateTime? WorkHourListObjDate { get; set; }
        public string WorkHourListUsername { get; set; }
        public string WorkHourListComment { get; set; }
        public Guid? SupplierObjNo { get; set; }
        public string AggregateArticleType { get; set; }
        public decimal? StockAdminQtyReceived { get; set; }
        public Guid? ContractTypeObjNo { get; set; }
        public Guid? ContractObjNo { get; set; }
        public string Info03 { get; set; }
        public string Info04 { get; set; }
        public Guid? ArticleModelLocationObjNo { get; set; }
        public decimal? OnAccountOrderNo { get; set; }
        public Guid? CpuObjNo { get; set; }
        public string SummarizeRowInfo { get; set; }
        public Guid? MasterLineObjNo { get; set; }
        public string DelState { get; set; }
        public string EcoTaxCalculate { get; set; }
        public decimal? EcoFeeLevel { get; set; }
        public decimal? ArticleWeight { get; set; }

        public Article ArticleObjNoNavigation { get; set; }
        public Machine MachineObjNoNavigation { get; set; }
        public OrderHeading OrderHeading { get; set; }
        public ICollection<OrderLineMachine> OrderLineMachine { get; set; }
    }
}
