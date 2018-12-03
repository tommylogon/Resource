using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Resource.Models;

namespace Resource.Pages
{
    public class SettingsModel : PageModel
    {
        public string DataSource { get; set; }
        public string UserID { get; set; }
        public string Password { get; set; }
        public string InitialCatalog { get; set; }

        private readonly IConfiguration _config;

        public void OnGet()
        {
            ViewData["config"] = _config["ConnectionStrings:ResourceContext"];
        }

        public void OnPost()
        {
            if (Request.HasFormContentType)
            {
                DataSource = Request.Form["DataSource"];
                UserID = Request.Form["UserID"];
                Password = Request.Form["Password"];
                InitialCatalog = Request.Form["InitialCatalog"];

                var json = File.ReadAllText("appsettings.json");

                string connectionString = @"Data Source=ITD-K01-Z400\EVATIC;User ID=sa;Password=1414;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                var optionsBuilder = new DbContextOptionsBuilder<ResourceContext>();
                optionsBuilder.UseSqlServer(connectionString, providerOptions => providerOptions.CommandTimeout(60))
                    .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);

                var context = new ResourceContext(optionsBuilder.Options);
                ViewData["config"] = connectionString;
                //Data Source=ITD-K01-Z400\EVATIC;User ID=sa;Password=********;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
                //"Server=(localdb)\\mssqllocaldb;Database=ResourceContext-4d2a4fc2-2152-401b-99c7-9156956e79a2;Trusted_Connection=True;MultipleActiveResultSets=true"
            }
        }

        public SettingsModel(IConfiguration config)
        {
            _config = config;
        }
    }
}