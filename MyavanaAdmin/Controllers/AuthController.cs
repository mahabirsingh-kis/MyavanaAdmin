using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using DataTables.AspNetCore.Mvc.Binder;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyavanaAdmin.Factory;
using MyavanaAdmin.Models;
using MyavanaAdmin.Utility;
using MyavanaAdminModels;

namespace MyavanaAdmin.Controllers
{
    [Authorize(AuthenticationSchemes = "AdminCookies")]

    public class AuthController : Controller
    {
        private readonly AppSettingsModel apiSettings;

        public AuthController()
        {
            //ApplicationSettings.WebApiUrl = "https://api.myavana.com/"; // "http://localhost:5004/api/";  // 
            ApplicationSettings.WebApiUrl = "http://localhost:5004/api/";
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(WebLogin webLogin)
        {
            if (webLogin.UserEmail != null && webLogin.Password != null)
            {
                var result = await MyavanaAdminApiClientFactory.Instance.Login(webLogin);
                if (result.Data != null)
                {
                    if (result.Data.UserId != 0 && result.Data.IsActive == true)
                    {

                        var claims = new List<Claim>
                        {
                            new Claim(ClaimTypes.Name, result.Data.UserEmail),
                            new Claim(ClaimTypes.Role, result.Data.UserType.ToString())
                        };

                        CookieOptions option = new CookieOptions();


                        Response.Cookies.Append("UserType", result.Data.UserType.ToString(), option);

                        var claimsIdentity = new ClaimsIdentity(
                          claims, CookieAuthenticationDefaults.AuthenticationScheme);
                        var authProperties = new AuthenticationProperties();

                        await HttpContext.SignInAsync("AdminCookies",
                            new ClaimsPrincipal(claimsIdentity),
                            authProperties);
                        if (result.Data.UserType.ToString() == "True")
                        {
                            return Content("1");
                        }
                        else
                        {
                            return Content("2");
                        }
                    }
                }
                return Content("0");
            }
            return Content("0");
        }

        [HttpGet]
        public async Task<bool> Logout()
        {
            Response.Cookies.Delete("AdminCookies");
            return true;
        }

        public IActionResult Users()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetUsersList([DataTablesRequest] DataTablesRequest dataRequest)
        {
            IEnumerable<WebLogin> filterUsers = await MyavanaAdminApiClientFactory.Instance.GetUsers();
            filterUsers = filterUsers.Where(x => x.UserType.ToString() == Request.Cookies["UserType"].ToString());
            if (dataRequest.Orders.Any())
            {
                int sortColumnIndex = dataRequest.Orders.FirstOrDefault().Column;
                string sortDirection = dataRequest.Orders.FirstOrDefault().Dir;
                Func<WebLogin, string> orderingFunctionString = null;
                switch (sortColumnIndex)
                {
                    case 0:
                        {
                            orderingFunctionString = (c => c.UserEmail);
                            filterUsers =
                                sortDirection == "asc"
                                    ? filterUsers.OrderBy(orderingFunctionString)
                                    : filterUsers.OrderByDescending(orderingFunctionString);
                            break;
                        }
                    case 1:
                        {
                            orderingFunctionString = (c => c.Password);
                            filterUsers =
                                sortDirection == "asc"
                                    ? filterUsers.OrderBy(orderingFunctionString)
                                    : filterUsers.OrderByDescending(orderingFunctionString);
                            break;
                        }
                }
            }
            try
            {
                IEnumerable<WebLogin> codes = filterUsers.Select(e => new WebLogin
                {
                    UserId = e.UserId,
                    UserEmail = e.UserEmail,
                    Password = e.Password,
                    CreatedOn = e.CreatedOn,
                    CreatedBy = e.CreatedBy,
                    IsActive = e.IsActive
                }).OrderByDescending(x => x.CreatedOn);
                return Json(codes.ToDataTablesResponse(dataRequest, codes.Count()));

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            IEnumerable<WebLogin> filterUser = await MyavanaAdminApiClientFactory.Instance.GetUsers();
            return Json(filterUser);
        }

        public async Task<IActionResult> CreateNewUser(string id)
        {
            if (id != null)
            {
                WebLogin webLogin = new WebLogin();
                webLogin.UserId = Convert.ToInt32(id);
                webLogin.UserType = Request.Cookies["UserType"].ToString() == "True" ? true : false;
                var response = await MyavanaAdminApiClientFactory.Instance.GetUserById(webLogin);
                webLogin = response.Data;
                return View(webLogin);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateNewUser(WebLogin webLogin)
        {
            webLogin.UserType = Request.Cookies["UserType"].ToString() == "True" ? true : false;
            var response = await MyavanaAdminApiClientFactory.Instance.CreateNewUser(webLogin);

            if (response.message == "Success")
                return Content("1");
            else
                return Content("0");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteUser(WebLogin webLogin)
        {
            var response = await MyavanaAdminApiClientFactory.Instance.DeleteUser(webLogin);

            if (response.message == "Success")
                return Content("1");
            else
                return Content("0");

        }
    }
}
