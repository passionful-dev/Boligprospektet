#pragma checksum "C:\Users\Prinsu\source\repos\dotNet\Boligprospektet\Boligprospektet\Views\Views_Bolig_type\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74acbd04a987ee1caba3cc36cb2a8f5b91e763e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Views_Bolig_type_Details), @"mvc.1.0.view", @"/Views/Views_Bolig_type/Details.cshtml")]
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
#line 1 "C:\Users\Prinsu\source\repos\dotNet\Boligprospektet\Boligprospektet\Views\_ViewImports.cshtml"
using Boligprospektet.Models.Models_User;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Prinsu\source\repos\dotNet\Boligprospektet\Boligprospektet\Views\_ViewImports.cshtml"
using Boligprospektet.ViewModels.ViewModels_User;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Prinsu\source\repos\dotNet\Boligprospektet\Boligprospektet\Views\_ViewImports.cshtml"
using Boligprospektet.Models.Models_User_activitet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Prinsu\source\repos\dotNet\Boligprospektet\Boligprospektet\Views\_ViewImports.cshtml"
using Boligprospektet.ViewModels.ViewModels_User_activitet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Prinsu\source\repos\dotNet\Boligprospektet\Boligprospektet\Views\_ViewImports.cshtml"
using Boligprospektet.Models.Models_Bolig;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Prinsu\source\repos\dotNet\Boligprospektet\Boligprospektet\Views\_ViewImports.cshtml"
using Boligprospektet.ViewModels.ViewModels_Bolig;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Prinsu\source\repos\dotNet\Boligprospektet\Boligprospektet\Views\_ViewImports.cshtml"
using Boligprospektet.Models.Models_Facilitet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Prinsu\source\repos\dotNet\Boligprospektet\Boligprospektet\Views\_ViewImports.cshtml"
using Boligprospektet.ViewModels.ViewModels_Facilitet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Prinsu\source\repos\dotNet\Boligprospektet\Boligprospektet\Views\_ViewImports.cshtml"
using Boligprospektet.Models.Models_Bolig_activitet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Prinsu\source\repos\dotNet\Boligprospektet\Boligprospektet\Views\_ViewImports.cshtml"
using Boligprospektet.ViewModels.ViewModels_Bolig_activitet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Prinsu\source\repos\dotNet\Boligprospektet\Boligprospektet\Views\_ViewImports.cshtml"
using Boligprospektet.Models.Models_Bolig_type;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Prinsu\source\repos\dotNet\Boligprospektet\Boligprospektet\Views\_ViewImports.cshtml"
using Boligprospektet.ViewModels.ViewModels_Bolig_type;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Prinsu\source\repos\dotNet\Boligprospektet\Boligprospektet\Views\_ViewImports.cshtml"
using Boligprospektet.Models.Models_Bolig_type_activitet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Prinsu\source\repos\dotNet\Boligprospektet\Boligprospektet\Views\_ViewImports.cshtml"
using Boligprospektet.ViewModels.ViewModels_Bolig_type_activitet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Prinsu\source\repos\dotNet\Boligprospektet\Boligprospektet\Views\_ViewImports.cshtml"
using Boligprospektet.Models.Models_Indhold;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Prinsu\source\repos\dotNet\Boligprospektet\Boligprospektet\Views\_ViewImports.cshtml"
using Boligprospektet.ViewModels.ViewModels_Indhold;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Prinsu\source\repos\dotNet\Boligprospektet\Boligprospektet\Views\_ViewImports.cshtml"
using Boligprospektet.Models.Models_Indhold_activitet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Prinsu\source\repos\dotNet\Boligprospektet\Boligprospektet\Views\_ViewImports.cshtml"
using Boligprospektet.ViewModels.ViewModels_Indhold_activitet;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74acbd04a987ee1caba3cc36cb2a8f5b91e763e5", @"/Views/Views_Bolig_type/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8cdeb9db89f212b0c3a13782c31fe145dd238f6", @"/Views/_ViewImports.cshtml")]
    public class Views_Views_Bolig_type_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bolig_typeDetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/CustomScript.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Prinsu\source\repos\dotNet\Boligprospektet\Boligprospektet\Views\Views_Bolig_type\Details.cshtml"
  
    ViewBag.Title = "Bolig_type Details";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<html xmlns=\"http://www.w3.org/1999/xhtml\">\n\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74acbd04a987ee1caba3cc36cb2a8f5b91e763e57900", async() => {
                WriteLiteral("\n        <title></title>\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74acbd04a987ee1caba3cc36cb2a8f5b91e763e58895", async() => {
                WriteLiteral("\n        <h3>");
#nullable restore
#line 14 "C:\Users\Prinsu\source\repos\dotNet\Boligprospektet\Boligprospektet\Views\Views_Bolig_type\Details.cshtml"
       Write(Model.PageTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h3>
        <table>
            <thead>
                <tr>
                    <th>Date_Time</th>
                    <th>User_Id</th>
                    <th>Bolig_type_Navn</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>");
#nullable restore
#line 25 "C:\Users\Prinsu\source\repos\dotNet\Boligprospektet\Boligprospektet\Views\Views_Bolig_type\Details.cshtml"
                   Write(Model.Bolig_type.Date_Time);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 26 "C:\Users\Prinsu\source\repos\dotNet\Boligprospektet\Boligprospektet\Views\Views_Bolig_type\Details.cshtml"
                   Write(Model.Bolig_type.User_Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 27 "C:\Users\Prinsu\source\repos\dotNet\Boligprospektet\Boligprospektet\Views\Views_Bolig_type\Details.cshtml"
                   Write(Model.Bolig_type.Bolig_type_Navn);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                </tr>\n            </tbody>\n        </table>\n\n");
                DefineSection("Scripts", async() => {
                    WriteLiteral("\n            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74acbd04a987ee1caba3cc36cb2a8f5b91e763e510791", async() => {
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
                    WriteLiteral("\n        ");
                }
                );
                WriteLiteral("    ");
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
            WriteLiteral("\n</html>\n\n \n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Bolig_typeDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591