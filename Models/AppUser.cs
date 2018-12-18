using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class AppUser
    {
        public AppUser()
        {
            AppSettingsSearch = new HashSet<AppSettingsSearch>();
            AppUserDept = new HashSet<AppUserDept>();
            SaleBookmark = new HashSet<SaleBookmark>();
            SaleDocumentType = new HashSet<SaleDocumentType>();
            SaleGridlayout = new HashSet<SaleGridlayout>();
            SaleProperty = new HashSet<SaleProperty>();
            UserIdentity = new HashSet<UserIdentity>();
        }

        public string LoginName { get; set; }
        public string FullName { get; set; }
        public string Description { get; set; }
        public Guid? RoleObjNo { get; set; }
        public string Company { get; set; }
        public string Dept { get; set; }
        public string CountryNo { get; set; }
        public string Type { get; set; }
        public Guid? LinkObjNo { get; set; }
        public string SyncStatus { get; set; }
        public string SyncMachine { get; set; }
        public DateTime? SyncTimeOut { get; set; }
        public DateTime? SyncTimeIn { get; set; }
        public string ReportLanguage { get; set; }
        public string ProgramLanguage { get; set; }
        public string ShowOnlyDefAppLanguage { get; set; }
        public string ShowOnlyDefPrintLanguage { get; set; }
        public string UserType { get; set; }
        public string ExchMail { get; set; }
        public string ShowOnlyOwn { get; set; }
        public string ShowOnlyOwnArticle { get; set; }
        public DateTime? LastLoginEsObjDate { get; set; }
        public string DisableCheckForExcel { get; set; }
        public int? UseMap { get; set; }
        public bool? Inactive { get; set; }

        public AppRole RoleObjNoNavigation { get; set; }
        public ICollection<AppSettingsSearch> AppSettingsSearch { get; set; }
        public ICollection<AppUserDept> AppUserDept { get; set; }
        public ICollection<SaleBookmark> SaleBookmark { get; set; }
        public ICollection<SaleDocumentType> SaleDocumentType { get; set; }
        public ICollection<SaleGridlayout> SaleGridlayout { get; set; }
        public ICollection<SaleProperty> SaleProperty { get; set; }
        public ICollection<UserIdentity> UserIdentity { get; set; }
    }
}
