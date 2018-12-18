using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class MailAutoServer
    {
        public Guid ObjNo { get; set; }
        public string Status { get; set; }
        public Guid? SourceObjNo { get; set; }
        public DateTime MailDate { get; set; }
        public DateTime? MailSentDate { get; set; }
        public string Subject { get; set; }
        public string To { get; set; }
        public string FromName { get; set; }
        public string FromAddress { get; set; }
        public string Cc { get; set; }
        public string Bcc { get; set; }
        public decimal? NumAttachment { get; set; }
        public DateTime ObjDate { get; set; }
        public string Username { get; set; }
        public string InternalInfoField { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
    }
}
