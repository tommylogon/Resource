using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Resource.Models;

namespace Resource.Pages.test
{
    public class panelModel : PageModel
    {
        private ResourceContext _context;

        public panelModel(ResourceContext context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get; set; }
        public string SearchString { get; set; }
        public string SelectedName { get; set; }

        public async Task OnGetAsync(string searchString)
        {
            var customers = from c in _context.Customer
                            select c;

            if (!String.IsNullOrEmpty(searchString))
            {
                customers = customers.Where(s => s.CustomerName.Contains(searchString));
            }

            //Customer = await customers.ToListAsync();
            SearchString = searchString;
        }
    }
}