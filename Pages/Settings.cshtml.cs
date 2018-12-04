﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Resource.Models;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json.Linq;
using System.Data.SqlClient;

namespace Resource.Pages
{
    public class SettingsModel : PageModel
    {
        public string DataSource { get; set; }
        public string UserID { get; set; }
        public string Password { get; set; }
        public string InitialCatalog { get; set; }
        public Setting Settings { get; set; }
        private IHostingEnvironment _env;
        private IConfiguration _config;

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
                string connectionString = "Data Source=" + DataSource + @"\" + InitialCatalog + ";User ID=" + UserID + ";Password=" + Password + ";Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

                JObject jsonFile = JObject.Parse(System.IO.File.ReadAllText("appsettings.json"));

                Settings = jsonFile.ToObject<Setting>();

                Settings.ConnectionStrings["ResourceContext"] = connectionString;

                JObject newJson = (JObject)JToken.FromObject(Settings);

                using (StreamWriter file = System.IO.File.CreateText("appsettings.json"))
                using (JsonTextWriter writer = new JsonTextWriter(file))
                {
                    writer.Formatting = Formatting.Indented;
                    newJson.WriteTo(writer);
                }

                using (var connection = new SqlConnection(Settings.ConnectionStrings["ResourceContext"]))
                {
                    try
                    {
                        connection.Open();
                    }
                    catch (Exception ex)
                    {
                        ModelState.AddModelError("Error", ex.Message);
                    }
                }

                //Data Source=ITD-K01-Z400\EVATIC;User ID=sa;Password=********;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
                //"Server=(localdb)\\mssqllocaldb;Database=ResourceContext-4d2a4fc2-2152-401b-99c7-9156956e79a2;Trusted_Connection=True;MultipleActiveResultSets=true"
            }
        }

        public SettingsModel(IConfiguration config, IHostingEnvironment env)
        {
            _config = config;
            _env = env;
        }
    }
}