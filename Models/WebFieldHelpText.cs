using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class WebFieldHelpText
    {
        public int Id { get; set; }
        public string Page { get; set; }
        public string Field { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}
