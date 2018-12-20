using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Resource.Models;

namespace Resource.Pages.Panel.Machines
{
    public class DeleteModel : PageModel
    {
        private readonly Resource.Models.EvaticContext _context;

        public DeleteModel(Resource.Models.EvaticContext context)
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
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Machine = await _context.Machine.FindAsync(id);

            if (Machine != null)
            {
                _context.Machine.Remove(Machine);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
