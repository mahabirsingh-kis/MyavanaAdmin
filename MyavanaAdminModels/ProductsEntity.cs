using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyavanaAdminModels
{
    public class ProductsEntity
    {
        public int Id { get; set; }
        [JsonProperty(PropertyName = "guid")]
        public Guid guid { get; set; }

        [JsonProperty(PropertyName = "ProductName")]
        public string ProductName { get; set; }

        [JsonProperty(PropertyName = "ActualName")]
        public string ActualName { get; set; }

        [JsonProperty(PropertyName = "BrandName")]
        public string BrandName { get; set; }

        //[JsonProperty(PropertyName = "TypeFor")]
        public string TypeFor { get; set; }

        [JsonProperty(PropertyName = "ImageName")]
        public string ImageName { get; set; }

        [JsonProperty(PropertyName = "Ingredients")]
        public string Ingredients { get; set; }

        [JsonProperty(PropertyName = "ProductDetails")]
        public string ProductDetails { get; set; }

        [JsonProperty(PropertyName = "ProductLink")]
        public string ProductLink { get; set; }

        [JsonProperty(PropertyName = "IsActive")]
        public bool IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ProductTypeId { get; set; }
        public int? ProductTypesId { get; set; }

        [JsonProperty(PropertyName = "ProductType")]
        public string ProductType { get; set; }
        public int? ParentId { get; set; }
        public string ParentName { get; set; }
        [JsonProperty(PropertyName = "Price")]
        public decimal Price { get; set; }

        //[JsonProperty(PropertyName = "ProductClassification")]
        public string ProductClassification { get; set; }

        //[JsonProperty(PropertyName = "ProductIndicator")]
        public string ProductIndicator { get; set; }

       // [JsonProperty(PropertyName = "HairChallenges")]
        public string HairChallenges { get; set; }

        //[JsonProperty(PropertyName = "ProductTags")]
        public string ProductTags { get; set; }
        public string Product { get; set; }

        [JsonProperty(PropertyName = "HairType")]
        public List<HairTypeModel> HairType { get; set; }
        [JsonProperty(PropertyName = "ProductIndicate")]
        public List<ProductIndicatorsModel> ProductIndicate { get; set; }
        [JsonProperty(PropertyName = "HairChallenge")]
        public List<HairChallengesModel> HairChallenge { get; set; }
        [JsonProperty(PropertyName = "ProductTag")]
        public List<ProductTagsModel> ProductTag { get; set; }
        [JsonProperty(PropertyName = "ProductClassificatio")]
        public List<ProductClassificationModel> ProductClassificatio { get; set; }
    }

    public class ProductBrand
    {
        public string BrandName { get; set; }
        public int? ProductTypeId { get; set; }
        public int ProductId { get; set; }
    }


    public class ProductsListings
    {
        public List<ProductsModelList> ProductsModelLists { get; set; }
        public List<ProductTypeCategory> TypeCategories { get; set; }
        public List<ProductTypesList> ProductTypes { get; set; }
        public List<ProductClassification> ProductClassifications { get; set; }
        public List<HairChallenges> HairChallenges { get; set; }
        public List<ProductBrand> ProductBrand { get; set; }
    }

    public class ProductsModelList
    {
        //public List<ProductEntity> product { get; set; }
        public int Id { get; set; }
        public Guid guid { get; set; }
        public string ProductName { get; set; }
        public string ActualName { get; set; }
        public string BrandName { get; set; }
        public string ImageName { get; set; }
        public string Ingredients { get; set; }
        public string ProductDetails { get; set; }
        public string ProductLink { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ProductTypeId { get; set; }
        public string ProductType { get; set; }
        public int? ParentId { get; set; }
        public string ParentName { get; set; }
        public List<HairChallenges> HairChallenge { get; set; }
        public List<ProductClassification> ProductClassificatio { get; set; }
        public decimal Price { get; set; }
    }
    public class ProductTypesList
    {
        public int ProductTypeId { get; set; }
        public string ProductTypeName { get; set; }
        public int? ParentId { get; set; }
    }

    public class ProductClassification
    {
        public int ProductClassificationId { get; set; }
        public string Description { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
    public class HairChallenges
    {
        public int HairChallengeId { get; set; }
        public string Description { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
    public class ProductsData
    {
        public IFormFile file { get; set; }
    }

    public class HairTypeModel
    {
        public int HairTypeId { get; set; }
        public string Description { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
    }

    public class HairChallengesModel
    {
        public int HairChallengeId { get; set; }
        public string Description { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
    public class ProductIndicatorsModel
    {
        public int ProductIndicatorId { get; set; }
        public string Description { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
    }

    public class ProductTagsModel
    {
        public int ProductTagsId { get; set; }
        public string Description { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
    }

    public class ProductClassificationModel
    {
        public int ProductClassificationId { get; set; }
        public string Description { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
    }

    public class ProductEntityEditModel
    {
        public int Id { get; set; }
        public Guid guid { get; set; }
        public string ProductName { get; set; }
        public string ActualName { get; set; }
        public string BrandName { get; set; }
        public string ImageName { get; set; }
        public string Ingredients { get; set; }
        public string ProductDetails { get; set; }
        public string ProductLink { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ProductTypesId { get; set; }
        public int? TypeId { get; set; }

        public string ProductType { get; set; }
        public decimal Price { get; set; }
        public string ActualPrice { get; set; }
        public string DecimalPrice { get; set; }
        public string ProductClassification { get; set; }
        public string ProductIndicator { get; set; }
        public string HairChallenges { get; set; }
        public string ProductTags { get; set; }

        public List<ProductCommon> productCommons { get; set; }
    }

    public class ProductCommon
    {
        public int ProductCommonId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? HairTypeId { get; set; }
        public int? HairChallengeId { get; set; }
        public int? ProductIndicatorId { get; set; }
        public int? ProductTagsId { get; set; }
        public int? ProductClassificationId { get; set; }
        public int? ProductEntityId { get; set; }
    }
}
