using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class Contact
    {
        public Contact()
        {
            ContactReference = new HashSet<ContactReference>();
        }

        public string ContactCode { get; set; }
        public Guid ObjNo { get; set; }
        public decimal ContactNo { get; set; }
        public string ContactName { get; set; }
        public string EMail1 { get; set; }
        public string EMail2 { get; set; }
        public string JobTitle { get; set; }
        public string PhoneNo { get; set; }
        public string FaxNo { get; set; }
        public string MobilePhoneNo { get; set; }
        public DateTime? ObjDate { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string ContactInfo { get; set; }
        public DateTime? Birthday { get; set; }
        public string SirTitle { get; set; }
        public string LetterTitle { get; set; }
        public decimal? AddressRowNo { get; set; }
        public string MainContact { get; set; }
        public string ContactId { get; set; }
        public string ContactStatus { get; set; }
        public int? WebAccess { get; set; }
        public string WebPassword { get; set; }
        public int? WebAccessProject { get; set; }
        public int? WebAccessOrder { get; set; }
        public int? WebAccessMeterReporting { get; set; }
        public int? WebAccessProjectLog { get; set; }
        public int? WebAccessOrderLog { get; set; }
        public int? WebAccessSupport { get; set; }
        public int? WebAccessSupportLog { get; set; }
        public int? WebAccessMachine { get; set; }
        public int? WebAccessContact { get; set; }
        public int? WebAccessOnlyOwn { get; set; }
        public string ExternalSystemKey { get; set; }
        public string ContactNotes { get; set; }

        public ICollection<ContactReference> ContactReference { get; set; }
    }
}
