using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class Mail
    {
        public Guid ObjNo { get; set; }
        public Guid SourceObjNo { get; set; }
        public DateTime MailDate { get; set; }
        public string Subject { get; set; }
        public string To { get; set; }
        public string From { get; set; }
        public string Cc { get; set; }
        public string Bcc { get; set; }
        public decimal? NumAttachment { get; set; }
        public string CustomerNode { get; set; }
        public DateTime ObjDate { get; set; }
        public string Username { get; set; }
        public string MailType { get; set; }
        public string MailText { get; set; }
    }
}
