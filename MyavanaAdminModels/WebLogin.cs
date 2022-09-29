using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyavanaAdminModels
{
    public class WebLogin
    {
        [JsonProperty(PropertyName = "UserId")]
        public int UserId { get; set; }

        [JsonProperty(PropertyName = "UserEmail")]
        public string UserEmail { get; set; }

        [JsonProperty(PropertyName = "Password")]
        public string Password { get; set; }

        [JsonProperty(PropertyName = "CreatedOn")]
        public DateTime? CreatedOn { get; set; }

        [JsonProperty(PropertyName = "CreatedBy")]
        public string CreatedBy { get; set; }

        [JsonProperty(PropertyName = "IsActive")]
        public bool? IsActive { get; set; }

        [JsonProperty(PropertyName = "UserType")]
        public bool? UserType { get; set; }
    }

    public class Imagerequest
    {
        public string fileData { get; set; }

    }

    public class fileData
    {
        public string access_token { get; set; }
        public string ImageURL { get; set; }
        public string user_name { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string AccountNo { get; set; }
        public bool TwoFactor { get; set; }
        public string HairType { get; set; }
    }
}
