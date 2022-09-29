using MyavanaAdminModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading.Tasks;

namespace MyavanaAdminApiClient
{
    public partial class ApiClient
    {       
        public async Task<List<MediaLinkEntityModel>> GetEducationalVideos()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "SocialMedia/GetTvLinks"));
            var response = await GetAsyncResponse<MediaLinkEntityModel>(requestUrl);
            List<MediaLinkEntityModel> media = response; // JsonConvert.DeserializeObject<List<MediaLinkEntityModel>>(Convert.ToString(response.value.media));
            return media;
        }

        public async Task<List<VideoCategory>> GetVideoCategories()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "SocialMedia/GetVideoCategories"));
            var response = await GetAsyncResponse<VideoCategory>(requestUrl);
            List<VideoCategory> media = response; // JsonConvert.DeserializeObject<List<MediaLinkEntityModel>>(Convert.ToString(response.value.media));
            return media;
        }

        public async Task<Message<MediaLinkEntityModel>> GetMediaById(MediaLinkEntityModel mediaLinkEntityModel)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
            "SocialMedia/GetMediaById"));
            var result = await PostAsync<MediaLinkEntityModel>(requestUrl, mediaLinkEntityModel);
            return result;
        }

        public async Task<Message<MediaLinkEntityModel>> SaveMediaLink(MediaLinkEntityModel mediaLinkEntity)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "SocialMedia/SaveMediaLinks"));
            var result = await PostAsync<MediaLinkEntityModel>(requestUrl, mediaLinkEntity);
            return result;
        }

        public async Task<Message<MediaLinkEntityModel>> DeleteVideo(MediaLinkEntityModel mediaLinkEntity)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "SocialMedia/DeleteMediaLink"));
            var result = await PostAsync<MediaLinkEntityModel>(requestUrl, mediaLinkEntity);
            return result;
        }
    }
}
