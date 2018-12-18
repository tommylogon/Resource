using System;
using System.Collections.Generic;

namespace Resource.Models
{
    public partial class CheckList
    {
        public CheckList()
        {
            ProjectTaskCheckList = new HashSet<ProjectTaskCheckList>();
            ProjectTaskCheckListAuto = new HashSet<ProjectTaskCheckListAuto>();
            TempOldCheckListValues = new HashSet<TempOldCheckListValues>();
        }

        public string Company { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string DocType { get; set; }
        public string DocName { get; set; }
        public byte[] DocImage { get; set; }
        public string DocGenerateName { get; set; }
        public string DefaultPrint { get; set; }
        public string Sql { get; set; }
        public string SendWithServiceReport { get; set; }
        public string CheckListVersion { get; set; }

        public Company CompanyNavigation { get; set; }
        public ICollection<ProjectTaskCheckList> ProjectTaskCheckList { get; set; }
        public ICollection<ProjectTaskCheckListAuto> ProjectTaskCheckListAuto { get; set; }
        public ICollection<TempOldCheckListValues> TempOldCheckListValues { get; set; }
    }
}
