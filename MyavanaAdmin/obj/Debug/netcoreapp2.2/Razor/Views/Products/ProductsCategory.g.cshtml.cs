#pragma checksum "D:\Work2022\My Avana\MyavanaAdminV2\MyavanaAdmin\MyavanaAdmin\Views\Products\ProductsCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce596c7866061b495ce038635718a2f4cdbbe590"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_ProductsCategory), @"mvc.1.0.view", @"/Views/Products/ProductsCategory.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Products/ProductsCategory.cshtml", typeof(AspNetCore.Views_Products_ProductsCategory))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\Work2022\My Avana\MyavanaAdminV2\MyavanaAdmin\MyavanaAdmin\Views\_ViewImports.cshtml"
using MyavanaAdmin;

#line default
#line hidden
#line 2 "D:\Work2022\My Avana\MyavanaAdminV2\MyavanaAdmin\MyavanaAdmin\Views\_ViewImports.cshtml"
using MyavanaAdmin.Models;

#line default
#line hidden
#line 3 "D:\Work2022\My Avana\MyavanaAdminV2\MyavanaAdmin\MyavanaAdmin\Views\Products\ProductsCategory.cshtml"
using DataTables.AspNetCore.Mvc;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce596c7866061b495ce038635718a2f4cdbbe590", @"/Views/Products/ProductsCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e50bf59ee35ef0f48e0d229ad9de8458361f9630", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_ProductsCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/loader.gif"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/admin/ProductCategory.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "D:\Work2022\My Avana\MyavanaAdminV2\MyavanaAdmin\MyavanaAdmin\Views\Products\ProductsCategory.cshtml"
  
    ViewData["Title"] = "ProductsCategory";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(269, 2680, true);
            WriteLiteral(@"
<style>
    .green-color {
        color: green;
    }
    .preloader {
        width: calc(100% - 200px);
        height: 100%;
        top: 0px;
        position: fixed;
        z-index: 99999;
        background: rgba(255, 255, 255, .8);
    }

        .preloader img {
            position: absolute;
            LEFT: 50%;
            top: 50%;
            transform: translate(-50%, -50%);
            width: 80px;
        }

    .loader {
        overflow: visible;
        padding-top: 2em;
        height: 0;
        width: 2em;
    }

    .alert-success, .alert-danger, .alert-info {
        top: 110px !important;
        width: 60% !important;
        margin: 0 auto;
        z-index: 99;
        position: fixed;
        left: 50%;
        transform: translateX(-40%);
        text-align: center;
        padding: 12px;
        transition: all 1s linear;
        box-shadow: 0px 0px 12px 3px rgba(0, 0, 0, 0.2);
        font-size: 16px;
    }

    .alert-danger {
 ");
            WriteLiteral(@"       color: #80172a;
        background-color: #fdd5dc;
        border-color: #fcc4ce;
    }

        .alert-danger hr {
            border-top-color: #fbacba;
        }

        .alert-danger .alert-link {
            color: #550f1c;
        }

    .alert-success {
        color: #1c6356;
        background-color: #a8ffc3;
        border-color: #13b755;
    }

        .alert-success hr {
            border-top-color: #b4e7dd;
        }

        .alert-success .alert-link {
            color: #113b33;
        }

    span.align-right {
        text-align: right;
    }

    .addnewbtn {
        padding: 20px 10px 0;
    }

    i.fa.fa-pencil {
        color: #1ab394;
        background: #e2e2e2;
        padding: 7px;
        border-radius: 4px;
    }

        i.fa.fa-pencil:hover {
            background: #cecece
        }

    i.fa.fa-trash:hover {
        background: #cecece
    }

    i.fa.fa-trash {
        color: red;
        background: #e2e2e2;
     ");
            WriteLiteral(@"   padding: 7px;
        border-radius: 4px;
        margin-top: 10px;
    }

    div#ProductTypeList_filter input[type=search] {
        border: 1px solid #ccc;
    }

    i.fa.fa-pencil {
        color: #1ab394;
        margin-right: 5px;
    }

    i.fa.fa-trash {
        color: red;
    }

    tr.odd td {
        background: #f8f8f8 !important;
    }

    tr.odd:hover td, tr.even:hover td {
        background: #eee !important;
    }

    tr.even td {
        background: #fff !important;
    }
</style>
<div class=""addnewbtn"">
    <span class=""align-right"">
        <a class=""btn btn-primary""");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2949, "\"", 3004, 1);
#line 138 "D:\Work2022\My Avana\MyavanaAdminV2\MyavanaAdmin\MyavanaAdmin\Views\Products\ProductsCategory.cshtml"
WriteAttributeValue("", 2956, Url.Action("CreateProductCategory", "Products"), 2956, 48, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3005, 414, true);
            WriteLiteral(@">Add New Product Category</a>
    </span>
</div>
<div id=""alert-success"" class=""alert alert-success alert-dismissible"" style=""display:none; width:50%"" data-keyboard=""false"" data-backdrop=""static"">
    <a href=""#"" class=""close"" data-dismiss=""alert"" aria-label=""close"">&times;</a>
    <span id=""successMessage""></span>
</div>

<div class=""preloader"" style=""display:none;"">
    <div class=""loader"">
        ");
            EndContext();
            BeginContext(3419, 33, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ce596c7866061b495ce038635718a2f4cdbbe5908113", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3452, 1290, true);
            WriteLiteral(@"
    </div>
</div>

<div class=""wrapper wrapper-content animated fadeInRight"">
    <div class=""row"">
        <div class=""col-lg-12"">
            <div class=""ibox "">
                <div class=""ibox-title"">
                    <h5>Product Categories</h5>

                    <div class=""ibox-tools"">
                        <a class=""collapse-link"">
                            <i class=""fa fa-chevron-up""></i>
                        </a>
                        <a class=""dropdown-toggle"" data-toggle=""dropdown"" href=""#"">
                            <i class=""fa fa-wrench""></i>
                        </a>
                        <ul class=""dropdown-menu dropdown-user"">
                            <li>
                                <a href=""#"" class=""dropdown-item"">Config option 1</a>
                            </li>
                            <li>
                                <a href=""#"" class=""dropdown-item"">Config option 2</a>
                            </li>
                  ");
            WriteLiteral(@"      </ul>
                        <a class=""close-link"">
                            <i class=""fa fa-times""></i>
                        </a>
                    </div>
                </div>
                <div class=""ibox-content"">

                    ");
            EndContext();
            BeginContext(4744, 1355, false);
#line 181 "D:\Work2022\My Avana\MyavanaAdminV2\MyavanaAdmin\MyavanaAdmin\Views\Products\ProductsCategory.cshtml"
                Write(Html.Ext().Grid<MyavanaAdminModels.ProductTypeCategoriesList>().Name("ProductTypeList")
                                                .Columns(cols =>
                                                {
                                                    cols.Add(c => c.CategoryName).Title("Product Category");
                                                    cols.Add(c => c.IsHair).Title("Hair Regimen").Render(() => "onRenderHair");
                                                    cols.Add(c => c.IsRegimen).Title("Styling Regimen").Render(() => "onRenderRegimen");
                                                    cols.Add(c => c.ProductTypeId).Title("Actions").Orderable(false).Render(() => "onRenderProductType");
                                                })
                                                .ServerSide(false)
                                                .Ordering(false)
                                                .Paging(true)
                                                .Searching(true)
                                                .Info(false)
                                                .DataSource(c =>
                                                c.Ajax().Url("GetProductsCategoryList").Method("Get")
                                                )
                    );

#line default
#line hidden
            EndContext();
            BeginContext(6100, 1078, true);
            WriteLiteral(@"

                </div>
            </div>
        </div>
    </div>
</div>

<div class=""modal fade"" id=""confirmModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""confirmModal"" aria-hidden=""true"" data-keyboard=""false"" data-backdrop=""static"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 id=""confirmModalHeader"" class=""font-bold"">Delete</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <span id=""confirmModalText""></span>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" id=""cancelMethod"" data-dismiss=""modal"">Cancel</button>
                <button type=""button"" class=""btn btn-primary"" id=""confirmMethod"">Save</button>
  ");
            WriteLiteral("          </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
            BeginContext(7178, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce596c7866061b495ce038635718a2f4cdbbe59013523", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7231, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
