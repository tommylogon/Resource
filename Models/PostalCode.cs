using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class PostalCode
    {
        public string PostalCode1 { get; set; }
        public string Description { get; set; }
        public string Country { get; set; }

        public Country CountryNavigation { get; set; }
    }
}
