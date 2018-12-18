using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class SaleMailconfig
    {
        public string Owner { get; set; }
        public string ReplyAdress { get; set; }
        public bool? AllFolders { get; set; }
        public string SeekFolders { get; set; }
        public string Pop3Server { get; set; }
        public string SmtpServer { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public decimal? MailSystem { get; set; }
        public string Mail2 { get; set; }
        public bool? UseDialup { get; set; }
        public string DialupName { get; set; }
        public DateTime? LastUpdated { get; set; }
    }
}
