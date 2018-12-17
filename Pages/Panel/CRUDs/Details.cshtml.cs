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
        public List<Tuple<int, List<string>, List<string>>> Row;
        public string Table { get; set; }
        public string TablePath { get; set; }
        public int IndexOfID = 0;

        public DetailsModel()
        {
        }

        public async Task OnGetAsync(string table, string id)
        {
            Table = table;

            TablePath = Table + "s";

            DataAccessLayer dataAccess = new DataAccessLayer();

            Row = await (dataAccess.GetDB_DataAsync(String.Format("SELECT * FROM {0} WHERE OBJ_NO = '{1}'", table, id)));
        }
    }
}