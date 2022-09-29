using MyavanaAdminModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyavanaAdminApiClient
{
    public partial class ApiClient
    {
        public async Task<Message<WebLogin>> Login(WebLogin webLogin)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "WebLogin/Login"));
            var result = await PostAsync<WebLogin>(requestUrl, webLogin);
            return result;
        }

        public async Task<List<WebLogin>> GetUsers()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "WebLogin/GetUsers"));
            List<WebLogin> response = await GetAsyncList<WebLogin>(requestUrl);
            return response;
        }

        public async Task<Message<WebLogin>> GetUserById(WebLogin webLogin)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
            "WebLogin/GetUserByid"));
            var result = await PostAsync<WebLogin>(requestUrl, webLogin);
            return result;
        }

        public async Task<Message<WebLogin>> CreateNewUser(WebLogin webLogin)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "WebLogin/AddNewUser"));
            var result = await PostAsync<WebLogin>(requestUrl, webLogin);
            return result;
        }

        public async Task<Message<WebLogin>> DeleteUser(WebLogin webLogin)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "WebLogin/DeleteUser"));
            var result = await PostAsync<WebLogin>(requestUrl, webLogin);
            return result;
        }

        public async Task<Message<fileData>> ImageUpload(fileData file)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "Products/FileUpload"));
            var result = await PostAsync<fileData>(requestUrl, file);
            return result;
        }
    }
}
