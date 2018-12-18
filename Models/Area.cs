using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class Area
    {
        public Area()
        {
            AreaResource = new HashSet<AreaResource>();
            Project = new HashSet<Project>();
            ProjectAuto = new HashSet<ProjectAuto>();
            ProjectTask = new HashSet<ProjectTask>();
            ProjectTaskAuto = new HashSet<ProjectTaskAuto>();
            Salesman = new HashSet<Salesman>();
        }

        public Guid ObjNo { get; set; }
        public string Company { get; set; }
        public string Dept { get; set; }
        public string AreaCode { get; set; }
        public string Description { get; set; }
        public decimal? TravelTime { get; set; }
        public decimal? DistanceKm { get; set; }
        public decimal? TravelCostPrice { get; set; }
        public decimal? TravelSalesPrice { get; set; }

        public Company CompanyNavigation { get; set; }
        public Department Department { get; set; }
        public ICollection<AreaResource> AreaResource { get; set; }
        public ICollection<Project> Project { get; set; }
        public ICollection<ProjectAuto> ProjectAuto { get; set; }
        public ICollection<ProjectTask> ProjectTask { get; set; }
        public ICollection<ProjectTaskAuto> ProjectTaskAuto { get; set; }
        public ICollection<Salesman> Salesman { get; set; }
    }
}
