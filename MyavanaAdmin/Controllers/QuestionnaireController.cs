using DataTables.AspNetCore.Mvc.Binder;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using MyavanaAdmin.Factory;
using MyavanaAdmin.Models;
using MyavanaAdmin.Utility;
using MyavanaAdminModels;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MyavanaAdmin.Controllers
{
    [Authorize(AuthenticationSchemes = "AdminCookies")]
    public class QuestionnaireController : Controller
    {
        private readonly AppSettingsModel apiSettings;
        public IConfiguration configuration;
        private readonly HttpClient _httpClient;
        public QuestionnaireController(IOptions<AppSettingsModel> app, IConfiguration _configuration)
        {
            ApplicationSettings.WebApiUrl = "https://api.myavana.com/"; //"https://api.myavana.com/"; "http://localhost:5004/api/";//"https://api.myavana.com/";// app.Value.WebApiBaseUrl; //
            //ApplicationSettings.WebApiUrl = "http://localhost:5004/api/";
            configuration = _configuration;
            _httpClient = new HttpClient();
        }

        public IActionResult Questionnaire()
        {
            return View();
        }


        public async Task<IActionResult> AddHairProfile(string id, string name)
        {
            HairProfile hair = new HairProfile();

            if (id != null)
            {
                hair.UserEmail = id.Trim();
                hair.UserId = name;
                hair.FirstName = name.Substring(0, name.IndexOf(" "));
            }
            return View(hair);
        }

        [HttpPost]
        public async Task<IActionResult> GetQuestionaireAnswer(QuestionaireSelectedAnswer hairProfileModel)
        {

            if (hairProfileModel.UserId != null)
            {
                hairProfileModel.UserEmail = hairProfileModel.UserId.Trim();
                var response = await MyavanaAdminApiClientFactory.Instance.GetQuestionaireAnswer(hairProfileModel);
                if (response.message == "Success")
                {
                    return Json(response.Data);
                }
            }
            return null;
        }

        public async Task<IActionResult> SaveProfile(HairProfile hairProfile)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri(ApplicationSettings.WebApiUrl);
                    //client.BaseAddress = new Uri("http://localhost:5004/api/");
                    MultipartFormDataContent multiContent = new MultipartFormDataContent();

                    if (hairProfile.TopLeftPhoto != null)
                    {
                        multiContent.Add(new StringContent(hairProfile.TopLeftPhoto), "TopLeftPhoto");
                    }

                    if (hairProfile.TopRightPhoto != null)
                    {
                        multiContent.Add(new StringContent(hairProfile.TopRightPhoto), "TopRightPhoto");
                    }

                    if (hairProfile.BottomLeftPhoto != null)
                    {
                        multiContent.Add(new StringContent(hairProfile.BottomLeftPhoto), "BottomLeftPhoto");
                    }

                    if (hairProfile.BottomRightPhoto != null)
                    {
                        multiContent.Add(new StringContent(hairProfile.BottomRightPhoto), "BottomRightPhoto");
                    }

                    if (hairProfile.CrownPhoto != null)
                    {
                        multiContent.Add(new StringContent(hairProfile.CrownPhoto), "CrownPhoto");
                    }

                    multiContent.Add(new StringContent(hairProfile.UserId.ToString()), "UserId");
                    if (hairProfile.HairId != null)
                        multiContent.Add(new StringContent(hairProfile.HairId.ToString()), "HairId");
                    if (hairProfile.ConsultantNotes != null)
                        multiContent.Add(new StringContent(hairProfile.ConsultantNotes.ToString()), "ConsultantNotes");
                    if (hairProfile.HealthSummary != null)
                        multiContent.Add(new StringContent(hairProfile.HealthSummary), "HealthSummary");
                    if (hairProfile.TopLeftStrandDiameter != null)
                        multiContent.Add(new StringContent(hairProfile.TopLeftStrandDiameter), "TopLeftStrandDiameter");
                    if (hairProfile.TopRightStrandDiameter != null)
                        multiContent.Add(new StringContent(hairProfile.TopRightStrandDiameter), "TopRightStrandDiameter");
                    if (hairProfile.BottomLeftStrandDiameter != null)
                        multiContent.Add(new StringContent(hairProfile.BottomLeftStrandDiameter), "BottomLeftStrandDiameter");
                    if (hairProfile.BottoRightStrandDiameter != null)
                        multiContent.Add(new StringContent(hairProfile.BottoRightStrandDiameter), "BottoRightStrandDiameter");
                    if (hairProfile.CrownStrandDiameter != null)
                        multiContent.Add(new StringContent(hairProfile.CrownStrandDiameter), "CrownStrandDiameter");
                    if (hairProfile.TempHealth != null)
                        multiContent.Add(new StringContent(hairProfile.TempHealth), "TempHealth");

                    if (hairProfile.TempObservation != null)
                        multiContent.Add(new StringContent(hairProfile.TempObservation), "TempObservation");
                    if (hairProfile.TempObservationElasticity != null)
                        multiContent.Add(new StringContent(hairProfile.TempObservationElasticity), "TempObservationElasticity");
                    if (hairProfile.TempObservationChemicalProduct != null)
                        multiContent.Add(new StringContent(hairProfile.TempObservationChemicalProduct), "TempObservationChemicalProduct");
                    if (hairProfile.TempObservationPhysicalProduct != null)
                        multiContent.Add(new StringContent(hairProfile.TempObservationPhysicalProduct), "TempObservationPhysicalProduct");
                    //if (hairProfile.TempObservationDamage != null)
                    //    multiContent.Add(new StringContent(hairProfile.TempObservationDamage), "TempObservationDamage");
                    if (hairProfile.TempObservationBreakage != null)
                        multiContent.Add(new StringContent(hairProfile.TempObservationBreakage), "TempObservationBreakage");
                    if (hairProfile.TempObservationSplitting != null)
                        multiContent.Add(new StringContent(hairProfile.TempObservationSplitting), "TempObservationSplitting");

                    if (hairProfile.TempPororsity != null)
                        multiContent.Add(new StringContent(hairProfile.TempPororsity), "TempPororsity");
                    if (hairProfile.TempElasticity != null)
                        multiContent.Add(new StringContent(hairProfile.TempElasticity), "TempElasticity");
                    if (hairProfile.TempRecommendedProducts != null)
                        multiContent.Add(new StringContent(hairProfile.TempRecommendedProducts), "TempRecommendedProducts");
                    if (hairProfile.TempRecommendedProductsStylings != null)
                        multiContent.Add(new StringContent(hairProfile.TempRecommendedProductsStylings), "TempRecommendedProductsStylings");
                    if (hairProfile.TempRecommendedIngredients != null)
                        multiContent.Add(new StringContent(hairProfile.TempRecommendedIngredients), "TempRecommendedIngredients");
                    if (hairProfile.TempRecommendedCategories != null)
                        multiContent.Add(new StringContent(hairProfile.TempRecommendedCategories), "TempRecommendedCategories");
                    if (hairProfile.TempRecommendedProductTypes != null)
                        multiContent.Add(new StringContent(hairProfile.TempRecommendedProductTypes), "TempRecommendedProductTypes");
                    if (hairProfile.TempRecommendedTools != null)
                        multiContent.Add(new StringContent(hairProfile.TempRecommendedTools), "TempRecommendedTools");
                    if (hairProfile.TempRecommendedRegimens != null)
                        multiContent.Add(new StringContent(hairProfile.TempRecommendedRegimens), "TempRecommendedRegimens");
                    if (hairProfile.TempRecommendedVideos != null)
                        multiContent.Add(new StringContent(hairProfile.TempRecommendedVideos), "TempRecommendedVideos");
                    if (hairProfile.TempRecommendedStylist != null)
                        multiContent.Add(new StringContent(hairProfile.TempRecommendedStylist), "TempRecommendedStylist");
                    if (hairProfile.TempSelectedAnswer != null)
                        multiContent.Add(new StringContent(hairProfile.TempSelectedAnswer), "TempSelectedAnswer");
                    if (hairProfile.SaveType != null)
                        multiContent.Add(new StringContent(hairProfile.SaveType), "SaveType");
                    if (hairProfile.TabNo != null)
                        multiContent.Add(new StringContent(hairProfile.TabNo), "TabNo");
                    if (hairProfile.TempAllRecommendedProductsEssential != null)
                        multiContent.Add(new StringContent(hairProfile.TempAllRecommendedProductsEssential), "TempAllRecommendedProductsEssential");
                    if (hairProfile.TempAllRecommendedProductsStyling != null)
                        multiContent.Add(new StringContent(hairProfile.TempAllRecommendedProductsStyling), "TempAllRecommendedProductsStyling");

                    multiContent.Add(new StringContent(hairProfile.NotifyUser.ToString()), "NotifyUser");

                    var result = client.PostAsync("HairProfile/SaveProfile", multiContent).Result;

                    if ((int)result.StatusCode == 200)
                        if (hairProfile.SaveType == "normal")
                            return Content("1");
                        else
                            return Content("2");

                    else
                        return Content("0");
                }
                catch (Exception ex)
                {
                    return StatusCode(500);
                }
            }
        }

        public async Task<IActionResult> GetHairProfile(HairProfileAdminModel hairProfileModel)
        {
            try
            {
                if (hairProfileModel != null)
                {
                    var response = await MyavanaAdminApiClientFactory.Instance.GetHairProfileAdmin(hairProfileModel);
                    if (response != null)
                    {
                        return Json(response.Data);
                    }
                    return Content("0");
                }
            }
            catch (Exception ex) { }
            return Content("0");
        }

        public IActionResult QuestionnaireCustomer()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> QuestionnaireCustomerList([DataTablesRequest] DataTablesRequest dataRequest)
        {
            IEnumerable<QuestionnaireCustomerList> filterQuestionnaire = await MyavanaAdminApiClientFactory.Instance.QuestionnaireCustomerList();
            filterQuestionnaire = filterQuestionnaire.Where(x => x.CustomerType.ToString() == Request.Cookies["UserType"].ToString());
            try
            {
                IEnumerable<QuestionnaireCustomerList> blogs = filterQuestionnaire.Select(e => new QuestionnaireCustomerList
                {
                    UserId = e.UserId,
                    UserName = e.UserName,
                    UserEmail = e.UserEmail,
                    IsQuestionnaire = e.IsQuestionnaire

                }).OrderByDescending(x => x.CreatedAt);
                return Json(blogs.ToDataTablesResponse(dataRequest, blogs.Count()));

            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public IActionResult start(string id)
        {
            if (id != null)
            {
                ViewBag.id = id;
            }
            return View();
        }

        public IActionResult QuestionaireSurvey(string id, string userId)
        {
            ViewBag.Token = userId;
            ViewBag.Check = id;
            return View();
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
        public async Task<IActionResult> SaveImage(IFormFile file)
        {
            try
            {
                if (file != null)
                {
                    string fileName = RandomNumbers() + ".jpg";
                    string extension = file.FileName.Substring(file.FileName.LastIndexOf("."));
                    if (!Directory.Exists(Path.Combine(Directory.GetCurrentDirectory(), "questionnaireFile")))
                    {
                        Directory.CreateDirectory(Path.Combine(Environment.CurrentDirectory, "questionnaireFile"));
                    }
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "questionnaireFile", fileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }

                    return Content(fileName);
                }
                else
                    return Content("0");
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }
        [HttpPost]
        public async Task<QuestionAnswersModel> GetUserQuestionaire(string uId)
        {
            //var claimsIdentity1 = (ClaimsIdentity)User.Identity;
            string userId = uId; // (claimsIdentity1.Claims).Select(x => x.Value).FirstOrDefault();
            using (var client = new HttpClient())
            {
            
                try
                {
               
                    var requestUrl = client.GetAsync(" https://api.myavana.com/" + "Questionnaire/GetQuestionnaireCustomer?id=" + userId).Result;

                    var data = await requestUrl.Content.ReadAsStringAsync();
                    dynamic result = JObject.Parse(data);
                    QuestionAnswersModel questionaire = JsonConvert.DeserializeObject<QuestionAnswersModel>(Convert.ToString(result.data));
                    return questionaire;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }

        }

        [HttpPost]
        public async Task<IActionResult> SaveQuestionaire([FromBody] IEnumerable<Questionaire> questionaire)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    //client.BaseAddress = BaseEndpoint;
                    if (questionaire.Count() != 0)
                    {
                        var response = await MyavanaAdminApiClientFactory.Instance.SaveQuestionnaireSurvey(questionaire);

                        if (response.message == "Success")
                            return Content("1");
                        else
                            return Content("0");
                    }
                    else
                    {
                        return Content("0");
                    }
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }

        [HttpPost]
        [AllowAnonymous]
        [DisableRequestSizeLimit]
        public async Task<List<FileModel>> AddTopLeftFiles(List<IFormFile> files)
        {
            List<FileModel> fileModelListing = new List<FileModel>();
            List<FileModel> fileModifiedNames = new List<FileModel>();
            foreach (var imageFile in files)
            {
                fileModelListing.Add(new FileModel { FileName = imageFile.Name.Replace(" ", ""), FormFile = imageFile });
            }
            var path = string.Empty;
            foreach (var fileDataModel in fileModelListing)
            {
                string fileName = fileDataModel.FormFile.FileName.Replace(" ", "");
                string uniqueFileName = DateTime.Now.ToString("yyyymmddMMss") + "_" + fileDataModel.FormFile.FileName.Replace(" ", "");
                path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "HairProfile", uniqueFileName);

                fileModifiedNames.Add(new FileModel { FileName = fileName, UniqueFileName = uniqueFileName });
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await fileDataModel.FormFile.CopyToAsync(stream);
                }
            }
            return fileModifiedNames;
        }

        [AllowAnonymous]
        public string RemoveTopLeftFiles(string fileName)
        {
            try
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "HairProfile", fileName);
                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);
                }
                return "1";
            }
            catch (Exception)
            {
                return "0";
            }
        }

        [HttpPost]
        [AllowAnonymous]
        [DisableRequestSizeLimit]
        public async Task<List<FileModel>> AddTopRightFiles(List<IFormFile> files)
        {
            List<FileModel> fileModelListing = new List<FileModel>();
            List<FileModel> fileModifiedNames = new List<FileModel>();
            foreach (var imageFile in files)
            {
                fileModelListing.Add(new FileModel { FileName = imageFile.Name.Replace(" ", ""), FormFile = imageFile });
            }
            var path = string.Empty;

            foreach (var fileDataModel in fileModelListing)
            {
                string fileName = fileDataModel.FormFile.FileName.Replace(" ", "");
                string uniqueFileName = DateTime.Now.ToString("yyyymmddMMss") + "_" + fileDataModel.FormFile.FileName.Replace(" ", "");
                path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "HairProfile", uniqueFileName);

                fileModifiedNames.Add(new FileModel { FileName = fileName, UniqueFileName = uniqueFileName });
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await fileDataModel.FormFile.CopyToAsync(stream);
                }
            }
            return fileModifiedNames;
        }

        [AllowAnonymous]
        public string RemoveTopRightFiles(string fileName)
        {
            try
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "HairProfile", fileName);
                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);
                }
                return "1";
            }
            catch (Exception)
            {
                return "0";
            }
        }

        [HttpPost]
        [AllowAnonymous]
        [DisableRequestSizeLimit]
        public async Task<List<FileModel>> AddBottomLeftFiles(List<IFormFile> files)
        {
            List<FileModel> fileModelListing = new List<FileModel>();
            List<FileModel> fileModifiedNames = new List<FileModel>();
            foreach (var imageFile in files)
            {
                fileModelListing.Add(new FileModel { FileName = imageFile.Name.Replace(" ", ""), FormFile = imageFile });
            }
            var path = string.Empty;
            foreach (var fileDataModel in fileModelListing)
            {
                string fileName = fileDataModel.FormFile.FileName.Replace(" ", "");
                string uniqueFileName = DateTime.Now.ToString("yyyymmddMMss") + "_" + fileDataModel.FormFile.FileName.Replace(" ", "");
                path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "HairProfile", uniqueFileName);

                fileModifiedNames.Add(new FileModel { FileName = fileName, UniqueFileName = uniqueFileName });
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await fileDataModel.FormFile.CopyToAsync(stream);
                }
            }
            return fileModifiedNames;
        }

        [AllowAnonymous]
        public string RemoveBottomLeftFiles(string fileName)
        {
            try
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "HairProfile", fileName);
                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);
                }
                return "1";
            }
            catch (Exception)
            {
                return "0";
            }
        }

        [HttpPost]
        [AllowAnonymous]
        [DisableRequestSizeLimit]
        public async Task<List<FileModel>> AddBottomRightFiles(List<IFormFile> files)
        {
            List<FileModel> fileModelListing = new List<FileModel>();
            List<FileModel> fileModifiedNames = new List<FileModel>();
            foreach (var imageFile in files)
            {
                fileModelListing.Add(new FileModel { FileName = imageFile.Name.Replace(" ", ""), FormFile = imageFile });
            }
            var path = string.Empty;
            foreach (var fileDataModel in fileModelListing)
            {
                string fileName = fileDataModel.FormFile.FileName.Replace(" ", "");
                string uniqueFileName = DateTime.Now.ToString("yyyymmddMMss") + "_" + fileDataModel.FormFile.FileName.Replace(" ", "");
                path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "HairProfile", uniqueFileName);

                fileModifiedNames.Add(new FileModel { FileName = fileName, UniqueFileName = uniqueFileName });
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await fileDataModel.FormFile.CopyToAsync(stream);
                }
            }
            return fileModifiedNames;
        }

        [AllowAnonymous]
        public string RemoveBottomRightFiles(string fileName)
        {
            try
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "HairProfile", fileName);
                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);
                }
                return "1";
            }
            catch (Exception)
            {
                return "0";
            }
        }

        [HttpPost]
        [AllowAnonymous]
        [DisableRequestSizeLimit]
        public async Task<List<FileModel>> AddCrownFiles(List<IFormFile> files)
        {
            List<FileModel> fileModelListing = new List<FileModel>();
            List<FileModel> fileModifiedNames = new List<FileModel>();
            foreach (var imageFile in files)
            {
                fileModelListing.Add(new FileModel { FileName = imageFile.Name.Replace(" ", ""), FormFile = imageFile });
            }
            var path = string.Empty;
            foreach (var fileDataModel in fileModelListing)
            {
                string fileName = fileDataModel.FormFile.FileName.Replace(" ", "");
                string uniqueFileName = DateTime.Now.ToString("yyyymmddMMss") + "_" + fileDataModel.FormFile.FileName.Replace(" ", "");
                path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "HairProfile", uniqueFileName);

                fileModifiedNames.Add(new FileModel { FileName = fileName, UniqueFileName = uniqueFileName });
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await fileDataModel.FormFile.CopyToAsync(stream);
                }
            }
            return fileModifiedNames;
        }

        [AllowAnonymous]
        public string RemoveCrownFiles(string fileName)
        {
            try
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "HairProfile", fileName);
                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);
                }
                return "1";
            }
            catch (Exception)
            {
                return "0";
            }
        }

        [HttpPost]
        public async Task<IActionResult> DeleteQuest(QuestModel quest)
        {
            var response = await MyavanaAdminApiClientFactory.Instance.DeleteQuest(quest);

            if (response.message == "Success")
                return Content("1");
            else
                return Content("0");

        }

        public IActionResult QuestionnaireAbsence()
        {
            return View();
        }

        public IActionResult CustomerMessages(string userId)
        {
            ViewBag.UserId = userId;
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> CustomerMessageList([DataTablesRequest] DataTablesRequest dataRequest, string id)
        {
            IEnumerable<CustomerMessageViewModel> filterQuestionnaire = await MyavanaAdminApiClientFactory.Instance.CustomerMessagesList(id);
            try
            {
                IEnumerable<CustomerMessageViewModel> blogs = filterQuestionnaire.Select(e => new CustomerMessageViewModel
                {
                    EmailAddress = e.EmailAddress,
                    Subject = e.Subject,
                    Message = e.Message,
                    CreatedOn = e.CreatedOn,
                    AttachmentFile = e.AttachmentFile

                }).OrderByDescending(x => x.CreatedOn);
                return Json(blogs.ToDataTablesResponse(dataRequest, blogs.Count()));

            }
            catch (Exception ex)
            {
                return null;
            }

        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<string> SaveCustomerMessage(CustomerMessageModel messageModel, IFormFile File)
        {
            CustomerMessageModel customerMessageModel = new CustomerMessageModel();
            customerMessageModel.EmailAddress = messageModel.EmailAddress;
            customerMessageModel.Subject = messageModel.Subject;
            customerMessageModel.Message = messageModel.Message;
            customerMessageModel.UserId = messageModel.UserId;
            customerMessageModel.UserName = messageModel.UserName;
            customerMessageModel.emailTemplate = "EMAILTEMPLATE01";

            if (File != null)
            {
                string fileName = File.FileName.Substring(0, File.FileName.IndexOf(".")) + "_" + DateTime.Now.ToString("yyyyMMddTHHmmss") + File.FileName.Substring(File.FileName.IndexOf("."));
                customerMessageModel.AttachmentFile = fileName;
                var path = string.Empty;
                path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "CustomerMessageFiles", fileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await File.CopyToAsync(stream);
                }
            }
            var response = await MyavanaAdminApiClientFactory.Instance.SaveCustomerMessage(customerMessageModel);
            if (response.result == "1")
            {
                customerMessageModel.emailBody = response.Data.emailBody;
                var result1 = await MyavanaAdminApiClientFactory.Instance.GetCustomerEmailTemplate();

                CommonController.SendEmailToCustomer(customerMessageModel, result1, File);
                return "1";
            }
            else
                return "0";
        }

        public async Task<IActionResult> CreateNewCustomer()
        {
            
            return View();
        }
        private HttpContent CreateHttpContent<T>(T content)
        {
            var json = JsonConvert.SerializeObject(content, MicrosoftDateFormatSettings);
            return new StringContent(json, Encoding.UTF8, "application/json");
        }
        private static JsonSerializerSettings MicrosoftDateFormatSettings
        {
            get
            {
                return new JsonSerializerSettings
                {
                    DateFormatHandling = DateFormatHandling.MicrosoftDateFormat
                };
            }
        }
        [HttpPost]
        public async Task<IActionResult> CreateNewCustomer(Signup signup)
        {
            signup.CustomerType = false;
            _httpClient.BaseAddress = new Uri("https://api.myavana.com/");
            var response = _httpClient.PostAsync("Account/WebSignup", CreateHttpContent<Signup>(signup)).Result;

            var data = await response.Content.ReadAsStringAsync();
            dynamic result = JObject.Parse(data);
            Response res = null;
            try
            {
                res = JsonConvert.DeserializeObject<Response>(Convert.ToString(result));
               
            }
            catch (Exception ex)
            {
                return Content("0");
            }

            if (res.value.item1 != null)
                return Content(res.value.item1);
            else
                return Content("-1");
        }
    }
}
