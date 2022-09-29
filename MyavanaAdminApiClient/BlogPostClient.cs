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
        public async Task<Message<BlogPostModel>> SaveBlogPost(BlogPostModel blogPostModel)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "Article/UploadArticles"));
            var result = await PostAsync<BlogPostModel>(requestUrl, blogPostModel);
            return result;
        }

        public async Task<List<BlogPostModel>> GetArticles()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "Article/GetBlogArticles"));
            var response = await GetAsyncData<BlogPostModel>(requestUrl);
            List<BlogPostModel> blogPosts = JsonConvert.DeserializeObject<List<BlogPostModel>>(Convert.ToString(response.value.article));
            return blogPosts;

        }

        public async Task<Message<BlogPostModel>> GetArticleById(BlogPostModel blogPostModel)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
            "Article/GetArticleById"));
            var result = await PostAsync<BlogPostModel>(requestUrl, blogPostModel);
            return result;
        }

        public async Task<Message<BlogPostModel>> DeleteArticle(BlogPostModel blogPostModel)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "Article/DeleteArticle"));
            var result = await PostAsync<BlogPostModel>(requestUrl, blogPostModel);
            return result;
        }

        public async Task<Message<GroupPost>> CreatePost(GroupPost groupPost)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "Groups/CreatePost"));
            var result = await PostAsync<GroupPost>(requestUrl, groupPost);
            return result;
        }

        public async Task<Message<UserRoutineHairCareModel>> AddSelectedRoutineItems(UserRoutineHairCareModel groupPost)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "Calender/AddSelectedRoutineItems"));
            var result = await PostAsync<UserRoutineHairCareModel>(requestUrl, groupPost);
            return result;
        }

        public async Task<Message<DailyRoutineTracker>> AddProfileImage(DailyRoutineTracker routineTracker)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "Calender/AddProfileImage"));
            var result = await PostAsync<DailyRoutineTracker>(requestUrl, routineTracker);
            return result;
        }
    }
}
