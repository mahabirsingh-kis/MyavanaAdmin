#pragma checksum "D:\Work2022\My Avana\MyavanaAdminV2\MyavanaAdmin\MyavanaAdmin\Views\HairProfile\HairProfiles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4351f08d8b4677c526db0d739ce7bed49def03f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HairProfile_HairProfiles), @"mvc.1.0.view", @"/Views/HairProfile/HairProfiles.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/HairProfile/HairProfiles.cshtml", typeof(AspNetCore.Views_HairProfile_HairProfiles))]
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
#line 3 "D:\Work2022\My Avana\MyavanaAdminV2\MyavanaAdmin\MyavanaAdmin\Views\HairProfile\HairProfiles.cshtml"
using DataTables.AspNetCore.Mvc;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4351f08d8b4677c526db0d739ce7bed49def03f0", @"/Views/HairProfile/HairProfiles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e50bf59ee35ef0f48e0d229ad9de8458361f9630", @"/Views/_ViewImports.cshtml")]
    public class Views_HairProfile_HairProfiles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyavanaAdminModels.HairProfileCustomersModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/footable/css/footable.core.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/footable/dist/footable.all.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/HairProfile/HairProfile.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 7 "D:\Work2022\My Avana\MyavanaAdminV2\MyavanaAdmin\MyavanaAdmin\Views\HairProfile\HairProfiles.cshtml"
  
    ViewData["Title"] = "Hair Profiles";
    Layout = "~/Views/Shared/_Layout.cshtml";
    var hairList = hairProfile.GetHairProfileCustomerList().Result.Where(x => x.CustomerType.ToString() == HttpContextAccessor.HttpContext.Request.Cookies["UserType"].ToString()).ToList();

#line default
#line hidden
            BeginContext(638, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(642, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4351f08d8b4677c526db0d739ce7bed49def03f05434", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(711, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(713, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4351f08d8b4677c526db0d739ce7bed49def03f06686", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(776, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(778, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4351f08d8b4677c526db0d739ce7bed49def03f07863", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(844, 1336, true);
            WriteLiteral(@"
<div id=""alert-success"" class=""alert alert-success alert-dismissible"" style=""display:none; width:50%"" data-keyboard=""false"" data-backdrop=""static"">
    <a href=""#"" class=""close"" data-dismiss=""alert"" aria-label=""close"">&times;</a>
    <span id=""successMessage""></span>
</div>

<div class=""wrapper wrapper-content animated fadeInRight"">
    <div class=""row"">
        <div class=""col-lg-12"">
            <div class=""ibox "">
                <div class=""ibox-title"">
                    <h5>Hair Profiles</h5>

                    <div class=""ibox-tools"">
                        <label class=""mr-1"" style=""color: #333;"">Search:</label>
                        <input type=""text"" id=""hairProfile"" />
                    </div>
                </div>
                <div class=""ibox-content"">

                    <table class=""footable table table-stripped toggle-arrow-tiny"" id=""hairProfileTable"" data-page-size=""8"">
                        <thead>
                            <tr>

                   ");
            WriteLiteral(@"             <th>Name</th>
                                <th>Email</th>
                                <th>Created On <span>(yyyy-mm-dd)</span></th>
                                <th>Hair Profile</th>
                            </tr>
                        </thead>
                        <tbody>
");
            EndContext();
#line 47 "D:\Work2022\My Avana\MyavanaAdminV2\MyavanaAdmin\MyavanaAdmin\Views\HairProfile\HairProfiles.cshtml"
                             if (hairList.Count > 0)
                            {
                                

#line default
#line hidden
#line 49 "D:\Work2022\My Avana\MyavanaAdminV2\MyavanaAdmin\MyavanaAdmin\Views\HairProfile\HairProfiles.cshtml"
                                 foreach (var quest in hairList)
                                {

#line default
#line hidden
            BeginContext(2366, 86, true);
            WriteLiteral("                                    <tr>\r\n                                        <td>");
            EndContext();
            BeginContext(2453, 14, false);
#line 52 "D:\Work2022\My Avana\MyavanaAdminV2\MyavanaAdmin\MyavanaAdmin\Views\HairProfile\HairProfiles.cshtml"
                                       Write(quest.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(2467, 97, true);
            WriteLiteral("</td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(2565, 15, false);
#line 54 "D:\Work2022\My Avana\MyavanaAdminV2\MyavanaAdmin\MyavanaAdmin\Views\HairProfile\HairProfiles.cshtml"
                                       Write(quest.UserEmail);

#line default
#line hidden
            EndContext();
            BeginContext(2580, 141, true);
            WriteLiteral("\r\n\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(2722, 51, false);
#line 58 "D:\Work2022\My Avana\MyavanaAdminV2\MyavanaAdmin\MyavanaAdmin\Views\HairProfile\HairProfiles.cshtml"
                                       Write(quest.CreatedOn.ToString("yyyy-MM-dd  HH:mm:ss tt"));

#line default
#line hidden
            EndContext();
            BeginContext(2773, 141, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2914, "\"", 2970, 2);
            WriteAttributeValue("", 2921, "/HairProfile/CustomerHairProfile?id=", 2921, 36, true);
#line 61 "D:\Work2022\My Avana\MyavanaAdminV2\MyavanaAdmin\MyavanaAdmin\Views\HairProfile\HairProfiles.cshtml"
WriteAttributeValue("", 2957, quest.UserId, 2957, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2971, 180, true);
            WriteLiteral(" Title=\"Move to hair profile\"><i class=\"fa fa-user viewuser\" aria-hidden=\"true\"></i></a>\r\n                                        </td>\r\n                                    </tr>\r\n");
            EndContext();
#line 64 "D:\Work2022\My Avana\MyavanaAdminV2\MyavanaAdmin\MyavanaAdmin\Views\HairProfile\HairProfiles.cshtml"
                                }

#line default
#line hidden
#line 64 "D:\Work2022\My Avana\MyavanaAdminV2\MyavanaAdmin\MyavanaAdmin\Views\HairProfile\HairProfiles.cshtml"
                                 
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(3282, 182, true);
            WriteLiteral("                                <tr><td>  <span>  <strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;No data to display</strong></span></td></tr>\r\n");
            EndContext();
#line 69 "D:\Work2022\My Avana\MyavanaAdminV2\MyavanaAdmin\MyavanaAdmin\Views\HairProfile\HairProfiles.cshtml"
                            }

#line default
#line hidden
            BeginContext(3495, 892, true);
            WriteLiteral(@"                        </tbody>
                        <tfoot>
                            <tr>
                                <td colspan=""5"">
                                    <ul class=""pagination float-right""></ul>
                                </td>
                            </tr>
                        </tfoot>
                    </table>

                </div>
            </div>
        </div>
    </div>
</div>
<script type=""text/javascript"">
    $(document).ready(function () {
        $('.footable').footable();
        $('.footable2').footable();
    });

    //search box jquery
    $(""#hairProfile"").on(""keyup"", function () {
        var value = $(this).val().toLowerCase();
        $(""#hairProfileTable tr"").filter(function () {
            $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
        });
    });
</script>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Http.IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public MyavanaAdminApiClient.ApiClient hairProfile { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyavanaAdminModels.HairProfileCustomersModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
