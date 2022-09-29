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
        public async Task<Message<ProductsEntity>> SaveProducts(ProductsEntity productsEntity)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "Products/SaveProducts"));
            var result = await PostAsync<ProductsEntity>(requestUrl, productsEntity);
            return result;
        }

        public async Task<List<ProductsEntity>> GetProducts()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "Products/GetProducts"));
            var response = await GetAsyncData<ProductsEntity>(requestUrl);
            List<ProductsEntity> blogPosts = JsonConvert.DeserializeObject<List<ProductsEntity>>(Convert.ToString(response.value));
            return blogPosts;
        }

        public async Task<ProductsListings> GetAllProducts()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "Products/GetAllProducts"));
            var response = await GetAsyncData<ProductsListings>(requestUrl);
            ProductsListings productsListings = JsonConvert.DeserializeObject<ProductsListings>(Convert.ToString(response.value));
            List<string> productBrands = new List<string>();
            List<ProductBrand> productBrandsList = new List<ProductBrand>();
            foreach (var product in productsListings.ProductsModelLists)
            {
                ProductBrand pBrand = new ProductBrand();
                pBrand.BrandName = product.BrandName;
                pBrand.ProductTypeId = product.ProductTypeId;
                pBrand.ProductId = product.Id;
                if (!(productBrands.Contains(pBrand.BrandName)))
                {
                    productBrands.Add(pBrand.BrandName);
                    productBrandsList.Add(pBrand);
                }
            }
            productsListings.ProductBrand = productBrandsList;
            List<ProductsModelList> list = productsListings.ProductsModelLists;
            List<ProductsModelList> list1 = new List<ProductsModelList>();
            foreach (var bd in list)
            {
                if (bd.BrandName == "Alikay Naturals")
                {
                    list1.Add(bd);
                }
            }
            return productsListings;
        }
        public async Task<Message<ProductsEntity>> DeleteProduct(ProductsEntity productsEntity)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "Products/DeleteProduct"));
            var result = await PostAsync<ProductsEntity>(requestUrl, productsEntity);
            return result;
        }
        public async Task<Message<ProductEntityEditModel>> GetProductById(ProductEntityEditModel productsEntity)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
            "Products/GetProductById"));
            var result = await PostAsync<ProductEntityEditModel>(requestUrl, productsEntity);
            return result;
        }

        public async Task<Message<ProductTypeCategoryModel>> SaveProductType(ProductTypeCategoryModel productTypeEntity)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "Products/SaveProductType"));
            var result = await PostAsync<ProductTypeCategoryModel>(requestUrl, productTypeEntity);
            return result;
        }

        public async Task<Message<ProductTypeCategoriesList>> SaveProductCategory(ProductTypeCategoriesList productTypeEntity)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "Products/SaveProductCategory"));
            var result = await PostAsync<ProductTypeCategoriesList>(requestUrl, productTypeEntity);
            return result;
        }

        public async Task<List<ProductTypeEntity>> GetProductType()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "Products/GetProductType"));
            var response = await GetAsyncData<ProductTypeEntity>(requestUrl);
            List<ProductTypeEntity> blogPosts = JsonConvert.DeserializeObject<List<ProductTypeEntity>>(Convert.ToString(response.value));
            return blogPosts;
        }

        public async Task<List<ProductTypeCategoriesList>> GetProductsCategoryList()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "Products/GetProductsCategoryList"));
            var response = await GetAsyncData<ProductTypeCategoriesList>(requestUrl);
            List<ProductTypeCategoriesList> blogPosts = JsonConvert.DeserializeObject<List<ProductTypeCategoriesList>>(Convert.ToString(response.value));
            return blogPosts;
        }
        public async Task<Message<ProductTypeEntity>> DeleteProductType(ProductTypeEntity productTypeEntity)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "Products/DeleteProductType"));
            var result = await PostAsync<ProductTypeEntity>(requestUrl, productTypeEntity);
            return result;
        }

        public async Task<Message<ProductTypeEntity>> DeleteProductCategory(ProductTypeEntity productTypeEntity)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "Products/DeleteProductCategory"));
            var result = await PostAsync<ProductTypeEntity>(requestUrl, productTypeEntity);
            return result;
        }
        public async Task<Message<ProductTypeEntity>> GetProductTypeById(ProductTypeEntity productTypeEntity)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
            "Products/GetProductTypeById"));
            var result = await PostAsync<ProductTypeEntity>(requestUrl, productTypeEntity);
            return result;
        }

        public async Task<Message<ProductTypeCategoriesList>> GetProductCategoryById(ProductTypeCategoriesList productTypeEntity)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
            "Products/GetProductCategoryById"));
            var result = await PostAsync<ProductTypeCategoriesList>(requestUrl, productTypeEntity);
            return result;
        }

        public async Task<List<ProductBrand>> GetBrands()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "Products/GetBrands"));
            var response = await GetAsyncData<ProductsEntity>(requestUrl);
            List<ProductsEntity> products = JsonConvert.DeserializeObject<List<ProductsEntity>>(Convert.ToString(response.value));
            List<string> productBrands = new List<string>();
            List<ProductBrand> productBrandsList = new List<ProductBrand>();
            foreach (var product in products)
            {
                ProductBrand pBrand = new ProductBrand();
                pBrand.BrandName = product.BrandName;
                pBrand.ProductTypeId = product.ProductTypeId;
                pBrand.ProductId = product.Id;
                if (!(productBrands.Contains(pBrand.BrandName)))
                {
                    productBrands.Add(pBrand.BrandName);
                    productBrandsList.Add(pBrand);
                }
            }
            return productBrandsList;
        }

        public async Task<List<ProductTypesList>> GetProductTypes()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "Products/GetProductTypes"));
            var response = await GetAsyncData<ProductTypesList>(requestUrl);
            List<ProductTypesList> products = JsonConvert.DeserializeObject<List<ProductTypesList>>(Convert.ToString(response.value));
            return products;
        }

        public async Task<List<ProductsEntity>> AddProductList(List<ProductsEntity> productModel)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "Products/AddProductList"));
            var result = await PostAsync<List<ProductsEntity>>(requestUrl, productModel);
            return result.Data;
        }

        public async Task<List<HairTypeModel>> GetHairTypesList()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "Products/GetHairTypesList"));
            var response = await GetAsyncData<HairTypeModel>(requestUrl);
            List<HairTypeModel> blogPosts = JsonConvert.DeserializeObject<List<HairTypeModel>>(Convert.ToString(response.value));
            return blogPosts;
        }

        public async Task<List<HairChallengesModel>> GetHairChallengesList()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "Products/GetHairChallengesList"));
            var response = await GetAsyncData<HairChallengesModel>(requestUrl);
            List<HairChallengesModel> blogPosts = JsonConvert.DeserializeObject<List<HairChallengesModel>>(Convert.ToString(response.value));
            return blogPosts;
        }

        public async Task<List<ProductIndicatorsModel>> GetProductIndicatorsList()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "Products/GetProductIndicatorsList"));
            var response = await GetAsyncData<ProductIndicatorsModel>(requestUrl);
            List<ProductIndicatorsModel> blogPosts = JsonConvert.DeserializeObject<List<ProductIndicatorsModel>>(Convert.ToString(response.value));
            return blogPosts;
        }

        public async Task<List<ProductTagsModel>> GetProductTagList()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "Products/GetProductTagList"));
            var response = await GetAsyncData<ProductTagsModel>(requestUrl);
            List<ProductTagsModel> blogPosts = JsonConvert.DeserializeObject<List<ProductTagsModel>>(Convert.ToString(response.value));
            return blogPosts;
        }
        public async Task<List<ProductClassificationModel>> GetProductClassificationList()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "Products/GetProductClassificationList"));
            var response = await GetAsyncData<ProductClassificationModel>(requestUrl);
            List<ProductClassificationModel> blogPosts = JsonConvert.DeserializeObject<List<ProductClassificationModel>>(Convert.ToString(response.value));
            return blogPosts;
        }
        public async Task<List<IngredientEntityModel>> GetIngredientsList()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "Products/GetIngredientsList"));
            var response = await GetAsyncData<IngredientEntityModel>(requestUrl);
            List<IngredientEntityModel> blogPosts = JsonConvert.DeserializeObject<List<IngredientEntityModel>>(Convert.ToString(response.value));
            return blogPosts;
        }

        public async Task<List<ProductTypeCategory>> GetProductCategory()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "Products/GetProductCategory"));
            var response = await GetAsyncData<ProductTypeCategory>(requestUrl);
            List<ProductTypeCategory> blogPosts = JsonConvert.DeserializeObject<List<ProductTypeCategory>>(Convert.ToString(response.value));
            return blogPosts;
        }


        public async Task<Message<IndicatorModel>> SaveIndicator(IndicatorModel productTypeEntity)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "Indicator/SaveIndicator"));
            var result = await PostAsync<IndicatorModel>(requestUrl, productTypeEntity);
            return result;
        }

        public async Task<Message<IndicatorModel>> DeleteProductIndicator(IndicatorModel indicatorModel)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "Indicator/DeleteIndicator"));
            var result = await PostAsync<IndicatorModel>(requestUrl, indicatorModel);
            return result;
        }

        public async Task<Message<IndicatorModel>> GetProductIndicatorById(IndicatorModel productTypeEntity)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
            "Indicator/GetIndicatorById"));
            var result = await PostAsync<IndicatorModel>(requestUrl, productTypeEntity);
            return result;
        }


        public async Task<List<IndicatorModel>> GetIndicators()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "Indicator/GetIndicators"));
            var response = await GetAsyncData<IndicatorModel>(requestUrl);
            List<IndicatorModel> indicators = JsonConvert.DeserializeObject<List<IndicatorModel>>(Convert.ToString(response.data));
            return indicators;
        }

    }
}
