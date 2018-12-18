using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class VolumeHistory
    {
        public Guid CmdObjNo { get; set; }
        public DateTime DateChanged { get; set; }
        public decimal Volume { get; set; }
    }
}
