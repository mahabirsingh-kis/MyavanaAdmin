#pragma checksum "D:\Work2022\My Avana\MyavanaAdminV2\MyavanaAdmin\MyavanaAdmin\Views\Groups\GroupList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e3f8f407c2cf377bb8f91a9093db6037f50621d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Groups_GroupList), @"mvc.1.0.view", @"/Views/Groups/GroupList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Groups/GroupList.cshtml", typeof(AspNetCore.Views_Groups_GroupList))]
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
#line 3 "D:\Work2022\My Avana\MyavanaAdminV2\MyavanaAdmin\MyavanaAdmin\Views\Groups\GroupList.cshtml"
using DataTables.AspNetCore.Mvc;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e3f8f407c2cf377bb8f91a9093db6037f50621d", @"/Views/Groups/GroupList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e50bf59ee35ef0f48e0d229ad9de8458361f9630", @"/Views/_ViewImports.cshtml")]
    public class Views_Groups_GroupList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyavanaAdminModels.GroupsModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/footable/css/footable.core.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/footable/dist/footable.all.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/admin/group.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 6 "D:\Work2022\My Avana\MyavanaAdminV2\MyavanaAdmin\MyavanaAdmin\Views\Groups\GroupList.cshtml"
  
    ViewData["Title"] = "GroupList";
    Layout = "~/Views/Shared/_Layout.cshtml";
    var groupList = group.GetGroupList().Result;

