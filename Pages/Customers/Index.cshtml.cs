using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Resource.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resource.Pages.Customers
{
    public class IndexModel : PageModel
    {
        private readonly Resource.Models.ResourceContext _context;

        public IndexModel(Resource.Models.ResourceContext context)
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

            Customer = await customers.ToListAsync();
            SearchString = searchString;
        }
    }
}