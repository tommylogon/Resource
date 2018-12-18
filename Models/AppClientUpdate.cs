using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class AppClientUpdate
    {
        public string SetupProgram { get; set; }
        public string SetupFilename { get; set; }
        public byte[] SetupFile { get; set; }
        public string Status { get; set; }
        public DateTime? StatusChangeDate { get; set; }
    }
}
