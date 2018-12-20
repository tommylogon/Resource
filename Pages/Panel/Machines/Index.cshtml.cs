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
    public class IndexModel : PageModel
    {
        private readonly Resource.Models.EvaticContext _context;

        public IndexModel(Resource.Models.EvaticContext context)
        {
            _context = context;
        }

        public IList<Machine> Machine { get;set; }

        public async Task OnGetAsync()
        {
            Machine = await _context.Machine
                .Include(m => m.Address)
                .Include(m => m.CompanyNavigation)
                .Include(m => m.CustomerObjNoNavigation)
                .Include(m => m.Department)
                .Include(m => m.ModelObjNoNavigation).ToListAsync();
        }
    }
}
