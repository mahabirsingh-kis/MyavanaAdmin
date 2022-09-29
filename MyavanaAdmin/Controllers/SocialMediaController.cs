using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using DataTables.AspNetCore.Mvc.Binder;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MyavanaAdmin.Factory;
using MyavanaAdmin.Models;
using MyavanaAdmin.Utility;
using MyavanaAdminModels;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MyavanaAdmin.Controllers
{
    [Authorize(AuthenticationSchemes = "AdminCookies")]
    public class SocialMediaController : Controller
    {
        private readonly AppSettingsModel apiSettings;
        public SocialMediaController(IOptions<AppSettingsModel> app)
        {
            ApplicationSettings.WebApiUrl = "https://api.myavana.com/"; // app.Value.WebApiBaseUrl http://localhost:5004/api/;
        }

        public IActionResult EducationalVideos()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> ViewSocialMedia([DataTablesRequest] DataTablesRequest dataRequest)
        {
            IEnumerable<MediaLinkEntityModel> lstVideos = await MyavanaAdminApiClientFactory.Instance.GetEducationalVideos();
            if (dataRequest.Orders.Any())
            {
                int sortColumnIndex = dataRequest.Orders.FirstOrDefault().Column;
                string sortDirection = dataRequest.Orders.FirstOrDefault().Dir;
                Func<MediaLinkEntityModel, string> orderingFunctionString = null;
                switch (sortColumnIndex)
                {
                    case 0:
                        {
                            orderingFunctionString = (c => c.VideoId);
                            lstVideos =
                                sortDirection == "asc"
                                    ? lstVideos.OrderBy(orderingFunctionString)
                                    : lstVideos.OrderByDescending(orderingFunctionString);
                            break;
                        }
                    case 1:
                        {
                            orderingFunctionString = (c => c.Description);
                            lstVideos =
                                sortDirection == "asc"
                                    ? lstVideos.OrderBy(orderingFunctionString)
                                    : lstVideos.OrderByDescending(orderingFunctionString);
                            break;
                        }
                    case 2:
                        {
                            orderingFunctionString = (c => c.Title);
                            lstVideos =
                                sortDirection == "asc"
                                    ? lstVideos.OrderBy(orderingFunctionString)
                                    : lstVideos.OrderByDescending(orderingFunctionString);
                            break;
                        }
                }
            }
            try
            {
                IEnumerable<MediaLinkEntityModel> codes = lstVideos.Select(e => new MediaLinkEntityModel
                {
                    Id = e.Id,
                    VideoId = e.VideoId,
                    Description = e.Description,
                    Title = e.Title,
                    ImageLink = e.ImageLink,
                    Header = e.Header,
                    IsFeatured = e.IsFeatured,
                    IsActive = e.IsActive
                }).OrderByDescending(x => x.CreatedOn);
                return Json(codes.ToDataTablesResponse(dataRequest, codes.Count()));

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<IActionResult> CreateVideo(string id)
        {
            if (id != null)
            {
                MediaLinkEntityModel mediaLinkEntity = new MediaLinkEntityModel();
                mediaLinkEntity.Id = new Guid(id);
                var response = await MyavanaAdminApiClientFactory.Instance.GetMediaById(mediaLinkEntity);
                mediaLinkEntity = response.Data;
                return View(mediaLinkEntity);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateVideo(MediaLinkEntityModel mediaLinkEntity)
        {
            if(mediaLinkEntity.ImageLink != null && mediaLinkEntity.ImageLink.Contains("instagram"))
            {
                mediaLinkEntity.ImageLink = await VideoThumbnail(mediaLinkEntity.ImageLink);
            }
            mediaLinkEntity.VideoCategoryId = Convert.ToInt32(mediaLinkEntity.CategoryId);
            var response = await MyavanaAdminApiClientFactory.Instance.SaveMediaLink(mediaLinkEntity);

            if (response.message == "Success")
                return Content("1");
            else
                return Content("0");
        }
        public async Task<string> VideoThumbnail(string videourl)
        {
            string customThumbNail = RandomNumbers() + ".jpg";

            try
            {
                HttpClient _httpClient = new HttpClient();
                var requestUrl = _httpClient.GetAsync(videourl).Result;
                var data = await requestUrl.Content.ReadAsStringAsync();
                dynamic result = JObject.Parse(data);
                var js = JsonConvert.SerializeObject(result);
                Console.Write("between : " + js);
                Root root = JsonConvert.DeserializeObject<Root>(js);
                var image = root.graphql.shortcode_media.thumbnail_src;
                WebClient webClient = new WebClient();
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Thumbnails", customThumbNail);
                webClient.DownloadFile(image, path);
                webClient.Dispose();
                _httpClient.Dispose();
            }
            catch (Exception ex)
            {
                Console.Write("Error : " + ex.Message);
                return null;
            }
            string url = "http://admin.myavana.com/Thumbnails/" + customThumbNail;
            return url;
        }

        Random _random = new Random();
        public int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }
        public string RandomString(int size, bool lowerCase = false)
        {
            var builder = new StringBuilder(size);
            char offset = lowerCase ? 'a' : 'A';
            const int lettersOffset = 26; // A...Z or a..z: length=26  
            
            for (var i = 0; i < size; i++)
            {
                var @char = (char)_random.Next(offset, offset + lettersOffset);
                builder.Append(@char);
            }

            return lowerCase ? builder.ToString().ToLower() : builder.ToString();
        }

        public string RandomNumbers()
        {
            var passwordBuilder = new StringBuilder();

            // 4-Letters lower case   
            passwordBuilder.Append(RandomString(4, true));

            // 4-Digits between 1000 and 9999  
            passwordBuilder.Append(RandomNumber(1000, 9999));

            // 2-Letters upper case  
            passwordBuilder.Append(RandomString(2));
            return passwordBuilder.ToString();
        }

        [HttpPost]
        public async Task<IActionResult> DeleteVideo(MediaLinkEntityModel mediaLinkEntity)
        {
            var response = await MyavanaAdminApiClientFactory.Instance.DeleteVideo(mediaLinkEntity);

            if (response.message == "Success")
                return Content("1");
            else
                return Content("0");

        }

       public  class Thumbnail
        {
            public string videourl { get; set; }
        }
       
    }
}
