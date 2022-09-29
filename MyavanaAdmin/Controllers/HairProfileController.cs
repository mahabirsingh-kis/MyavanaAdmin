using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyavanaAdmin.Factory;
using MyavanaAdminModels;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MyavanaAdmin.Controllers
{
	[Authorize(AuthenticationSchemes = "AdminCookies")]
	public class HairProfileController : Controller
    {
        public IActionResult HairProfiles()
        {
            return View();
        }

		public async Task<IActionResult> CustomerHairProfile(string id)
		{
			HairProfileCustomerModel hairProfileModel = new HairProfileCustomerModel();
			hairProfileModel.UserId = id;

			if (hairProfileModel != null)
			{
				var response = await MyavanaAdminApiClientFactory.Instance.GetHairProfileCustomer(hairProfileModel);
				if (!String.IsNullOrEmpty(response.Data.AIResult))
				{
					var result = JsonConvert.DeserializeObject<dynamic>(response.Data.AIResult.ToString());
					var pn = (object)result["item2"];
					response.Data.AIResultDecoded = (JObject)pn;
				}
				return View(response.Data);
			}
			return Content("0");
		}

		[AllowAnonymous]
		public ActionResult MediaVideo(string video)
        {
			ViewBag.video = video;
			return View();
        }
	}
}