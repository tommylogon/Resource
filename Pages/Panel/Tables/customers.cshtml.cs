using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Resource.Models;

namespace Resource.Pages.Panel
{
    public class CustomersModel : PageModel
    {
        public int IndexOfCustomerID = 0;

        public List<Tuple<int, List<string>, List<string>>> Row;

        public List<Customer> customers;

        public List<PropertyInfo> properties;

        public string Table = "Customer";

        private readonly EvaticContext _context;

        public CustomersModel(EvaticContext context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get; set; }

        public async Task OnGetAsync()
        {
            Customer = await _context.Customer.ToListAsync();
        }

        //public async Task OnGetAsync(string searchString)
        //{
        //    using (var context = new EvaticContext())
        //    {
        //        customers = context.Customer.ToList();

        //    }

        //    //DataAccessLayer dataAccess = new DataAccessLayer();
        //    //Row = await dataAccess.GetDB_DataAsync("SELECT obj_no, customer_no, Search_Name, Customer_Name, http, E_mail, organization_no, credit_term, credit_limit FROM CUSTOMER");
        //}
    }
}