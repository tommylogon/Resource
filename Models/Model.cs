using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class Model
    {
        public Model()
        {
            ArticleModelLocation = new HashSet<ArticleModelLocation>();
            CompetenceGroupDetails = new HashSet<CompetenceGroupDetails>();
            CustomerMachineModelMeterPrice = new HashSet<CustomerMachineModelMeterPrice>();
            FrequenceList = new HashSet<FrequenceList>();
            Machine = new HashSet<Machine>();
            ModelMeter = new HashSet<ModelMeter>();
            ModelMeterPrice = new HashSet<ModelMeterPrice>();
            Problem = new HashSet<Problem>();
            QuickOrderArticles = new HashSet<QuickOrderArticles>();
        }

        public Guid ObjNo { get; set; }
        public string Company { get; set; }
        public string ModelType { get; set; }
        public string Description { get; set; }
        public Guid? SupplierObjNo { get; set; }
        public string WarrantyCode { get; set; }
        public DateTime? ObjDate { get; set; }
        public string Username { get; set; }
        public bool? Active { get; set; }
        public Guid? ArticleObjNo { get; set; }
        public decimal? ServiceInterval { get; set; }
        public Guid? TotalMeterObjNo { get; set; }
        public string MachineSortgroup1 { get; set; }
        public string MachineSortgroup2 { get; set; }
        public string MachineSortgroup3 { get; set; }
        public string MachineSortgroup4 { get; set; }
        public string MachineSortgroup5 { get; set; }
        public Guid? IntervalGroupObjNo { get; set; }
        public DateTime? LaunchDate { get; set; }
        public DateTime? OutOfProd { get; set; }

        public Article ArticleObjNoNavigation { get; set; }
        public Company CompanyNavigation { get; set; }
        public Supplier SupplierObjNoNavigation { get; set; }
        public ICollection<ArticleModelLocation> ArticleModelLocation { get; set; }
        public ICollection<CompetenceGroupDetails> CompetenceGroupDetails { get; set; }
        public ICollection<CustomerMachineModelMeterPrice> CustomerMachineModelMeterPrice { get; set; }
        public ICollection<FrequenceList> FrequenceList { get; set; }
        public ICollection<Machine> Machine { get; set; }
        public ICollection<ModelMeter> ModelMeter { get; set; }
        public ICollection<ModelMeterPrice> ModelMeterPrice { get; set; }
        public ICollection<Problem> Problem { get; set; }
        public ICollection<QuickOrderArticles> QuickOrderArticles { get; set; }
    }
}
