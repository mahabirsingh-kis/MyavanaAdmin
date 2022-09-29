using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyavanaAdminModels
{
	public class PromoCodeModel
	{
		public string PromoCode { get; set; }
		public DateTime ExpireDate { get; set; }
		public string StripePlanId { get; set; }
		public string InitialDate { get; set; }
	}

	public class CodeListModel
	{
		[JsonProperty(PropertyName = "promoCode")]
		public string PromoCode { get; set; }
		[JsonProperty(PropertyName = "createdDate")]
		public DateTime? CreatedDate { get; set; }
		[JsonProperty(PropertyName = "expireDate")]
		public DateTime? ExpireDate { get; set; }
		[JsonProperty(PropertyName = "isActive")]
		public bool IsActive { get; set; }
		public DateTime? CreatedOn { get; set; }

	}

}
