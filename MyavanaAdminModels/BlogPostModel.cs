using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyavanaAdminModels
{
	public class BlogPostModel
	{
		[JsonProperty(PropertyName = "blogArticleId")]
		public int BlogArticleId { get; set; }
		[JsonProperty(PropertyName = "headline")]
		public string Headline { get; set; }
		[JsonProperty(PropertyName = "details")]
		public string Details { get; set; }
		[JsonProperty(PropertyName = "imageUrl")]
		public string ImageUrl { get; set; }
		[JsonProperty(PropertyName = "url")]
		public string Url { get; set; }

		[JsonProperty(PropertyName = "isActive")]
		public bool IsActive { get; set; }
		//public IFormFile FormFile { get; set; }

		[JsonProperty(PropertyName = "createdOn")]
		public DateTime? CreatedOn { get; set; }
	}

	public class BlogArticleModel
	{
		public List<BlogPostModel> Article { get; set; }
	}

    public class QuestModel
    {
        public string Email { get; set; }
    }

    public class GroupPost
    {
        public string HairType { get; set; }
        public string UserEmail { get; set; }
        public string Description { get; set; }
        public IFormFile Image { get; set; }
        public string ImageUrl { get; set; }
        public IFormFile Audio { get; set; }
        public string AudioUrl { get; set; }
        public IFormFile Video { get; set; }
        public string VideoUrl { get; set; }
        public string ThumbnailUrl { get; set; }
        public IFormFile Thumbnail { get; set; }
    }
}
