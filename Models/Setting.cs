using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resource.Models
{
    public class Setting
    {
        public string AllowedHosts { get; set; }
        public Dictionary<string, string> ConnectionStrings { get; set; }
        public Logging logging { get; set; }

        public class Logging
        {
            public static Dictionary<string, string> LogLevel { get; set; }
        }
    }
}