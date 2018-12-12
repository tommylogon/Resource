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
        private ResourceContext _context;

        public List<string> ColumbNames { get; set; } = new List<string>();

        public List<string> ColumbValues { get; set; } = new List<string>();

        public List<Tuple<int, List<string>, List<string>>> Row;

        public MachinesModel(ResourceContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync(string searchString)
        {
            DataAccessLayer dataAccess = new DataAccessLayer();
            Row = dataAccess.GetDB_Data("SELECT obj_no, Machine_no, Customer_obj_no, Location, phone_no, installation_date, sortgroup_1, sortgroup_2, active_from, active_to, obj_date FROM MACHINE");
        }
    }
}