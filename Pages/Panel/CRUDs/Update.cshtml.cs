using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Resource.Models;

namespace Resource.Pages.Panel.CRUDs
{
    public class UpdateModel : PageModel
    {
        public List<Tuple<int, List<string>, List<string>>> Row;
        public int IndexOfID = 0;
        public string TablePath { get; set; }
        public string Table { get; set; }

        public void OnGet(string table, string id)
        {
            Table = table;

            TablePath = table + "s";

            DataAccessLayer dataAccess = new DataAccessLayer();

            Row = new List<Tuple<int, List<string>, List<string>>>(dataAccess.GetDB_Data(String.Format("SELECT * FROM {0} WHERE OBJ_NO = '{1}'", table, id)));
        }
    }
}