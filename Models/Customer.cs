using System.ComponentModel.DataAnnotations;

namespace Resource.Models
{
    public class Customer
    {
        [Display(Name = "Kunde nr")]
        public string CustomerID { get; set; }

        [Display(Name = "Navn")]
        public string CustomerName { get; set; }

        [Display(Name = "Adresse")]
        public string Adress { get; set; }

        [Display(Name = "Post nr")]
        public string PostalNr { get; set; }

        [Display(Name = "Post sted")]
        public string PostalAdress { get; set; }

        [Display(Name = "Telefon nr")]
        public string Phone { get; set; }

        [Display(Name = "Org nr")]
        public string OrgNr { get; set; }
    }
}