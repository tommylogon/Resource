using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Resource.Models;

namespace Resource.Pages.Panel
{
    public class MachinesModel : PageModel
    {
        public List<Tuple<int, List<string>, List<string>>> Row;
        public string Table = "Machine";
        public int IndexOfMachineID = 0;

        public async Task OnGetAsync(string searchString)
        {
            DataAccessLayer dataAccess = new DataAccessLayer();
            Row = dataAccess.GetDB_Data("SELECT obj_no, Machine_no, Customer_obj_no, Location, phone_no, installation_date, sortgroup_1, sortgroup_2, active_from, active_to, obj_date FROM MACHINE");
        }
    }
}