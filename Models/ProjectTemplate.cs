using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class ProjectTemplate
    {
        public string Company { get; set; }
        public Guid ObjNo { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
    }
}
