using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class Address
    {
        public Address()
        {
            Machine = new HashSet<Machine>();
            Supplier = new HashSet<Supplier>();
        }

        public Guid SourceObjNo { get; set; }
        public decimal RowNo { get; set; }
        public string AddressCode { get; set; }
        public string AddressName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public Guid? AreaObjNo { get; set; }
        public string PhoneNo { get; set; }
        public string FaxNo { get; set; }
        public decimal? Invoice { get; set; }
        public decimal? Delivery { get; set; }
        public decimal? Visit { get; set; }
        public decimal? TravelCode { get; set; }
        public decimal? CoordX { get; set; }
        public decimal? CoordY { get; set; }
        public decimal? Letter { get; set; }
        public DateTime? ObjDate { get; set; }
        public string Username { get; set; }
        public string AddressId { get; set; }
        public string Description { get; set; }
        public string BankId { get; set; }
        public string BankName { get; set; }
        public string BankAccount { get; set; }
        public decimal? Post { get; set; }
        public string Address3 { get; set; }
        public string MainAddress { get; set; }
        public string State { get; set; }
        public string LanguageId { get; set; }
        public string AddressStatus { get; set; }
        public string InvoiceAsEmail { get; set; }
        public string InvoiceAsEmailAddress { get; set; }
        public string Iban { get; set; }
        public string Bic { get; set; }
        public string MandateRefNo { get; set; }

        public Country CountryNavigation { get; set; }
        public ICollection<Machine> Machine { get; set; }
        public ICollection<Supplier> Supplier { get; set; }
    }
}
