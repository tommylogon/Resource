using System.Collections.Generic;

namespace Resource.Models
{
    public class Setting
    {
        public string AllowedHosts { get; set; }
        public Dictionary<string, string> ConnectionStrings { get; set; }
        public Loggings Logging { get; set; }

        public class Loggings
        {
            public static Dictionary<string, string> LogLevel { get; set; }
        }
    }
}