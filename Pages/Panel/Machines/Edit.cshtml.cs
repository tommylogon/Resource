using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Resource.Models;

namespace Resource.Pages.Panel.Machines
{
    public class EditModel : PageModel
    {
        private readonly Resource.Models.EvaticContext _context;

        public EditModel(Resource.Models.EvaticContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Machine Machine { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Machine = await _context.Machine
                .Include(m => m.Address)
                .Include(m => m.CompanyNavigation)
                .Include(m => m.CustomerObjNoNavigation)
                .Include(m => m.Department)
                .Include(m => m.ModelObjNoNavigation).FirstOrDefaultAsync(m => m.ObjNo == id);

            if (Machine == null)
            {
                return NotFound();
            }
           ViewData["CustomerObjNo"] = new SelectList(_context.Address, "SourceObjNo", "AddressStatus");
           ViewData["Company"] = new SelectList(_context.Company, "Company1", "Company1");
           ViewData["CustomerObjNo"] = new SelectList(_context.Customer, "ObjNo", "Company");
           ViewData["Company"] = new SelectList(_context.Department, "Company", "Company");
           ViewData["ModelObjNo"] = new SelectList(_context.Model, "ObjNo", "Company");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Machine).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MachineExists(Machine.ObjNo))
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

        private bool MachineExists(Guid id)
        {
            return _context.Machine.Any(e => e.ObjNo == id);
        }
    }
}
