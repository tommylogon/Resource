using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class Supplier
    {
        public Supplier()
        {
            Article = new HashSet<Article>();
            Model = new HashSet<Model>();
            SupplierDept = new HashSet<SupplierDept>();
        }

        public Guid ObjNo { get; set; }
        public string Company { get; set; }
        public string SupplierNo { get; set; }
        public string SupplierName { get; set; }
        public string Email { get; set; }
        public bool? Active { get; set; }
        public bool? LeasingSupplier { get; set; }
        public bool? RentalSupplier { get; set; }
        public bool? ArticleSupplier { get; set; }
        public decimal? SupplierProvisionFactor { get; set; }
        public Guid? CustomerObjNo { get; set; }
        public decimal? AddressRowNo { get; set; }
        public decimal? InvoiceAddressRowNo { get; set; }
        public decimal? SalesmanProvisionPercent { get; set; }
        public string OwnCustomerNo { get; set; }
        public decimal? MinOrderTotal { get; set; }
        public Guid? CreditTerm { get; set; }
        public string SupplierInfo { get; set; }
        public string AllowExportToFile { get; set; }
        public string ExportToFileSp { get; set; }
        public string SendFileWithFtp { get; set; }
        public string FtpHostname { get; set; }
        public string FtpUser { get; set; }
        public string FtpPassword { get; set; }
        public string FtpPassiveMode { get; set; }
        public decimal? FtpPort { get; set; }
        public string FtpProxy { get; set; }
        public string FtpRelativeDirectory { get; set; }
        public string FtpFilename { get; set; }
        public decimal? Discount { get; set; }
        public decimal? Discount2 { get; set; }
        public string ExternalId { get; set; }
        public string ExternalSystemOn { get; set; }

        public Address Address { get; set; }
        public Company CompanyNavigation { get; set; }
        public Customer CustomerObjNoNavigation { get; set; }
        public ICollection<Article> Article { get; set; }
        public ICollection<Model> Model { get; set; }
        public ICollection<SupplierDept> SupplierDept { get; set; }
    }
}
