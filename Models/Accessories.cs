using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class Accessories
    {
        public Guid MachineObjNo { get; set; }
        public int AccNo { get; set; }
        public Guid ArticleObjNo { get; set; }
        public string SerialNo { get; set; }

        public Article ArticleObjNoNavigation { get; set; }
        public Machine MachineObjNoNavigation { get; set; }
    }
}
