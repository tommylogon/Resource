using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class Country
    {
        public Country()
        {
            Address = new HashSet<Address>();
            PostalCode = new HashSet<PostalCode>();
        }

        public string CountryNo { get; set; }
        public string CountryName { get; set; }
        public string AddressFreeFields { get; set; }

        public ICollection<Address> Address { get; set; }
        public ICollection<PostalCode> PostalCode { get; set; }
    }
}
