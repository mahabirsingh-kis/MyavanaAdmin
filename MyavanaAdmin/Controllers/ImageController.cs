using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using DataTables.AspNetCore.Mvc.Binder;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using MyavanaAdmin.Factory;
using MyavanaAdmin.Models;
using MyavanaAdmin.Utility;
using MyavanaAdminModels;
using Newtonsoft.Json.Linq;

namespace MyavanaAdmin.Controllers
{
    // [Authorize(AuthenticationSchemes = "AdminCookies")]

    public class ImageController : Controller
    {
        private const string UPLOAD_FOLDER = "wwwroot/imageUpload";
        private const string IMAGE_FOLDER = "wwwroot/groupImage";
        private const string AUDIO_FOLDER = "wwwroot/groupAudio";
        private const string VIDEO_FOLDER = "wwwroot/groupVideo";
        private const string THUMBNAIL_FOLDER = "wwwroot/groupThumbnail";
        private const string PRODUCT_FOLDER = "wwwroot/routineProducts";
        private const string INGREDIENT_FOLDER = "wwwroot/routineIngredients";
        private const string REGIMEN_FOLDER = "wwwroot/routineRegimens";
        private const string ROUTINEIMAGE_FOLDER = "wwwroot/routineProfile";

        public ImageController()
        {
            ApplicationSettings.WebApiUrl = "https://api.myavana.com/"; //     "http://localhost:5004/api/";  //        
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> ImageUpload([FromBody] Imagerequest imagerequest)
        {
            var token = Request.Headers[HeaderNames.Authorization].ToString().Replace("Bearer ", "");

            if (imagerequest.fileData.Length == 0)
                return BadRequest();
            var bytes = Convert.FromBase64String(imagerequest.fileData);

            if (!Directory.Exists(Path.Combine(Environment.CurrentDirectory, UPLOAD_FOLDER)))
            {
                Directory.CreateDirectory(Path.Combine(Environment.CurrentDirectory, UPLOAD_FOLDER));
            }

            string name = Path.Combine(Environment.CurrentDirectory, UPLOAD_FOLDER, DateTimeOffset.UtcNow.ToUnixTimeSeconds().ToString() + ".jpg");
            string imageName = name.Substring(name.LastIndexOf("/") + 1);
            if (bytes.Length > 0)
            {
                using (var stream = new FileStream(name, FileMode.Create))
                {
                    stream.Write(bytes, 0, bytes.Length);
                    stream.Flush();
                }
            }
            fileData file = new fileData();
            file.access_token = token;
            file.ImageURL = imageName;

            var response = await MyavanaAdminApiClientFactory.Instance.ImageUpload(file);
            if (response.message == "Success")
            {
                return Ok(new JsonResult(new Dictionary<string, object>{
                { "access_token" , response.Data.access_token },
                {"user_name",response.Data.user_name },
                {"Email",response.Data.Email },
                {"Name",response.Data.Name },
                {"AccountNo",response.Data.AccountNo },
                {"TwoFactor",response.Data.TwoFactor },
                {"hairType",response.Data.HairType },
                {"imageURL",response.Data.ImageURL } })
                { StatusCode = (int)HttpStatusCode.OK });
            }
            return BadRequest(new JsonResult("Something went wrong!") { StatusCode = (int)HttpStatusCode.BadRequest });
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> CreatePost([FromForm] GroupPost groupPost)
        {
            var token = Request.Headers[HeaderNames.Authorization].ToString().Replace("Bearer ", "");
            string imgName = null, audioName = null, videoName = null, thumbName = null;

            if (groupPost.Image != null)
            {
                imgName = groupPost.Image.FileName;
                if (!Directory.Exists(Path.Combine(Directory.GetCurrentDirectory(), IMAGE_FOLDER)))
                {
                    Directory.CreateDirectory(Path.Combine(Environment.CurrentDirectory, IMAGE_FOLDER));
                }
                var path = Path.Combine(Directory.GetCurrentDirectory(), IMAGE_FOLDER, imgName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await groupPost.Image.CopyToAsync(stream);
                }

            }
            else if (groupPost.Audio != null)
            {
                audioName = groupPost.Audio.FileName;
                if (!Directory.Exists(Path.Combine(Directory.GetCurrentDirectory(), AUDIO_FOLDER)))
                {
                    Directory.CreateDirectory(Path.Combine(Environment.CurrentDirectory, AUDIO_FOLDER));
                }
                var path = Path.Combine(Directory.GetCurrentDirectory(), AUDIO_FOLDER, audioName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await groupPost.Audio.CopyToAsync(stream);
                }

            }
            else if (groupPost.Video != null)
            {
                videoName = groupPost.Video.FileName;
                if (!Directory.Exists(Path.Combine(Directory.GetCurrentDirectory(), VIDEO_FOLDER)))
                {
                    Directory.CreateDirectory(Path.Combine(Environment.CurrentDirectory, VIDEO_FOLDER));
                }
                var path = Path.Combine(Directory.GetCurrentDirectory(), VIDEO_FOLDER, videoName);
                Random generator = new Random();
                String random = generator.Next(0, 1000000).ToString("D6");
                thumbName = random + ".jpeg";
                var thumbPath = Path.Combine(Directory.GetCurrentDirectory(), THUMBNAIL_FOLDER, thumbName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await groupPost.Video.CopyToAsync(stream);

                }

                //try
                //{
                //    string fileargs = "-i " + path + " -ss 00:00:14.435 -vframes 1 " + thumbPath;
                //    Process process = new Process
                //    {
                //        StartInfo = new ProcessStartInfo
                //        {
                //            CreateNoWindow = true,
                //            UseShellExecute = false,
                //            FileName = ffmpegcore
                //            Arguments = fileargs
                //        }
                //    };
                //    process.Start();
                //    process.WaitForExit(10000);
                //}
                //catch(Exception ex)
                //{
                //    return BadRequest(new JsonResult(ex.Message + " " + ex.StackTrace) { StatusCode = (int)HttpStatusCode.BadRequest });
                //}

            }


            string imageUrl = "http://admin.myavana.com/groupImage/" + imgName;
            string audioUrl = "http://admin.myavana.com/groupAudio/" + audioName;
            string videoUrl = "http://admin.myavana.com/groupVideo/" + videoName;
            string thumbNail = "http://admin.myavana.com/groupThumbnail/" + thumbName;
            groupPost.ImageUrl = imgName != null ? imageUrl : null;
            groupPost.AudioUrl = audioName != null ? audioUrl : null;
            groupPost.VideoUrl = videoName != null ? videoUrl : null;
            groupPost.ThumbnailUrl = thumbName != null ? thumbNail : null;
            var handler = new JwtSecurityTokenHandler();
            var tokenS = handler.ReadToken(token) as JwtSecurityToken;

            groupPost.UserEmail = tokenS.Claims.First(claim => claim.Type == "sub").Value;
            try
            {
                var response = await MyavanaAdminApiClientFactory.Instance.CreatePost(groupPost);
                if (response.message == "Success")
                {
                    return Ok(new JsonResult("Post created Successfully") { StatusCode = (int)HttpStatusCode.OK });
                }
            }
            catch (Exception ex)
            {
                var abc = ex.Message;
            }
            return BadRequest(new JsonResult("Something went wrong!") { StatusCode = (int)HttpStatusCode.BadRequest });
        }


        [HttpPost]
        [AllowAnonymous]
        public async
            Task<IActionResult> CreateThumbnail([FromBody] GroupPost groupPost)
        {
            var token = Request.Headers[HeaderNames.Authorization].ToString().Replace("Bearer ", "");
            string thumbName = null;
            if (groupPost.ThumbnailUrl != null)
            {
                var bytes = Convert.FromBase64String(groupPost.ThumbnailUrl);

                if (!Directory.Exists(Path.Combine(Environment.CurrentDirectory, THUMBNAIL_FOLDER)))
                {
                    Directory.CreateDirectory(Path.Combine(Environment.CurrentDirectory, THUMBNAIL_FOLDER));
                }

                string name = Path.Combine(Environment.CurrentDirectory, THUMBNAIL_FOLDER, DateTimeOffset.UtcNow.ToUnixTimeSeconds().ToString() + ".jpg");
                if (bytes.Length > 0)
                {
                    using (var stream = new FileStream(name, FileMode.Create))
                    {
                        stream.Write(bytes, 0, bytes.Length);
                        stream.Flush();
                    }
                }


            }

            string thumbNail = "http://admin.myavana.com/groupThumbnail/" + thumbName;

            groupPost.ThumbnailUrl = thumbName != null ? thumbNail : null;
            var handler = new JwtSecurityTokenHandler();
            var tokenS = handler.ReadToken(token) as JwtSecurityToken;

            groupPost.UserEmail = tokenS.Claims.First(claim => claim.Type == "sub").Value;
            try
            {
                var response = await MyavanaAdminApiClientFactory.Instance.CreatePost(groupPost);
                if (response.message == "Success")
                {
                    return Ok(new JsonResult("THumbnail added Successfully") { StatusCode = (int)HttpStatusCode.OK });
                }
            }
            catch (Exception ex)
            {
                var abc = ex.Message;
            }
            return BadRequest(new JsonResult("Something went wrong!") { StatusCode = (int)HttpStatusCode.BadRequest });
        }

        public Bitmap GetThumbnail(string video, string thumbnail)
        {
            var cmd = "ffmpeg  -itsoffset -1  -i " + '"' + video + '"' + " -vcodec mjpeg -vframes 1 -an -f rawvideo -s 320x240 " + '"' + thumbnail + '"';

            var startInfo = new ProcessStartInfo
            {
                WindowStyle = ProcessWindowStyle.Hidden,
                FileName = "cmd.exe",
                Arguments = "/C " + cmd
            };

            var process = new Process
            {
                StartInfo = startInfo
            };

            process.Start();
            process.WaitForExit(5000);

            //var ms = new MemoryStream(File.ReadAllBytes(thumbnail));
            //return  (Bitmap)Image.FromStream(ms);
            return null; // LoadImage(thumbnail);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> AddSelectedRoutineItems([FromForm] UserRoutineHairCareModel hairRoutine)
        {
            var token = Request.Headers[HeaderNames.Authorization].ToString().Replace("Bearer ", "");
            string imgName, imgUrl = string.Empty;
            Random generator = new Random();
            String random = generator.Next(0, 1000000).ToString("D6");
            string imgExt = Path.GetExtension(hairRoutine.FormImage.FileName);
            imgName = hairRoutine.FormImage.FileName.Substring(0, hairRoutine.FormImage.FileName.IndexOf(".")) + "_" + random + imgExt;

            if (hairRoutine.IsProduct)
            {
                if (!Directory.Exists(Path.Combine(Directory.GetCurrentDirectory(), PRODUCT_FOLDER)))
                {
                    Directory.CreateDirectory(Path.Combine(Environment.CurrentDirectory, PRODUCT_FOLDER));
                }
                var path = Path.Combine(Directory.GetCurrentDirectory(), PRODUCT_FOLDER, imgName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await hairRoutine.FormImage.CopyToAsync(stream);
                    imgUrl = "http://admin.myavana.com/routineProducts/" + imgName;
                }

            }
            else if (hairRoutine.IsIngredient)
            {
                if (!Directory.Exists(Path.Combine(Directory.GetCurrentDirectory(), INGREDIENT_FOLDER)))
                {
                    Directory.CreateDirectory(Path.Combine(Environment.CurrentDirectory, INGREDIENT_FOLDER));
                }
                var path = Path.Combine(Directory.GetCurrentDirectory(), INGREDIENT_FOLDER, imgName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await hairRoutine.FormImage.CopyToAsync(stream);
                    imgUrl = "http://admin.myavana.com/routineIngredients/" + imgName;
                }

            }
            else if (hairRoutine.IsRegimen)
            {
                if (!Directory.Exists(Path.Combine(Directory.GetCurrentDirectory(), REGIMEN_FOLDER)))
                {
                    Directory.CreateDirectory(Path.Combine(Environment.CurrentDirectory, REGIMEN_FOLDER));
                }
                var path = Path.Combine(Directory.GetCurrentDirectory(), REGIMEN_FOLDER, imgName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await hairRoutine.FormImage.CopyToAsync(stream);
                    imgUrl = "http://admin.myavana.com/routineRegimens/" + imgName;
                }

            }

            hairRoutine.Image = imgUrl;
            var handler = new JwtSecurityTokenHandler();
            var tokenS = handler.ReadToken(token) as JwtSecurityToken;

            hairRoutine.UserName = tokenS.Claims.First(claim => claim.Type == "sub").Value;
            try
            {
                hairRoutine.FormImage = null;
                var response = await MyavanaAdminApiClientFactory.Instance.AddSelectedRoutineItems(hairRoutine);
                if (response.message == "Success")
                {
                    return Ok(new JsonResult("Added Successfully") { StatusCode = (int)HttpStatusCode.OK });
                }
            }
            catch (Exception ex)
            {
                var abc = ex.Message;
            }
            return BadRequest(new JsonResult("Something went wrong!") { StatusCode = (int)HttpStatusCode.BadRequest });
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> SaveRoutineProfileImage([FromForm] DailyRoutineTracker dailyRoutine)
        {
            var token = Request.Headers[HeaderNames.Authorization].ToString().Replace("Bearer ", "");
            string imgName = null;

            if (dailyRoutine.Image != null)
            {
                imgName = dailyRoutine.Image.FileName;
                if (!Directory.Exists(Path.Combine(Directory.GetCurrentDirectory(), ROUTINEIMAGE_FOLDER)))
                {
                    Directory.CreateDirectory(Path.Combine(Environment.CurrentDirectory, ROUTINEIMAGE_FOLDER));
                }
                var path = Path.Combine(Directory.GetCurrentDirectory(), ROUTINEIMAGE_FOLDER, imgName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await dailyRoutine.Image.CopyToAsync(stream);
                }

            }

            dailyRoutine.ProfileImage = "http://admin.myavana.com/routineProfile/" + imgName;
            var handler = new JwtSecurityTokenHandler();
            var tokenS = handler.ReadToken(token) as JwtSecurityToken;

            dailyRoutine.UserId = tokenS.Claims.First(claim => claim.Type == "sub").Value;
            try
            {
                var response = await MyavanaAdminApiClientFactory.Instance.AddProfileImage(dailyRoutine);
                if (response.message == "Success")
                {
                    return Ok(new JsonResult("Image added Successfully") { StatusCode = (int)HttpStatusCode.OK, Value = dailyRoutine });
                }
            }
            catch (Exception ex)
            {
                var abc = ex.Message;
            }
            return BadRequest(new JsonResult("Something went wrong!") { StatusCode = (int)HttpStatusCode.BadRequest });
        }

    }


}