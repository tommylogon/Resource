using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class SaleCustomerMail
    {
        public Guid ObjNo { get; set; }
        public string ExtId { get; set; }
        public Guid CustomerObjNo { get; set; }
        public string MailOwner { get; set; }
        public DateTime? DateSent { get; set; }
        public DateTime? DateReceived { get; set; }
        public string Subject { get; set; }
        public string SentTo { get; set; }
        public string SentFrom { get; set; }
        public decimal? NumAttachment { get; set; }
        public decimal? MailSize { get; set; }
        public string SentToMail { get; set; }
        public string SentFromMail { get; set; }
        public byte[] MailFile { get; set; }
        public Guid? SaleprojectObjNo { get; set; }
        public string CustomerNode { get; set; }
    }
}
