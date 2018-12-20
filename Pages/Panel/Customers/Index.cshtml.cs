using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Resource.Models;

namespace Resource.Pages.Panel.Customers
{
    public class IndexModel : PageModel
    {
        private readonly Resource.Models.EvaticContext _context;

        public IndexModel(Resource.Models.EvaticContext context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get; set; }

        public async Task OnGetAsync()
        {
            Customer = await _context.Customer
                .Include(c => c.CompanyNavigation)
                .Include(c => c.CreditTermNavigation)
                .Include(c => c.Department)
                .Include(c => c.SalesmanObjNoNavigation).ToListAsync();
        }
    }
}