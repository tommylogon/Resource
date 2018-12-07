using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Resource.Models;

namespace Resource.Pages.Panel
{
    public class CustomersModel : PageModel
    {
        private ResourceContext _context;

        public CustomersModel(ResourceContext context)
        {
            _context = context;
        }

        private int rowNumber = 0;

        public IList<Customer> Customer { get; set; }

        public List<string> ColumbNames { get; set; } = new List<string>();

        public List<string> ColumbValues { get; set; } = new List<string>();

        public List<Tuple<int, List<string>>> Row { get; set; } = new List<Tuple<int, List<string>>>();

        //public string SearchString { get; set; }
        //public string SelectedName { get; set; }

        public async Task OnGetAsync(string searchString)
        {
            Program.ReadJSONConfig();
            string connString = Program.Settings.ConnectionStrings["ResourceContext"];
            using (SqlConnection connection = new SqlConnection("Server= ITD-K01-Z400\\EVATIC; Database=Evatic; User ID = sa; Password = 1414; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False"))
            {
                connection.Open();

                SqlCommand querry = new SqlCommand("SELECT * FROM MACHINE", connection);

                using (SqlDataReader reader = querry.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ColumbNames = new List<string>();

                        ColumbValues = new List<string>();

                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            if (ColumbNames.Count != reader.FieldCount)
                            {
                                ColumbNames.Add(reader.GetName(i));
                            }

                            ColumbValues.Add(reader.GetValue(i).ToString());
                        }

                        Row.Add(new Tuple<int, List<string>>(rowNumber, ColumbValues));

                        rowNumber++;
                    }
                    reader.Close();
                }

                connection.Close();
            }

            //var customers = from c in _context.Customer
            //                select c;

            //if (!String.IsNullOrEmpty(searchString))
            //{
            //    customers = customers.Where(s => s.CustomerName.Contains(searchString));
            //}

            //Customer = await customers.ToListAsync();
            //SearchString = searchString;
        }
    }
}