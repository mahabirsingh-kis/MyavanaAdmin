#pragma checksum "D:\Work2022\My Avana\MyavanaAdminV2\MyavanaAdmin\MyavanaAdmin\Views\Questionnaire\CreateNewCustomer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80f618a4e9771a0e5fdd8750e2f55c2b3d1beb4d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Questionnaire_CreateNewCustomer), @"mvc.1.0.view", @"/Views/Questionnaire/CreateNewCustomer.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Questionnaire/CreateNewCustomer.cshtml", typeof(AspNetCore.Views_Questionnaire_CreateNewCustomer))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80f618a4e9771a0e5fdd8750e2f55c2b3d1beb4d", @"/Views/Questionnaire/CreateNewCustomer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e50bf59ee35ef0f48e0d229ad9de8458361f9630", @"/Views/_ViewImports.cshtml")]
    public class Views_Questionnaire_CreateNewCustomer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyavanaAdminModels.WebLogin>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/loader.gif"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/admin/intlTelInput.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/admin/intlTelInput-jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(172, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "D:\Work2022\My Avana\MyavanaAdminV2\MyavanaAdmin\MyavanaAdmin\Views\Questionnaire\CreateNewCustomer.cshtml"
  
    ViewData["Title"] = "CreateNewCustomer";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(366, 2148, true);
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

    .preloader {");
            WriteLiteral(@"
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
</style>
<div id=""alert-success"" class=""alert alert-success alert-dismissible"" style=""display:none; width:50%"" data-keyboard=""false"" data-backdrop=""static"">
    <a href=""#"" class=""close"" data-dismiss=""alert"" aria-label=""close"">&times;</a>
    <span id=""successMessage""></span>
</div>
<div class=""alert alert-danger alert-dismissible"" style=""display:none; width:50%"" data-keyboard=""false"" data-backdrop=""static"">
    <a href=""#"" class=""close"" data-dismiss=""alert"" aria-label=""close"">&times;</a>
    <span id=""failureMessage");
            WriteLiteral("\"></span>\r\n</div>\r\n<div class=\"preloader\" style=\"display:none;\">\r\n    <div class=\"loader\">\r\n        ");
            EndContext();
            BeginContext(2514, 33, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "80f618a4e9771a0e5fdd8750e2f55c2b3d1beb4d7102", async() => {
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
            BeginContext(2547, 323, true);
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
            BeginContext(2916, 1158, true);
            WriteLiteral(@"                    <div class=""form-group"">
                        <input id=""txtFirstName"" type=""text"" class=""form-control"" placeholder=""First Name*"">
                    </div>
                    <div class=""form-group"">
                        <input id=""txtLastName"" type=""text"" class=""form-control"" placeholder=""Last Name*"">
                    </div>
                    <div class=""form-group"">
                        <input id=""txtEmail"" type=""text"" class=""form-control"" placeholder=""Email*"">
                    </div>
                    <div class=""form-group"">
                        <input id=""txtPassword"" type=""password"" class=""form-control"" placeholder=""Password*"">
                    </div>
                    <div class=""form-group"">
                        <input id=""txtCPassword"" type=""password"" class=""form-control"" placeholder=""Re-Type Password*"">
                    </div>
                    <div class=""form-group"">
                        <div class=""form-group countrylist");
            WriteLiteral("dropdown\">\r\n                            <input id=\"txtCountryCode\" type=\"number\" maxlength=\"10\" class=\"form-control\" placeholder=\"\">\r\n");
            EndContext();
            BeginContext(4145, 1095, true);
            WriteLiteral(@"                        </div>

                        <div class=""form-group"">
                            <input id=""txtPhoneNo"" type=""text"" class=""form-control"" placeholder=""Phone Number*"">
                        </div>

                        <div>
                            <p>
                                Your phone number required so that we may contact you in regards to your hair consultation and support while using our app.Your privacy is very important to us; we do not share your phone number with other companies.
                            </p>
                        </div>
                        <div>
                            <p>
                                Registering will enable you to access the functionality of our app from any of your devices.
                            </p>
                        </div>

                        <button type=""submit"" onclick=""signupUser()"" class=""btn btn-primary block full-width mb-0"" style=""background:#EBC7C7; color:black""");
            WriteLiteral(">Signup</button>\r\n                    </div>>\r\n                </div>\r\n");
            EndContext();
            BeginContext(5269, 60, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(5329, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80f618a4e9771a0e5fdd8750e2f55c2b3d1beb4d11394", async() => {
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
            BeginContext(5383, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(5385, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80f618a4e9771a0e5fdd8750e2f55c2b3d1beb4d12574", async() => {
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
            BeginContext(5446, 570, true);
            WriteLiteral(@"
<script>
    function signupUser() {


        if ($('#txtEmail').val().trim() == '' || $('#txtFirstName').val().trim() == '' || $('#txtLastName').val().trim() == '' || $('#txtPhoneNo').val().trim() == '' ||
            $('#txtPassword').val().trim() == '' || $('#txtCPassword').val().trim() == '') {
            $('#failureMessage').text(""Please fill mandatory fields"");
            $('.alert-danger').css(""display"", ""block"");
            $('.alert-danger').delay(2000).fadeOut();
            return false;
        }

        if (!RegExp(/^[a-zA-Z0-9._-]+");
            EndContext();
            BeginContext(6017, 363, true);
            WriteLiteral(@"@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,6}$/).test($('#txtEmail').val().trim())) {
            $('#failureMessage').text(""Please enter valid email!"");
            $('.alert-danger').css(""display"", ""block"");
            $('.alert-danger').delay(2000).fadeOut();
            return false;
        }
        var pattern = new RegExp(/^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!");
            EndContext();
            BeginContext(6381, 2615, true);
            WriteLiteral(@"@#$%^&*()_+\-=\[\]{};':""\\|,.<>\/?]).{8,}$/);
        if (!pattern.test($('#txtCPassword').val().trim())) {
            $('#failureMessage').text(""Password pattern doesn't match. Must atleast 8 character length.One upper case, one lower case, one digit and 1 special chanracter"");
            $('.alert-danger').css(""display"", ""block"");
            $('.alert-danger').delay(3000).fadeOut();
            return false;
        }
        if ($('#txtCPassword').val().trim() != $('#txtPassword').val().trim()) {
            $('#failureMessage').text(""Password and confirm password doesn't match"");
            $('.alert-danger').css(""display"", ""block"");
            $('.alert-danger').delay(3000).fadeOut();
            return false;
        }

        if (! /^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$/.test($(""#txtPhoneNo"").val().trim())) {
            $('#failureMessage').text(""Enter valid phone no."");
            $('.alert-danger').css(""display"", ""block"");
            $('.alert-danger').delay(300");
            WriteLiteral(@"0).fadeOut();
            return false;
        }
        signup = {
            Email: $('#txtEmail').val().trim(),
            FirstName: $('#txtFirstName').val().trim(),
            LastName: $('#txtLastName').val().trim(),
            PhoneNo: $('#txtPhoneNo').val().trim(),
            CountryCode: $(""#txtCountryCode"").intlTelInput(""getSelectedCountryData"").dialCode,
            Password: $('#txtPassword').val().trim()
        }

        $.ajax({
            type: ""POST"",
            url: ""/Questionnaire/CreateNewCustomer"",
            data: signup,
            success: function (response) {
                if (response == ""0"") {
                    $('#failureMessage').text(""User already exist. Please try with different Username"");
                    $('.alert-danger').css(""display"", ""block"");
                    $('.alert-danger').delay(3000).fadeOut();

                }
                else if (response == ""-1"") {
                    $('#failureMessage').text(""Something went w");
            WriteLiteral(@"rong. Please try later"");
                    $('.alert-danger').css(""display"", ""block"");
                    $('.alert-danger').delay(3000).fadeOut();

                    //$('#txtLogin').val(''),
                    //$('#txtPassword').val('')
                }
                else {
                    window.location.href = ""/Questionnaire/QuestionnaireCustomer""
                }

            },
            failure: function (response) {
            },
            error: function (response) {
            },
        });
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
