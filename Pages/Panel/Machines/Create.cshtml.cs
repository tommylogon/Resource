using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Resource.Models;

namespace Resource.Pages.Panel.Machines
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
        ViewData["CustomerObjNo"] = new SelectList(_context.Address, "SourceObjNo", "AddressStatus");
        ViewData["Company"] = new SelectList(_context.Company, "Company1", "Company1");
        ViewData["CustomerObjNo"] = new SelectList(_context.Customer, "ObjNo", "Company");
        ViewData["Company"] = new SelectList(_context.Department, "Company", "Company");
        ViewData["ModelObjNo"] = new SelectList(_context.Model, "ObjNo", "Company");
            return Page();
        }

        [BindProperty]
        public Machine Machine { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Machine.Add(Machine);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}