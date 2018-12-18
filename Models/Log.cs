using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class Log
    {
        public int Logid { get; set; }
        public int? Eventid { get; set; }
        public string Category { get; set; }
        public int Priority { get; set; }
        public string Severity { get; set; }
        public string Title { get; set; }
        public DateTime Timestamp { get; set; }
        public string Machinename { get; set; }
        public string Appdomainname { get; set; }
        public string Processid { get; set; }
        public string Processname { get; set; }
        public string Threadname { get; set; }
        public string Win32threadid { get; set; }
        public string Message { get; set; }
        public string Formattedmessage { get; set; }
    }
}