#line default
#line hidden
            BeginContext(398, 4378, true);
            WriteLiteral(@"
<style>
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
        color: #80172a;
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

    span.align-ri");
            WriteLiteral(@"ght {
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
        padding: 7px;
        border-radius: 4px;
        margin-top: 10px;
    }

    div#RegimensList_filter input[type=search] {
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

    .ibox-content table {
       ");
            WriteLiteral(@" display: block;
        width: 100%;
        overflow-x: auto;
        -webkit-overflow-scrolling: touch;
    }

        .ibox-content table td {
            vertical-align: top;
        }

    .instruction-width {
        min-width: 200px;
    }

    .ibox-content table {
        display: table;
    }

    .ibox-content th.footable-visible.footable-last-column.footable-sortable {
        width: 120px;
    }

    .ibox-content td.footable-last-column.footable-visible.footable-last-column {
        text-align: right;
    }

    .ibox-content .footable-row-detail-inner {
        display: table;
        width: 100%;
    }

    .ibox-content .footable-row-detail-value {
        border-bottom: 1px solid #eee;
        padding: 15px 0;
    }

    .ibox-content td.footable-last-column.footable-visible {
        padding-top: 0;
    }

    .ibox-content .instrustioncontent {
        max-height: 100px;
        overflow-y: auto;
    }

    .stgQuestion {
        /* border-le");
            WriteLiteral(@"ft: 2px solid #383838;*/
        padding-left: 3px;
        margin-bottom: 5px !important;
        margin-top: 15px;
    }

    .divAnswer {
        padding-left: 20px;
        /* margin-bottom: 5px; */
        position: relative;
        background: #ececec;
        padding-top: 5px;
        padding-bottom: 5px;
        border-bottom: 1px solid #dadada;
    }

    .viewuser {
        background: #eee;
        padding: 5px 7px;
        border-radius: 4px;
        border: 1px solid #ccc;
        margin-top: 5px;
        color: #1ab394;
    }

    .viewdraft {
        background: #eee;
        padding: 5px 7px;
        border-radius: 4px;
        border: 1px solid #ccc;
        margin-top: 5px;
        color: #333;
        cursor: auto;
    }

    .dvUsersMain {
        background: #eee;
        padding: 7px 15px;
    }
        .dvUsersMain span {
            min-width: 30%;
        }
    .dvUsers {
        padding: 7px 15px;
        border-bottom: 1px solid #eee;
  ");
            WriteLiteral(@"  }
        .dvUsers span {
            min-width: 30%;
        }
    .ibox-content td.footable-last-column.footable-visible.footable-last-column {
        text-align: left;
    }
    .ibox-content .footable-row-detail-value {
        border-bottom: none;
    }
</style>
");
            EndContext();
            BeginContext(4776, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6e3f8f407c2cf377bb8f91a9093db6037f50621d9692", async() => {
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
            BeginContext(4845, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(4847, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e3f8f407c2cf377bb8f91a9093db6037f50621d10946", async() => {
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
            BeginContext(4910, 394, true);
            WriteLiteral(@"

<div id=""alert-success"" class=""alert alert-success alert-dismissible"" style=""display:none; width:50%"" data-keyboard=""false"" data-backdrop=""static"">
    <a href=""#"" class=""close"" data-dismiss=""alert"" aria-label=""close"">&times;</a>
    <span id=""successMessage""></span>
</div>
<h1>GroupList</h1>
<div class=""addnewbtn"">
    <span class=""align-right"">
        <a class=""btn btn-primary""");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 5304, "\"", 5347, 1);
#line 225 "D:\Work2022\My Avana\MyavanaAdminV2\MyavanaAdmin\MyavanaAdmin\Views\Groups\GroupList.cshtml"
WriteAttributeValue("", 5311, Url.Action("CreateGroup", "Groups"), 5311, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5348, 192, true);
            WriteLiteral(">Add New Group</a>\r\n    </span>\r\n</div>\r\n\r\n<div class=\"wrapper wrapper-content animated fadeInRight\">\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-12\">\r\n            <div class=\"ibox \">\r\n");
            EndContext();
            BeginContext(5878, 531, true);
            WriteLiteral(@"                <div class=""ibox-content"">

                    <table class=""footable table table-stripped toggle-arrow-tiny"" id=""groupTable"" data-page-size=""15"">
                        <thead>
                            <tr>

                                <th data-toggle=""true"">Group Name</th>
                                <th data-hide=""all""></th>
                                <th>Action</th>
                            </tr>
                        </thead>
                        <tbody id=""myTable"">
");
            EndContext();
#line 253 "D:\Work2022\My Avana\MyavanaAdminV2\MyavanaAdmin\MyavanaAdmin\Views\Groups\GroupList.cshtml"
                             if (groupList.Count > 0)
                            {
                                

#line default
#line hidden
#line 255 "D:\Work2022\My Avana\MyavanaAdminV2\MyavanaAdmin\MyavanaAdmin\Views\Groups\GroupList.cshtml"
                                 foreach (var group in groupList)
                                {

#line default
#line hidden
            BeginContext(6597, 140, true);
            WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            <strong>");
            EndContext();
            BeginContext(6738, 14, false);
#line 259 "D:\Work2022\My Avana\MyavanaAdminV2\MyavanaAdmin\MyavanaAdmin\Views\Groups\GroupList.cshtml"
                                               Write(group.HairType);

#line default
#line hidden
            EndContext();
            BeginContext(6752, 377, true);
            WriteLiteral(@"</strong>
                                        </td>
                                        <td>
                                            <div class=""d-flex dvUsersMain"">
                                                <span>UserEmail</span>
                                                <span>UserName</span>
                                            </div>
");
            EndContext();
#line 266 "D:\Work2022\My Avana\MyavanaAdminV2\MyavanaAdmin\MyavanaAdmin\Views\Groups\GroupList.cshtml"
                                             foreach (var user in group.Users)
                                            {

#line default
#line hidden
            BeginContext(7256, 138, true);
            WriteLiteral("                                                <div class=\"d-flex  dvUsers\">\r\n                                                    <span> ");
            EndContext();
            BeginContext(7395, 14, false);
#line 269 "D:\Work2022\My Avana\MyavanaAdminV2\MyavanaAdmin\MyavanaAdmin\Views\Groups\GroupList.cshtml"
                                                      Write(user.UserEmail);

#line default
#line hidden
            EndContext();
            BeginContext(7409, 67, true);
            WriteLiteral("</span>\r\n                                                    <span>");
            EndContext();
            BeginContext(7477, 13, false);
#line 270 "D:\Work2022\My Avana\MyavanaAdminV2\MyavanaAdmin\MyavanaAdmin\Views\Groups\GroupList.cshtml"
                                                     Write(user.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(7490, 65, true);
            WriteLiteral("</span>\r\n                                                </div>\r\n");
            EndContext();
#line 272 "D:\Work2022\My Avana\MyavanaAdminV2\MyavanaAdmin\MyavanaAdmin\Views\Groups\GroupList.cshtml"
                                            }

#line default
#line hidden
            BeginContext(7602, 139, true);
            WriteLiteral("                                        </td>\r\n                                        <td>\r\n                                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 7741, "\"", 7792, 2);
            WriteAttributeValue("", 7748, "/Groups/CreateGroup?hairtype=", 7748, 29, true);
#line 275 "D:\Work2022\My Avana\MyavanaAdminV2\MyavanaAdmin\MyavanaAdmin\Views\Groups\GroupList.cshtml"
WriteAttributeValue("", 7777, group.HairType, 7777, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7793, 155, true);
            WriteLiteral(" Title=\"Update Group\"><i class=\"fa fa-pencil\" aria-hidden=\"true\"></i></a>\r\n                                            <a Title=\"Delete Group\" class=\"ml-2\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 7948, "\"", 7995, 3);
            WriteAttributeValue("", 7958, "deleteConfirmGroup(\'", 7958, 20, true);
#line 276 "D:\Work2022\My Avana\MyavanaAdminV2\MyavanaAdmin\MyavanaAdmin\Views\Groups\GroupList.cshtml"
WriteAttributeValue("", 7978, group.HairType, 7978, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 7993, "\')", 7993, 2, true);
            EndWriteAttribute();
            BeginContext(7996, 143, true);
            WriteLiteral("><i class=\"fa fa-trash\" aria-hidden=\"true\"></i></a>\r\n                                        </td>\r\n                                    </tr>\r\n");
            EndContext();
#line 279 "D:\Work2022\My Avana\MyavanaAdminV2\MyavanaAdmin\MyavanaAdmin\Views\Groups\GroupList.cshtml"
                                }

#line default
#line hidden
#line 279 "D:\Work2022\My Avana\MyavanaAdminV2\MyavanaAdmin\MyavanaAdmin\Views\Groups\GroupList.cshtml"
                                 
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(8270, 182, true);
            WriteLiteral("                                <tr><td>  <span>  <strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;No data to display</strong></span></td></tr>\r\n");
            EndContext();
#line 284 "D:\Work2022\My Avana\MyavanaAdminV2\MyavanaAdmin\MyavanaAdmin\Views\Groups\GroupList.cshtml"
                            }

#line default
#line hidden
            BeginContext(8483, 1449, true);
            WriteLiteral(@"                        </tbody>
                        <tfoot>
                            <tr>
                                <td colspan=""2"">
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

<div class=""modal fade"" id=""confirmModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""confirmModal"" aria-hidden=""true"" data-keyboard=""false"" data-backdrop=""static"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 id=""confirmModalHeader"" class=""font-bold"">Delete</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
    ");
            WriteLiteral(@"        <div class=""modal-body"">
                <span id=""confirmModalText""></span>

            </div>

            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" id=""cancelMethod"" data-dismiss=""modal"">Cancel</button>
                <button type=""button"" class=""btn btn-primary"" id=""confirmMethod"">Save</button>
            </div>
        </div>
    </div>
</div>

");
            EndContext();
            BeginContext(9932, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e3f8f407c2cf377bb8f91a9093db6037f50621d21117", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(9975, 167, true);
            WriteLiteral("\r\n<script type=\"text/javascript\">\r\n    $(document).ready(function () {\r\n        $(\'.footable\').footable();\r\n        $(\'.footable2\').footable();\r\n    });\r\n</script>\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public MyavanaAdminApiClient.ApiClient group { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyavanaAdminModels.GroupsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591