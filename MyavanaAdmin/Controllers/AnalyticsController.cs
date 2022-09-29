using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using DataTables.AspNetCore.Mvc.Binder;
using ExcelDataReader;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MyavanaAdmin.Factory;
using MyavanaAdmin.Models;
using MyavanaAdmin.Utility;
using MyavanaAdminModels;

namespace MyavanaAdmin.Controllers
{
    [Authorize(AuthenticationSchemes = "AdminCookies")]
    public class AnalyticsController : Controller
    {
        private readonly AppSettingsModel apiSettings;
        public AnalyticsController(IOptions<AppSettingsModel> app)
        {
            ApplicationSettings.WebApiUrl = "https://api.myavana.com/"; // app.Value.WebApiBaseUrl http://localhost:5004/api/;
        }

        public IActionResult Analytics()
        {
            return View();
        }
    }
}
