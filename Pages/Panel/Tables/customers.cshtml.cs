using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Resource.Models;

namespace Resource.Pages.Panel
{
    public class CustomersModel : PageModel
    {
        public string Table = "Customer";
        private readonly Resource.Models.EvaticContext _context;

        public CustomersModel(EvaticContext context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get; set; }

        public async Task OnGetAsync()
        {
            using (_context)
            {
                Customer = await _context.Customer.ToListAsync();
            }
        }

        public void Dispose()
        {
            GC.Collect();
        }
    }
}