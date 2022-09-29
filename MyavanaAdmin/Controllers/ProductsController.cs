using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using DataTables.AspNetCore.Mvc.Binder;
using ExcelDataReader;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MyavanaAdmin.Factory;
using MyavanaAdmin.Models;
using MyavanaAdmin.Utility;
using MyavanaAdminModels;

namespace MyavanaAdmin.Controllers
{
    [Authorize(AuthenticationSchemes = "AdminCookies")]
    public class ProductsController : Controller
    {
        private readonly AppSettingsModel apiSettings;
        public ProductsController(IOptions<AppSettingsModel> app)
        {
            ApplicationSettings.WebApiUrl = "https://api.myavana.com/"; //  "http://localhost:5004/api/"; //"https://api.myavana.com/"; // app.Value.WebApiBaseUrl http://localhost:5004/api/;
        }

        public IActionResult Products()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetProductsList([DataTablesRequest] DataTablesRequest dataRequest)
        {
            IEnumerable<ProductsEntity> filterProducts = await MyavanaAdminApiClientFactory.Instance.GetProducts();
            if (dataRequest.Orders.Any())
            {
                int sortColumnIndex = dataRequest.Orders.FirstOrDefault().Column;
                string sortDirection = dataRequest.Orders.FirstOrDefault().Dir;
                Func<ProductsEntity, string> orderingFunctionString = null;
                switch (sortColumnIndex)
                {
                    case 0:
                        {
                            orderingFunctionString = (c => c.ProductName);
                            filterProducts =
                                sortDirection == "asc"
                                    ? filterProducts.OrderBy(orderingFunctionString)
                                    : filterProducts.OrderByDescending(orderingFunctionString);
                            break;
                        }
                    case 1:
                        {
                            orderingFunctionString = (c => c.ActualName);
                            filterProducts =
                                sortDirection == "asc"
                                    ? filterProducts.OrderBy(orderingFunctionString)
                                    : filterProducts.OrderByDescending(orderingFunctionString);
                            break;
                        }
                    case 2:
                        {
                            orderingFunctionString = (c => c.BrandName);
                            filterProducts =
                                sortDirection == "asc"
                                    ? filterProducts.OrderBy(orderingFunctionString)
                                    : filterProducts.OrderByDescending(orderingFunctionString);
                            break;
                        }
                    case 3:
                        {
                            orderingFunctionString = (c => c.TypeFor);
                            filterProducts =
                                sortDirection == "asc"
                                    ? filterProducts.OrderBy(orderingFunctionString)
                                    : filterProducts.OrderByDescending(orderingFunctionString);
                            break;
                        }
                    case 4:
                        {
                            orderingFunctionString = (c => c.ImageName);
                            filterProducts =
                                sortDirection == "asc"
                                    ? filterProducts.OrderBy(orderingFunctionString)
                                    : filterProducts.OrderByDescending(orderingFunctionString);
                            break;
                        }
                    case 5:
                        {
                            orderingFunctionString = (c => c.Ingredients);
                            filterProducts =
                                sortDirection == "asc"
                                    ? filterProducts.OrderBy(orderingFunctionString)
                                    : filterProducts.OrderByDescending(orderingFunctionString);
                            break;
                        }
                    case 6:
                        {
                            orderingFunctionString = (c => c.ProductDetails);
                            filterProducts =
                                sortDirection == "asc"
                                    ? filterProducts.OrderBy(orderingFunctionString)
                                    : filterProducts.OrderByDescending(orderingFunctionString);
                            break;
                        }
                    case 7:
                        {
                            orderingFunctionString = (c => c.ProductLink);
                            filterProducts =
                                sortDirection == "asc"
                                    ? filterProducts.OrderBy(orderingFunctionString)
                                    : filterProducts.OrderByDescending(orderingFunctionString);
                            break;
                        }
                }
            }
            try
            {
                IEnumerable<ProductsEntity> codes = filterProducts.Select(e => new ProductsEntity
                {
                    guid = e.guid,
                    ProductName = e.ProductName,
                    ActualName = e.ActualName,
                    BrandName = e.BrandName,
                    //TypeFor = e.TypeFor,
                    ImageName = e.ImageName,
                    Ingredients = e.Ingredients,
                    ProductDetails = e.ProductDetails,
                    ProductLink = e.ProductLink,
                    IsActive = e.IsActive,
                    Id = e.Id,
                    ProductType = e.ProductType,
                    Price = e.Price,
                    //HairChallenges = e.HairChallenges,
                    //ProductIndicator = e.ProductIndicator,
                    //ProductTags = e.ProductTags,
                    //ProductClassification = e.ProductClassification
                    HairType = e.HairType,
                    ProductIndicate = e.ProductIndicate,
                    HairChallenge = e.HairChallenge,
                    ProductTag = e.ProductTag,
                    ProductClassificatio = e.ProductClassificatio
                }).OrderByDescending(x => x.CreatedOn);
                return Json(codes.ToDataTablesResponse(dataRequest, codes.Count()));

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<IActionResult> CreateProduct(string id)
        {
            if (id != null)
            {
                ProductsEntity productsModel = new ProductsEntity();
                productsModel.guid = Guid.Parse(id);
               // var response = await MyavanaAdminApiClientFactory.Instance.GetProductById(productsModel);
                //productsModel = response.Data;
                return View(productsModel);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ProductAdmin(ProductEntityEditModel productEntityEditModel)
        {
            if (productEntityEditModel != null)
            {
                var response = await MyavanaAdminApiClientFactory.Instance.GetProductById(productEntityEditModel);
                if (response != null)
                {
                    return Json(response.Data);
                }
                return Content("0");
            }
            return Content("0");
        }


        [HttpPost]
        public async Task<IActionResult> CreateProduct(ProductsEntity productsEntity, IFormFile File)
        {
            if (File != null)
            {
                Random generator = new Random();
                String random = generator.Next(0, 1000000).ToString("D6");
                string imgExt = Path.GetExtension(File.FileName);
                string fileName = File.FileName.Substring(0, File.FileName.IndexOf(".")) + "_" + random + imgExt;

                //string fileName = File.FileName;
                if (!Directory.Exists(Path.Combine(Directory.GetCurrentDirectory(), "product")))
                {
                    Directory.CreateDirectory(Path.Combine(Environment.CurrentDirectory, "product"));
                }

                //var dir = Directory.GetCurrentDirectory();
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "product", fileName);


                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await File.CopyToAsync(stream);
                    productsEntity.ImageName = "http://admin.myavana.com/product/" + fileName;
                }
            }
                var response = await MyavanaAdminApiClientFactory.Instance.SaveProducts(productsEntity);

            if (response.message == "Success")
                return Content("1");
            else
                return Content("0");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteProduct(ProductsEntity productsEntity)
        {
            var response = await MyavanaAdminApiClientFactory.Instance.DeleteProduct(productsEntity);

            if (response.message == "Success")
                return Content("1");
            else
                return Content("0");
        }

        public IActionResult ProductsCategory()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetProductsCategoryList([DataTablesRequest] DataTablesRequest dataRequest)
        {
            IEnumerable<ProductTypeCategoriesList> filterProductType = await MyavanaAdminApiClientFactory.Instance.GetProductsCategoryList();
            if (dataRequest.Orders.Any())
            {
                int sortColumnIndex = dataRequest.Orders.FirstOrDefault().Column;
                string sortDirection = dataRequest.Orders.FirstOrDefault().Dir;
                Func<ProductTypeCategoriesList, string> orderingFunctionString = null;
                switch (sortColumnIndex)
                {
                    case 0:
                        {
                            orderingFunctionString = (c => c.CategoryName);
                            filterProductType =
                                sortDirection == "asc"
                                    ? filterProductType.OrderBy(orderingFunctionString)
                                    : filterProductType.OrderByDescending(orderingFunctionString);
                            break;
                        }
                }
            }
            try
            {
                IEnumerable<ProductTypeCategoriesList> codes = filterProductType.Select(e => new ProductTypeCategoriesList
                {
                    ProductTypeId = e.ProductTypeId,
                    IsHair = e.IsHair,
                    IsRegimen = e.IsRegimen,
                    CategoryName = e.CategoryName
                }); //.OrderByDescending(x => x.CreatedOn);
                return Json(codes.ToDataTablesResponse(dataRequest, codes.Count()));

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public IActionResult ProductsType()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetProductsTypeList([DataTablesRequest] DataTablesRequest dataRequest)
        {
            IEnumerable<ProductTypeEntity> filterProductType = await MyavanaAdminApiClientFactory.Instance.GetProductType();
            if (dataRequest.Orders.Any())
            {
                int sortColumnIndex = dataRequest.Orders.FirstOrDefault().Column;
                string sortDirection = dataRequest.Orders.FirstOrDefault().Dir;
                Func<ProductTypeEntity, string> orderingFunctionString = null;
                switch (sortColumnIndex)
                {
                    case 0:
                        {
                            orderingFunctionString = (c => c.ProductName);
                            filterProductType =
                                sortDirection == "asc"
                                    ? filterProductType.OrderBy(orderingFunctionString)
                                    : filterProductType.OrderByDescending(orderingFunctionString);
                            break;
                        }
                }
            }
            try
            {
                IEnumerable<ProductTypeEntity> codes = filterProductType.Select(e => new ProductTypeEntity
                {
                    Id = e.Id,
                    ProductName = e.ProductName,
                    CreatedOn = e.CreatedOn,
                    IsActive = e.IsActive,
                    CategoryName = e.CategoryName
                }).OrderByDescending(x => x.CreatedOn);
                return Json(codes.ToDataTablesResponse(dataRequest, codes.Count()));

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<IActionResult> CreateProductCategory(string id)
        {
            if (id != null)
            {
                ProductTypeCategoriesList productTypeEntity = new ProductTypeCategoriesList();
                productTypeEntity.ProductTypeId = Convert.ToInt32(id);
                var response = await MyavanaAdminApiClientFactory.Instance.GetProductCategoryById(productTypeEntity);
                productTypeEntity = response.Data;
                return View(productTypeEntity);

            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateProductCategory(ProductTypeCategoriesList productTypeEntity)
        {
            var response = await MyavanaAdminApiClientFactory.Instance.SaveProductCategory(productTypeEntity);

            if (response.message == "Success")
                return Content("1");
            else
                return Content("0");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteProductType(ProductTypeEntity productTypeEntity)
        {
            var response = await MyavanaAdminApiClientFactory.Instance.DeleteProductType(productTypeEntity);

            if (response.message == "Success")
                return Content("1");
            else
                return Content("0");
        }

        public async Task<IActionResult> CreateProductType(string id)
        {
            if (id != null)
            {
                ProductTypeEntity productTypeEntity = new ProductTypeEntity();
                productTypeEntity.Id = Convert.ToInt32(id);
                var response = await MyavanaAdminApiClientFactory.Instance.GetProductTypeById(productTypeEntity);
                productTypeEntity = response.Data;
                return View(productTypeEntity);

            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateProductType(ProductTypeCategoryModel productTypeEntity)
        {
            var response = await MyavanaAdminApiClientFactory.Instance.SaveProductType(productTypeEntity);

            if (response.message == "Success")
                return Content("1");
            else
                return Content("0");
        }

        public IActionResult ProductIndicators()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetProductIndicatorsList([DataTablesRequest] DataTablesRequest dataRequest)
        {
            IEnumerable<IndicatorModel> filterProductType = await MyavanaAdminApiClientFactory.Instance.GetIndicators();
            if (dataRequest.Orders.Any())
            {
                int sortColumnIndex = dataRequest.Orders.FirstOrDefault().Column;
                string sortDirection = dataRequest.Orders.FirstOrDefault().Dir;
                Func<IndicatorModel, string> orderingFunctionString = null;
                switch (sortColumnIndex)
                {
                    case 0:
                        {
                            orderingFunctionString = (c => c.Description);
                            filterProductType =
                                sortDirection == "asc"
                                    ? filterProductType.OrderBy(orderingFunctionString)
                                    : filterProductType.OrderByDescending(orderingFunctionString);
                            break;
                        }
                    case 1:
                        {
                            orderingFunctionString = (c => c.CreatedDate);
                            filterProductType =
                                sortDirection == "asc"
                                    ? filterProductType.OrderBy(orderingFunctionString)
                                    : filterProductType.OrderByDescending(orderingFunctionString);
                            break;
                        }
                }
            }
            try
            {
                IEnumerable<IndicatorModel> codes = filterProductType.Select(e => new IndicatorModel
                {
                    ProductIndicatorId = e.ProductIndicatorId,
                    Description = e.Description,
                    CreatedDate = e.CreatedOn.ToString("yyyy-MM-dd"),//(DateTime.ParseExact(e.CreatedOn.ToString(), "dd-MM-yyyy hh:mm:ss",
                                   // CultureInfo.InvariantCulture)).ToString("yyyy-MM-dd"),
                IsActive = e.IsActive
                }).OrderByDescending(x => x.CreatedOn);
                return Json(codes.ToDataTablesResponse(dataRequest, codes.Count()));

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        [HttpPost]
        public async Task<IActionResult> DeleteIndicator(IndicatorModel indicatorModel)
        {
            var response = await MyavanaAdminApiClientFactory.Instance.DeleteProductIndicator(indicatorModel);

            if (response.message == "Success")
                return Content("1");
            else
                return Content("0");
        }

        public async Task<IActionResult> CreateIndicator(string id)
        {
            if (id != null)
            {
                IndicatorModel indicator = new IndicatorModel();
                indicator.ProductIndicatorId = Convert.ToInt32(id);
                var response = await MyavanaAdminApiClientFactory.Instance.GetProductIndicatorById(indicator);
                indicator = response.Data;
                return View(indicator);

            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateIndicator(IndicatorModel indicatorModel)
        {
            var response = await MyavanaAdminApiClientFactory.Instance.SaveIndicator(indicatorModel);

            if (response.message == "Success")
                return Content("1");
            else
                return Content("0");
        }


        [HttpPost]
        public async Task<IActionResult> DeleteProductCategory(ProductTypeEntity productTypeEntity)
        {
            var response = await MyavanaAdminApiClientFactory.Instance.DeleteProductCategory(productTypeEntity);

            if (response.message == "Success")
                return Content("1");
            else
                return Content("0");
        }

        [HttpPost]
        public async Task<IActionResult> UploadExcelsheet(ProductsData fileModel)
        {
            string fileName = fileModel.file.FileName.Replace(" ", "").Trim();
            string fileType = null;
            FileStream stream = null;
            if (!Directory.Exists(Path.Combine(Directory.GetCurrentDirectory(), "ProductsDocs")))
            {
                Directory.CreateDirectory(Path.Combine(Environment.CurrentDirectory, "ProductsDocs"));
            }
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "ProductsDocs", fileName);
            using (stream = new FileStream(path, FileMode.Create))
            {
                await fileModel.file.CopyToAsync(stream);
                fileType = Path.GetExtension(path);
            }

            var productModel = new List<ProductsEntity>();
            try
            {
                System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

                using (FileStream mStream = System.IO.File.Open("wwwroot/ProductsDocs/" + fileName, FileMode.Open, FileAccess.Read))
                {
                    try
                    {
                        IExcelDataReader reader = null;

                        if (fileType == ".csv") reader = ExcelReaderFactory.CreateCsvReader(mStream);
                        else reader = ExcelReaderFactory.CreateReader(mStream);
                    }
                    catch (Exception ex) { return Content("Your excel file version is old. Please save it in greater than 2007 version"); }
                    using (IExcelDataReader reader = fileType == ".csv" ? ExcelReaderFactory.CreateCsvReader(mStream) : ExcelReaderFactory.CreateReader(mStream))
                    {
                        var dataSet = reader.AsDataSet(new ExcelDataSetConfiguration
                        {
                            ConfigureDataTable = _ => new ExcelDataTableConfiguration
                            {
                                UseHeaderRow = true // To set First Row As Column Names  
                            }
                        });

                        if (dataSet.Tables.Count > 0)
                        {
                            var dataTable = dataSet.Tables[0];
                            int i = 2;
                            foreach (DataRow objDataRow in dataTable.Rows)
                            {
                                if (objDataRow.ItemArray.All(x => string.IsNullOrEmpty(x?.ToString()))) continue;

                                ProductsEntity productEntity = new ProductsEntity();

                                if (objDataRow["ProductName"] == null || objDataRow["ProductName"] is System.DBNull)
                                    return Content("ProductName is Empty at Row no : " + i);
                                else
                                    productEntity.ProductName = objDataRow["ProductName"].ToString();

                                if (objDataRow["ActualName"] == null || objDataRow["ActualName"] is System.DBNull)
                                    return Content("ActualName is Empty at Row no : " + i);
                                else
                                    productEntity.ActualName = objDataRow["ActualName"].ToString();

                                if (objDataRow["BrandName"] == null || objDataRow["BrandName"] is System.DBNull)
                                    return Content("BrandName is Empty at Row no : " + i);
                                else
                                    productEntity.BrandName = objDataRow["BrandName"].ToString();

                                if (objDataRow["ProductClassification"] == null || objDataRow["ProductClassification"] is System.DBNull)
                                    return Content("ProductClassification is Empty at Row no : " + i);
                                else
                                    productEntity.ProductClassification = objDataRow["ProductClassification"].ToString();

                                if (objDataRow["ProductType"] == null || objDataRow["ProductType"] is System.DBNull)
                                    return Content("ProductType is Empty at Row no : " + i);
                                else
                                    productEntity.ProductType = objDataRow["ProductType"].ToString();

                                productEntity.ProductIndicator = objDataRow["ProductIndicator"] is System.DBNull ? null : objDataRow["ProductIndicator"].ToString();

                                productEntity.HairChallenges = objDataRow["HairChallenges"] is System.DBNull ? null : objDataRow["HairChallenges"].ToString();

                                productEntity.ProductTags = objDataRow["ProductTags"] is System.DBNull ? null : objDataRow["ProductTags"].ToString();

                                if (objDataRow["TypeFor"] == null || objDataRow["TypeFor"] is System.DBNull)
                                    return Content("TypeFor is Empty at Row no : " + i);
                                else
                                    productEntity.TypeFor = objDataRow["TypeFor"].ToString();

                                productEntity.ImageName = objDataRow["ImageName"] is System.DBNull ? null : objDataRow["ImageName"].ToString();

                                productEntity.Ingredients = objDataRow["Ingredients"] is System.DBNull ? null : objDataRow["Ingredients"].ToString();

                                productEntity.ProductDetails = objDataRow["ProductDetails"] is System.DBNull ? null : objDataRow["ProductDetails"].ToString();

                                productEntity.ProductLink = objDataRow["ProductLink"] is System.DBNull ? null : objDataRow["ProductLink"].ToString();
                                try
                                {
                                    productEntity.Price = Convert.ToDecimal(objDataRow["Price"] is System.DBNull ? 0.00 : objDataRow["Price"]);
                                }
                                catch (Exception ex) { return Content("Please mention price in decimal format(0.00)"); }
                                productModel.Add(productEntity);
                                i++;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ApplicationSettings.WebApiUrl);

                var response = await MyavanaAdminApiClientFactory.Instance.AddProductList(productModel);
                if (response != null)
                    return Content("1");
            }
            return Content("0");

        }
    }
}
