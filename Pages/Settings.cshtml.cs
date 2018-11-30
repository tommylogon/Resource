﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
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
        }

        public void OnPost()
        {
            if (Request.HasFormContentType)
            {
                DataSource = Request.Form["DataSource"];
                UserID = Request.Form["UserID"];
                Password = Request.Form["Password"];
                InitialCatalog = Request.Form["InitialCatalog"];
            }
        }

        public SettingsModel(IConfiguration config)
        {
            _config = config;
        }
    }
}