using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class ModelMeter
    {
        public ModelMeter()
        {
            ModelVirtualMeterDependenciesM = new HashSet<ModelVirtualMeterDependencies>();
            ModelVirtualMeterDependenciesModelMeter = new HashSet<ModelVirtualMeterDependencies>();
        }

        public Guid ModelObjNo { get; set; }
        public Guid MeterObjNo { get; set; }
        public string VirtualFunction { get; set; }
        public decimal? NumberOfCiphers { get; set; }
        public decimal? PpuLevel1 { get; set; }
        public decimal? PpuLevel2 { get; set; }
        public decimal? PpuLevel3 { get; set; }
        public decimal? Ppeu { get; set; }
        public decimal? No { get; set; }
        public decimal? TargetPpu { get; set; }
        public decimal? TargetVolume { get; set; }
        public decimal? FixedPpu { get; set; }
        public string UseInCalc { get; set; }
        public decimal? MaxCounter { get; set; }

        public Meter MeterObjNoNavigation { get; set; }
        public Model ModelObjNoNavigation { get; set; }
        public ICollection<ModelVirtualMeterDependencies> ModelVirtualMeterDependenciesM { get; set; }
        public ICollection<ModelVirtualMeterDependencies> ModelVirtualMeterDependenciesModelMeter { get; set; }
    }
}
