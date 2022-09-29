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
		public async Task<List<HairProfileCustomersModel>> GetHairProfileCustomerList()
		{
			var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "HairProfile/GetHairProfileCustomerList"));
			var response = await GetAsyncData<HairProfileCustomersModel>(requestUrl);
			List<HairProfileCustomersModel> questionaire = JsonConvert.DeserializeObject<List<HairProfileCustomersModel>>(Convert.ToString(response.data));
			return questionaire;
		}

		public async Task<Message<HairProfileCustomerModel>> GetHairProfileCustomer(HairProfileCustomerModel hairProfileModel)
		{
			var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "HairProfile/GetHairProfileCustomer"));
			var result = await PostAsync<HairProfileCustomerModel>(requestUrl, hairProfileModel);
			return result;
		}
	}
}
