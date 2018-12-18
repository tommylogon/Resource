using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class Machine
    {
        public Machine()
        {
            Accessories = new HashSet<Accessories>();
            CustomerMachineModelMeterPrice = new HashSet<CustomerMachineModelMeterPrice>();
            MachineOnContract = new HashSet<MachineOnContract>();
            MeterReading = new HashSet<MeterReading>();
            MeterReadingOldValues = new HashSet<MeterReadingOldValues>();
            OrderLine = new HashSet<OrderLine>();
            ProblemMachine = new HashSet<ProblemMachine>();
            ProjectAutoTask = new HashSet<ProjectAutoTask>();
            ProjectTask = new HashSet<ProjectTask>();
            ProjectTaskAuto = new HashSet<ProjectTaskAuto>();
        }

        public Guid ObjNo { get; set; }
        public string Company { get; set; }
        public string MachineNo { get; set; }
        public Guid ModelObjNo { get; set; }
        public string RevNo { get; set; }
        public Guid CustomerObjNo { get; set; }
        public decimal AddressRowNo { get; set; }
        public string Location { get; set; }
        public string PhoneNo { get; set; }
        public string FaxNo { get; set; }
        public DateTime? InstallationDate { get; set; }
        public string Node { get; set; }
        public string Sortgroup1 { get; set; }
        public string Sortgroup2 { get; set; }
        public string Sortgroup3 { get; set; }
        public string Sortgroup4 { get; set; }
        public string Sortgroup5 { get; set; }
        public DateTime? ActiveFrom { get; set; }
        public DateTime? ActiveTo { get; set; }
        public string Status { get; set; }
        public string Information { get; set; }
        public string InvoiceReference { get; set; }
        public decimal? ResponseTime { get; set; }
        public DateTime? ObjDate { get; set; }
        public string Username { get; set; }
        public string Dept { get; set; }
        public string ServicesCode { get; set; }
        public string InactiveText { get; set; }
        public string InstallationNode { get; set; }
        public string InstallationName { get; set; }
        public string InvoiceReferenceManuel { get; set; }
        public string ServiceOrderReference { get; set; }
        public string PackingSlipText { get; set; }
        public Guid? CustomerDelObjNo { get; set; }
        public decimal? AddressDelRowNo { get; set; }
        public string InformationAlwaysOn { get; set; }
        public Guid? TechnicianObjNo { get; set; }
        public Guid? RespCustomerObjNo { get; set; }
        public string RemoteAccessAdr { get; set; }
        public string RemoteAccessType { get; set; }
        public Guid? CustomerInvObjNo { get; set; }
        public decimal? AddressInvRowNo { get; set; }
        public string RelationMaster { get; set; }
        public DateTime? CustomerWarrantyValidTo { get; set; }
        public decimal? IdNo { get; set; }
        public string OldMachineNo { get; set; }
        public string OpenForInvoice { get; set; }

        public Address Address { get; set; }
        public Company CompanyNavigation { get; set; }
        public Customer CustomerObjNoNavigation { get; set; }
        public Department Department { get; set; }
        public Model ModelObjNoNavigation { get; set; }
        public ICollection<Accessories> Accessories { get; set; }
        public ICollection<CustomerMachineModelMeterPrice> CustomerMachineModelMeterPrice { get; set; }
        public ICollection<MachineOnContract> MachineOnContract { get; set; }
        public ICollection<MeterReading> MeterReading { get; set; }
        public ICollection<MeterReadingOldValues> MeterReadingOldValues { get; set; }
        public ICollection<OrderLine> OrderLine { get; set; }
        public ICollection<ProblemMachine> ProblemMachine { get; set; }
        public ICollection<ProjectAutoTask> ProjectAutoTask { get; set; }
        public ICollection<ProjectTask> ProjectTask { get; set; }
        public ICollection<ProjectTaskAuto> ProjectTaskAuto { get; set; }
    }
}
