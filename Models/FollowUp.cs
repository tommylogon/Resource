using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class FollowUp
    {
        public string FollowUpCode { get; set; }
        public Guid ObjNo { get; set; }
        public decimal FollowUpNo { get; set; }
        public DateTime FollowUpDate { get; set; }
        public Guid? FollowUpBy { get; set; }
        public string FollowUpCategory { get; set; }
        public string Description { get; set; }
        public decimal? Show { get; set; }

        public Salesman FollowUpByNavigation { get; set; }
    }
}
