using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Resource.Models;

namespace Resource.Pages.Panel
{
    public class CustomersModel : PageModel
    {
        private ResourceContext _context;

        public CustomersModel(ResourceContext context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get; set; }

        public List<string> ColumbNames { get; set; } = new List<string>();

        public List<string> ColumbValues { get; set; } = new List<string>();

        public List<Tuple<int, List<string>>> Row;

        //public string SearchString { get; set; }
        //public string SelectedName { get; set; }

        public async Task OnGetAsync(string searchString)
        {
            DataAccessLayer dataAccess = new DataAccessLayer();
            Row = dataAccess.GetDB_Data("CUSTOMER", "*");

            //var customers = from c in _context.Customer
            //                select c;

            //if (!String.IsNullOrEmpty(searchString))
            //{
            //    customers = customers.Where(s => s.CustomerName.Contains(searchString));
            //}

            //Customer = await customers.ToListAsync();
            //SearchString = searchString;
        }
    }
}