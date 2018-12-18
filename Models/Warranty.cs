using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class Warranty
    {
        public string Company { get; set; }
        public decimal WarrantyNo { get; set; }
        public string Status { get; set; }
        public DateTime RegistrationDate { get; set; }
        public Guid CustomerObjNo { get; set; }
        public Guid? MachineObjNo { get; set; }
        public string MachineNo { get; set; }
        public string ModelType { get; set; }
        public decimal? MachineCounter { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public DateTime InstallationDate { get; set; }
        public Guid ArticleObjNo { get; set; }
        public DateTime? ArticleInstallationDate { get; set; }
        public decimal Qty { get; set; }
        public decimal? ProjectNo { get; set; }
        public decimal? TaskNo { get; set; }
        public decimal? ArticleCounter { get; set; }
        public string SerialNoOld { get; set; }
        public string SerialNoNew { get; set; }
        public decimal? CostPrice { get; set; }
        public decimal? SalesPrice { get; set; }
        public DateTime? WarrantyDate { get; set; }
        public string InvoiceNoCustomer { get; set; }
        public string SymptomText { get; set; }
        public bool? Rma { get; set; }
        public decimal? RmaNo { get; set; }
        public bool? Accepted { get; set; }
        public string StatusInternal { get; set; }
        public string StatusProducer { get; set; }
        public string Comment { get; set; }
        public string CommentIn { get; set; }
        public string CommentOut { get; set; }
        public DateTime? PartReceived { get; set; }
        public DateTime? PartSent { get; set; }
        public bool? Compensation { get; set; }
        public bool? CompensationProcessed { get; set; }
        public decimal? CompensationWork { get; set; }
        public decimal? CompensationTransport { get; set; }
        public string Info1 { get; set; }
        public string Info2 { get; set; }
        public string Info3 { get; set; }
        public string Info4 { get; set; }
        public string Info5 { get; set; }
        public string Sortgroup1 { get; set; }
        public string Sortgroup2 { get; set; }
        public string Sortgroup3 { get; set; }
        public string Sortgroup4 { get; set; }
        public string Sortgroup5 { get; set; }

        public Article ArticleObjNoNavigation { get; set; }
        public Company CompanyNavigation { get; set; }
        public Customer CustomerObjNoNavigation { get; set; }
    }
}
