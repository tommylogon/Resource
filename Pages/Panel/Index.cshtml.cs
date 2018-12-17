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
        public string SearchString { get; set; }
        public string SelectedName { get; set; }

        public async Task OnGetAsync(string searchString)
        {
        }
    }
}