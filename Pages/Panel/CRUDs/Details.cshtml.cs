using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Resource.Models;

namespace Resource.Pages.Panel.CRUDs
{
    public class DetailsModel : PageModel
    {
        private ResourceContext _context;

        public List<Tuple<int, List<string>, List<string>>> Row;
        public int IndexOfCustomerID = 0;
        public List<string> CustomerNumbers { get; set; } = new List<string>();

        public DetailsModel(ResourceContext context)
        {
            _context = context;
        }

        //public string SearchString { get; set; }
        //public string SelectedName { get; set; }

        public async Task OnGetAsync(string selectedTable)
        {
            DataAccessLayer dataAccess = new DataAccessLayer();
            Row = new List<Tuple<int, List<string>, List<string>>>(dataAccess.GetDB_Data("SELECT * FROM " + selectedTable));

            foreach (Tuple<int, List<string>, List<string>> tuple in Row)
            {
                CustomerNumbers.Add(tuple.Item2[IndexOfCustomerID]);
            }
        }
    }
}