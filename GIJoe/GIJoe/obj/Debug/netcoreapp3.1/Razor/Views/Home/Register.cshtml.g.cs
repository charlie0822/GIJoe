#pragma checksum "C:\Users\B\source\repos\GIJoe\GIJoe\GIJoe\Views\Home\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6f2340c54d26a15002903494575e3e21d573d0d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Register), @"mvc.1.0.view", @"/Views/Home/Register.cshtml")]
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
#nullable restore
#line 1 "C:\Users\B\source\repos\GIJoe\GIJoe\GIJoe\Views\_ViewImports.cshtml"
using GIJoe;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\B\source\repos\GIJoe\GIJoe\GIJoe\Views\_ViewImports.cshtml"
using GIJoe.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6f2340c54d26a15002903494575e3e21d573d0d", @"/Views/Home/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"857c15eece8b9e46ba14c5fa14d749c4dbd78e47", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GIJoe.Models.User>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\B\source\repos\GIJoe\GIJoe\GIJoe\Views\Home\Register.cshtml"
  
    ViewData["Title"] = "Register user";
    var content = ViewBag.Content;

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 6 "C:\Users\B\source\repos\GIJoe\GIJoe\GIJoe\Views\Home\Register.cshtml"
Write(content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d6f2340c54d26a15002903494575e3e21d573d0d3493", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 10 "C:\Users\B\source\repos\GIJoe\GIJoe\GIJoe\Views\Home\Register.cshtml"
     using (Html.BeginForm("Register", "Home", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("    <table cellpadding=\"0\" cellspacing=\"0\">\r\n        <tr>\r\n            <th colspan=\"2\" align=\"center\">Login</th>\r\n        </tr>\r\n        <tr>\r\n            <td>Username: </td>\r\n            <td>\r\n                ");
#nullable restore
#line 19 "C:\Users\B\source\repos\GIJoe\GIJoe\GIJoe\Views\Home\Register.cshtml"
           Write(Html.TextBoxFor(m => m.username));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>Password: </td>\r\n            <td>\r\n                ");
#nullable restore
#line 25 "C:\Users\B\source\repos\GIJoe\GIJoe\GIJoe\Views\Home\Register.cshtml"
           Write(Html.Password("password", "", new { id = "password", Textmode = "Password" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>Mail: </td>\r\n            <td>\r\n                ");
#nullable restore
#line 31 "C:\Users\B\source\repos\GIJoe\GIJoe\GIJoe\Views\Home\Register.cshtml"
           Write(Html.TextBoxFor(m => m.mail));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td><input type=\"submit\" value=\"Submit\" /></td>\r\n        </tr>\r\n    </table>\r\n");
#nullable restore
#line 39 "C:\Users\B\source\repos\GIJoe\GIJoe\GIJoe\Views\Home\Register.cshtml"
    }

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GIJoe.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
