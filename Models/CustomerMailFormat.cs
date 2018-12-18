using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class CustomerMailFormat
    {
        public Guid CustomerObjNo { get; set; }
        public string Type { get; set; }
        public string SendSms { get; set; }
        public string SendEmail { get; set; }
        public string SmsFormat { get; set; }
        public string EmailFormat { get; set; }
        public string SendAutomatically { get; set; }

        public Customer CustomerObjNoNavigation { get; set; }
    }
}
