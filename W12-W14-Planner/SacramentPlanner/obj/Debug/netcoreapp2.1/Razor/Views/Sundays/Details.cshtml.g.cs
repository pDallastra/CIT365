#pragma checksum "C:\Users\usada\Documents\BYU\CIT365\W12-W14-Planner\SacramentPlanner\Views\Sundays\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b654f38e0bc337f25b85ebd5f029e0f764c152b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sundays_Details), @"mvc.1.0.view", @"/Views/Sundays/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Sundays/Details.cshtml", typeof(AspNetCore.Views_Sundays_Details))]
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
#line 1 "C:\Users\usada\Documents\BYU\CIT365\W12-W14-Planner\SacramentPlanner\Views\_ViewImports.cshtml"
using SacramentPlanner;

#line default
#line hidden
#line 2 "C:\Users\usada\Documents\BYU\CIT365\W12-W14-Planner\SacramentPlanner\Views\_ViewImports.cshtml"
using SacramentPlanner.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b654f38e0bc337f25b85ebd5f029e0f764c152b", @"/Views/Sundays/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b7b2e7c0c23763ecadada24630103390c557703", @"/Views/_ViewImports.cshtml")]
    public class Views_Sundays_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SacramentPlanner.Models.Sunday>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\usada\Documents\BYU\CIT365\W12-W14-Planner\SacramentPlanner\Views\Sundays\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(84, 120, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Sunday</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(205, 40, false);
#line 14 "C:\Users\usada\Documents\BYU\CIT365\W12-W14-Planner\SacramentPlanner\Views\Sundays\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(245, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(289, 36, false);
#line 17 "C:\Users\usada\Documents\BYU\CIT365\W12-W14-Planner\SacramentPlanner\Views\Sundays\Details.cshtml"
       Write(Html.DisplayFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(325, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(369, 45, false);
#line 20 "C:\Users\usada\Documents\BYU\CIT365\W12-W14-Planner\SacramentPlanner\Views\Sundays\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Conductor));

#line default
#line hidden
            EndContext();
            BeginContext(414, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(458, 41, false);
#line 23 "C:\Users\usada\Documents\BYU\CIT365\W12-W14-Planner\SacramentPlanner\Views\Sundays\Details.cshtml"
       Write(Html.DisplayFor(model => model.Conductor));

#line default
#line hidden
            EndContext();
            BeginContext(499, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(543, 47, false);
#line 26 "C:\Users\usada\Documents\BYU\CIT365\W12-W14-Planner\SacramentPlanner\Views\Sundays\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OpeningHymn));

#line default
#line hidden
            EndContext();
            BeginContext(590, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(634, 43, false);
#line 29 "C:\Users\usada\Documents\BYU\CIT365\W12-W14-Planner\SacramentPlanner\Views\Sundays\Details.cshtml"
       Write(Html.DisplayFor(model => model.OpeningHymn));

#line default
#line hidden
            EndContext();
            BeginContext(677, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(721, 47, false);
#line 32 "C:\Users\usada\Documents\BYU\CIT365\W12-W14-Planner\SacramentPlanner\Views\Sundays\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ClosingHymn));

#line default
#line hidden
            EndContext();
            BeginContext(768, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(812, 43, false);
#line 35 "C:\Users\usada\Documents\BYU\CIT365\W12-W14-Planner\SacramentPlanner\Views\Sundays\Details.cshtml"
       Write(Html.DisplayFor(model => model.ClosingHymn));

#line default
#line hidden
            EndContext();
            BeginContext(855, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(899, 49, false);
#line 38 "C:\Users\usada\Documents\BYU\CIT365\W12-W14-Planner\SacramentPlanner\Views\Sundays\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SacramentHymn));

#line default
#line hidden
            EndContext();
            BeginContext(948, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(992, 45, false);
#line 41 "C:\Users\usada\Documents\BYU\CIT365\W12-W14-Planner\SacramentPlanner\Views\Sundays\Details.cshtml"
       Write(Html.DisplayFor(model => model.SacramentHymn));

#line default
#line hidden
            EndContext();
            BeginContext(1037, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1081, 52, false);
#line 44 "C:\Users\usada\Documents\BYU\CIT365\W12-W14-Planner\SacramentPlanner\Views\Sundays\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IntermediateSong));

#line default
#line hidden
            EndContext();
            BeginContext(1133, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1177, 48, false);
#line 47 "C:\Users\usada\Documents\BYU\CIT365\W12-W14-Planner\SacramentPlanner\Views\Sundays\Details.cshtml"
       Write(Html.DisplayFor(model => model.IntermediateSong));

#line default
#line hidden
            EndContext();
            BeginContext(1225, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1269, 49, false);
#line 50 "C:\Users\usada\Documents\BYU\CIT365\W12-W14-Planner\SacramentPlanner\Views\Sundays\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OpeningPrayer));

#line default
#line hidden
            EndContext();
            BeginContext(1318, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1362, 45, false);
#line 53 "C:\Users\usada\Documents\BYU\CIT365\W12-W14-Planner\SacramentPlanner\Views\Sundays\Details.cshtml"
       Write(Html.DisplayFor(model => model.OpeningPrayer));

#line default
#line hidden
            EndContext();
            BeginContext(1407, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1451, 49, false);
#line 56 "C:\Users\usada\Documents\BYU\CIT365\W12-W14-Planner\SacramentPlanner\Views\Sundays\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ClosingPrayer));

#line default
#line hidden
            EndContext();
            BeginContext(1500, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1544, 45, false);
#line 59 "C:\Users\usada\Documents\BYU\CIT365\W12-W14-Planner\SacramentPlanner\Views\Sundays\Details.cshtml"
       Write(Html.DisplayFor(model => model.ClosingPrayer));

#line default
#line hidden
            EndContext();
            BeginContext(1589, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1633, 44, false);
#line 62 "C:\Users\usada\Documents\BYU\CIT365\W12-W14-Planner\SacramentPlanner\Views\Sundays\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Speakers));

#line default
#line hidden
            EndContext();
            BeginContext(1677, 31, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n");
            EndContext();
#line 65 "C:\Users\usada\Documents\BYU\CIT365\W12-W14-Planner\SacramentPlanner\Views\Sundays\Details.cshtml"
             if (Model.Speakers != null)
            {

#line default
#line hidden
            BeginContext(1765, 176, true);
            WriteLiteral("                <table class=\"table\">\r\n                    <tr>\r\n                        <th>Order</th>\r\n                        <th>Speaker</th>\r\n                    </tr>\r\n\r\n");
            EndContext();
#line 73 "C:\Users\usada\Documents\BYU\CIT365\W12-W14-Planner\SacramentPlanner\Views\Sundays\Details.cshtml"
                     foreach (var item in Model.Speakers)
                    {

#line default
#line hidden
            BeginContext(2023, 96, true);
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2120, 34, false);
#line 77 "C:\Users\usada\Documents\BYU\CIT365\W12-W14-Planner\SacramentPlanner\Views\Sundays\Details.cshtml"
                           Write(Html.DisplayFor(modelItem => item));

#line default
#line hidden
            EndContext();
            BeginContext(2154, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2258, 39, false);
#line 80 "C:\Users\usada\Documents\BYU\CIT365\W12-W14-Planner\SacramentPlanner\Views\Sundays\Details.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2297, 68, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 83 "C:\Users\usada\Documents\BYU\CIT365\W12-W14-Planner\SacramentPlanner\Views\Sundays\Details.cshtml"
                    }

#line default
#line hidden
            BeginContext(2388, 26, true);
            WriteLiteral("                </table>\r\n");
            EndContext();
#line 85 "C:\Users\usada\Documents\BYU\CIT365\W12-W14-Planner\SacramentPlanner\Views\Sundays\Details.cshtml"
            } else{

#line default
#line hidden
            BeginContext(2435, 29, true);
            WriteLiteral("                <p>None</p>\r\n");
            EndContext();
#line 87 "C:\Users\usada\Documents\BYU\CIT365\W12-W14-Planner\SacramentPlanner\Views\Sundays\Details.cshtml"
            }

#line default
#line hidden
            BeginContext(2479, 45, true);
            WriteLiteral("        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2524, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "febcc3ef583d484188c7f81b03a37f94", async() => {
                BeginContext(2570, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 92 "C:\Users\usada\Documents\BYU\CIT365\W12-W14-Planner\SacramentPlanner\Views\Sundays\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2578, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2586, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83335675ff2d4ffaaf671c6bf36b5162", async() => {
                BeginContext(2608, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2624, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SacramentPlanner.Models.Sunday> Html { get; private set; }
    }
}
#pragma warning restore 1591
