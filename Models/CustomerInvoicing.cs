using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class CustomerInvoicing
    {
        public CustomerInvoicing()
        {
            CustomerInvoicingMeterDetails = new HashSet<CustomerInvoicingMeterDetails>();
        }

        public decimal No { get; set; }
        public string Company { get; set; }
        public Guid CustomerObjNo { get; set; }
        public Guid? ContractObjNo { get; set; }
        public decimal? ContractRowNo { get; set; }
        public Guid? MachineObjNo { get; set; }
        public decimal OrderNo { get; set; }
        public Guid? MeterObjNo { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public decimal? FromCounter { get; set; }
        public decimal? ToCounter { get; set; }
        public decimal? Price { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string RowSource { get; set; }
        public decimal? Correction { get; set; }
        public string RowSourcePart { get; set; }
        public decimal? OrderNoContract { get; set; }
        public string SubContractNo { get; set; }
        public decimal? ReadingFrequenceOtherFirst { get; set; }
        public string UseNextPeriod { get; set; }
        public decimal? OrginalRowPeriodicVolume { get; set; }
        public decimal? OrginalRowPeriodicHiddenVolume { get; set; }
        public string MrSubContractNo { get; set; }
        public Guid? SourceObjNo { get; set; }
        public decimal? OrginalPeriodicVolume { get; set; }
        public decimal? OrginalVolumeOfTotal { get; set; }
        public decimal? InvoiceReadingFrequence { get; set; }
        public decimal? UsedUnits { get; set; }
        public decimal? PlussUnits { get; set; }
        public DateTime? InvoiceRangeFrom { get; set; }
        public DateTime? InvoiceRangeTo { get; set; }
        public decimal? PricePerUnitOrMonth { get; set; }
        public decimal? Discount { get; set; }
        public decimal? CostPrice { get; set; }
        public decimal? InvoicedSum { get; set; }

        public ICollection<CustomerInvoicingMeterDetails> CustomerInvoicingMeterDetails { get; set; }
    }
}
