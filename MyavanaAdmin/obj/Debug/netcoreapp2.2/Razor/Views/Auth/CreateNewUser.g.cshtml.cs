#pragma checksum "D:\Work2022\My Avana\MyavanaAdminV2\MyavanaAdmin\MyavanaAdmin\Views\Auth\CreateNewUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50d631af994f8dfa34738190a1842598f8c97ff8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Auth_CreateNewUser), @"mvc.1.0.view", @"/Views/Auth/CreateNewUser.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Auth/CreateNewUser.cshtml", typeof(AspNetCore.Views_Auth_CreateNewUser))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50d631af994f8dfa34738190a1842598f8c97ff8", @"/Views/Auth/CreateNewUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e50bf59ee35ef0f48e0d229ad9de8458361f9630", @"/Views/_ViewImports.cshtml")]
    public class Views_Auth_CreateNewUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyavanaAdminModels.WebLogin>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/loader.gif"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("txtEmail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Enter email"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-white btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Auth", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Users", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(172, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "D:\Work2022\My Avana\MyavanaAdminV2\MyavanaAdmin\MyavanaAdmin\Views\Auth\CreateNewUser.cshtml"
  
    ViewData["Title"] = "CreateNewUser";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#line 9 "D:\Work2022\My Avana\MyavanaAdminV2\MyavanaAdmin\MyavanaAdmin\Views\Auth\CreateNewUser.cshtml"
 if (Model != null)
{

#line default
#line hidden
            BeginContext(294, 36, true);
            WriteLiteral("    <input type=\"hidden\" id=\"userId\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 330, "\"", 351, 1);
#line 11 "D:\Work2022\My Avana\MyavanaAdminV2\MyavanaAdmin\MyavanaAdmin\Views\Auth\CreateNewUser.cshtml"
WriteAttributeValue("", 338, Model.UserId, 338, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(352, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 12 "D:\Work2022\My Avana\MyavanaAdminV2\MyavanaAdmin\MyavanaAdmin\Views\Auth\CreateNewUser.cshtml"
}

#line default
#line hidden
            BeginContext(360, 2146, true);
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
    .preloader {
 ");
            WriteLiteral(@"       width: calc(100% - 200px);
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
</style>
<div id=""alert-success"" class=""alert alert-success alert-dismissible"" style=""display:none; width:50%"" data-keyboard=""false"" data-backdrop=""static"">
    <a href=""#"" class=""close"" data-dismiss=""alert"" aria-label=""close"">&times;</a>
    <span id=""successMessage""></span>
</div>
<div class=""alert alert-danger alert-dismissible"" style=""display:none; width:50%"" data-keyboard=""false"" data-backdrop=""static"">
    <a href=""#"" class=""close"" data-dismiss=""alert"" aria-label=""close"">&times;</a>
    <span id=""failureMessage"">");
            WriteLiteral("</span>\r\n</div>\r\n<div class=\"preloader\" style=\"display:none;\">\r\n    <div class=\"loader\">\r\n        ");
            EndContext();
            BeginContext(2506, 33, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "50d631af994f8dfa34738190a1842598f8c97ff89674", async() => {
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
            BeginContext(2539, 323, true);
            WriteLiteral(@"
    </div>
</div>
<div class=""wrapper wrapper-content animated fadeInRight"">
    <div class=""row"">
        <div class=""col-lg-12"">
            <div class=""ibox "">
                <div class=""ibox-title"">
                    <h5>Post User</h5>

                </div>
                <div class=""ibox-content"">
");
            EndContext();
            BeginContext(2908, 212, true);
            WriteLiteral("                    <div class=\"form-group  row\">\r\n                        <label class=\"col-sm-2 col-form-label\">User Email*</label>\r\n                        <div class=\"col-sm-10\">\r\n                            ");
            EndContext();
            BeginContext(3120, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "50d631af994f8dfa34738190a1842598f8c97ff811505", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#line 107 "D:\Work2022\My Avana\MyavanaAdminV2\MyavanaAdmin\MyavanaAdmin\Views\Auth\CreateNewUser.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.UserEmail);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3220, 262, true);
            WriteLiteral(@"
                        </div>
                    </div>
                    <div class=""hr-line-dashed""></div>

                    <div class=""form-group row"">
                        <div class=""col-sm-4 col-sm-offset-2"">
                            ");
            EndContext();
            BeginContext(3482, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "50d631af994f8dfa34738190a1842598f8c97ff813780", async() => {
                BeginContext(3555, 6, true);
                WriteLiteral("Cancel");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3565, 185, true);
            WriteLiteral("\r\n                            <button class=\"btn btn-primary btn-sm btnColorChange\" onclick=\"SaveUser()\">Save user</button>\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
            BeginContext(3783, 2113, true);
            WriteLiteral(@"                </div>
            </div>
        </div>
    </div>
</div>
<script>
    var userList = [];
	$(document).ready(function () {
		$('.preloader').css('display', 'block');
        $.ajax({
            type: ""GET"",
            url: ""/Auth/GetAllUsers"",
            async: true,
            success: function (response) {
				userList = response;
				$('.preloader').css('display', 'none');
            },
            error: function (response) {

            },
            complete: function () {

            }
        });
    });
    function SaveUser() {
        if (!ValidateUser()) {
            return false;
        }

        var webLogin = {
            UserId: $('#userId').val(),
            UserEmail: $('#txtEmail').val().trim()
        }
        $('.preloader').css('display', 'block');
        $.ajax({
            type: ""POST"",
            url: ""/Auth/CreateNewUser"",
            data: webLogin,
            success: function (response) {
                if");
            WriteLiteral(@" (response == ""1"") {
                    $('#successMessage').text(""User saved/updated successfully !"");
                    $('.alert-success').css(""display"", ""block"");
                    $('.alert-success').delay(3000).fadeOut();
                    setTimeout(function () { window.location.href = '/Auth/Users'; }, 3000);
                }
                else {
                    $('#failureMessage').text(""Oops something goes wrong !"");
                    $('.alert-danger').css(""display"", ""block"");
                    $('.alert-danger').delay(3000).fadeOut();
                }

                $('.preloader').css('display', 'none');
            },
        });
    }
    // vallidate user fields
    function ValidateUser() {
        var validUser = true;
        if ($('#txtEmail').val().trim() == """") {
            $('#failureMessage').text(""Please enter email !"");
            $('.alert-danger').css(""display"", ""block"");
            $('.alert-danger').delay(3000).fadeOut();
           ");
            WriteLiteral(" validUser = false;\r\n        } else if (!RegExp(/^[a-zA-Z0-9._-]+");
            EndContext();
            BeginContext(5897, 747, true);
            WriteLiteral(@"@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,6}$/).test($('#txtEmail').val().trim())) {
            $('#failureMessage').text(""Please enter valid email!"");
            $('.alert-danger').css(""display"", ""block"");
            $('.alert-danger').delay(3000).fadeOut();
            validUser = false;
        }

        userList.forEach(function (db, i) {
            if (db.UserEmail.toLowerCase() == $('#txtEmail').val().toLowerCase().trim()) {
                $('#failureMessage').text(""This email is already registered!"");
                $('.alert-danger').css(""display"", ""block"");
                $('.alert-danger').delay(2000).fadeOut();
                validUser = false;
            }
        });
        return validUser;
    }
</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyavanaAdminModels.WebLogin> Html { get; private set; }
    }
}
#pragma warning restore 1591
