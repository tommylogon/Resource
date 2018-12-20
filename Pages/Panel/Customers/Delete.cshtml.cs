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
    public class DeleteModel : PageModel
    {
        private readonly Resource.Models.EvaticContext _context;

        public DeleteModel(Resource.Models.EvaticContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Customer Customer { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Customer = await _context.Customer
                .Include(c => c.CompanyNavigation)
                .Include(c => c.CreditTermNavigation)
                .Include(c => c.Department)
                .Include(c => c.SalesmanObjNoNavigation).FirstOrDefaultAsync(m => m.ObjNo == id);

            if (Customer == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Customer = await _context.Customer.FindAsync(id);

            if (Customer != null)
            {
                _context.Customer.Remove(Customer);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
