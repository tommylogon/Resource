using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Resource.Models;

namespace Resource.Pages.Panel.CRUDs.Customers
{
    public class CreateModel : PageModel
    {
        private readonly Resource.Models.EvaticContext _context;

        public CreateModel(Resource.Models.EvaticContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["Company"] = new SelectList(_context.Company, "Company1", "Company1");
        ViewData["CreditTerm"] = new SelectList(_context.CreditTerms, "ObjNo", "Code");
        ViewData["Company"] = new SelectList(_context.Department, "Company", "Company");
        ViewData["SalesmanObjNo"] = new SelectList(_context.Salesman, "ObjNo", "Company");
            return Page();
        }

        [BindProperty]
        public Customer Customer { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Customer.Add(Customer);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}