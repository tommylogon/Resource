using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class TechnicianGpsCoordinates
    {
        public Guid TechnicianObjNo { get; set; }
        public DateTime ObjDate { get; set; }
        public decimal? CoordX { get; set; }
        public decimal? CoordY { get; set; }
    }
}
