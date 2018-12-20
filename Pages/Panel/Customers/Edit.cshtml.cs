using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Resource.Models;

namespace Resource.Pages.Panel.Customers
{
    public class EditModel : PageModel
    {
        private readonly Resource.Models.EvaticContext _context;

        public EditModel(Resource.Models.EvaticContext context)
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
           ViewData["Company"] = new SelectList(_context.Company, "Company1", "Company1");
           ViewData["CreditTerm"] = new SelectList(_context.CreditTerms, "ObjNo", "Code");
           ViewData["Company"] = new SelectList(_context.Department, "Company", "Company");
           ViewData["SalesmanObjNo"] = new SelectList(_context.Salesman, "ObjNo", "Company");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Customer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomerExists(Customer.ObjNo))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CustomerExists(Guid id)
        {
            return _context.Customer.Any(e => e.ObjNo == id);
        }
    }
}
