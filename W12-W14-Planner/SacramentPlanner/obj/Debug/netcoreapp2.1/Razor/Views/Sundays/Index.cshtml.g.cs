#pragma checksum "C:\Users\usada\Documents\BYU\CIT365\W12-W14-Planner\SacramentPlanner\Views\Sundays\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ef07d9ab2417e154bccd89f541bc6d37c39a40f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sundays_Index), @"mvc.1.0.view", @"/Views/Sundays/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Sundays/Index.cshtml", typeof(AspNetCore.Views_Sundays_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ef07d9ab2417e154bccd89f541bc6d37c39a40f", @"/Views/Sundays/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b7b2e7c0c23763ecadada24630103390c557703", @"/Views/_ViewImports.cshtml")]
    public class Views_Sundays_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SacramentPlanner.Models.Sunday>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("historyImg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/history.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Sundays", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(52, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\usada\Documents\BYU\CIT365\W12-W14-Planner\SacramentPlanner\Views\Sundays\Index.cshtml"
  
    ViewData["Title"] = "History";

#line default
#line hidden
            BeginContext(97, 24, true);
            WriteLiteral("\r\n\r\n<h2>History</h2>\r\n\r\n");
            EndContext();
            BeginContext(121, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "40f2ec3bce2245c68c1999aaa7f9defe", async() => {
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
            BeginContext(174, 12, true);
            WriteLiteral("\r\n<h4>\r\n    ");
            EndContext();
            BeginContext(186, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e90c4f8948ec43c3a68f924989e52eb4", async() => {
                BeginContext(209, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(223, 11, true);
            WriteLiteral("\r\n</h4>\r\n\r\n");
            EndContext();
            BeginContext(234, 186, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b612409295304fde9e7f0a0d125c34e1", async() => {
                BeginContext(284, 129, true);
                WriteLiteral("\r\n    <p>\r\n        Conductor: <input type=\"text\" name=\"SearchString\">\r\n        <input type=\"submit\" value=\"Search\" />\r\n    </p>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(420, 88, true);
            WriteLiteral("\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(509, 40, false);
#line 26 "C:\Users\usada\Documents\BYU\CIT365\W12-W14-Planner\SacramentPlanner\Views\Sundays\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(549, 166, true);
            WriteLiteral("\r\n                </a>\r\n            </th>\r\n            <th style=\"text-align:center;\">\r\n                Details\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(716, 44, false);
#line 33 "C:\Users\usada\Documents\BYU\CIT365\W12-W14-Planner\SacramentPlanner\Views\Sundays\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Speakers));

#line default
#line hidden
            EndContext();
            BeginContext(760, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 39 "C:\Users\usada\Documents\BYU\CIT365\W12-W14-Planner\SacramentPlanner\Views\Sundays\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(895, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(956, 39, false);
#line 43 "C:\Users\usada\Documents\BYU\CIT365\W12-W14-Planner\SacramentPlanner\Views\Sundays\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
            EndContext();
            BeginContext(995, 153, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <dl class=\"dl-horizontal\">\r\n                        <dt>\r\n                            ");
            EndContext();
            BeginContext(1149, 48, false);
#line 48 "C:\Users\usada\Documents\BYU\CIT365\W12-W14-Planner\SacramentPlanner\Views\Sundays\Index.cshtml"
                       Write(Html.DisplayNameFor(modelItem => item.Conductor));

#line default
#line hidden
            EndContext();
            BeginContext(1197, 91, true);
            WriteLiteral("\r\n                        </dt>\r\n                        <dd>\r\n                            ");
            EndContext();
            BeginContext(1289, 44, false);
#line 51 "C:\Users\usada\Documents\BYU\CIT365\W12-W14-Planner\SacramentPlanner\Views\Sundays\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Conductor));

#line default
#line hidden
            EndContext();
            BeginContext(1333, 91, true);
            WriteLiteral("\r\n                        </dd>\r\n                        <dt>\r\n                            ");
            EndContext();
            BeginContext(1425, 50, false);
#line 54 "C:\Users\usada\Documents\BYU\CIT365\W12-W14-Planner\SacramentPlanner\Views\Sundays\Index.cshtml"
                       Write(Html.DisplayNameFor(modelItem => item.OpeningHymn));

#line default
#line hidden
            EndContext();
            BeginContext(1475, 91, true);
            WriteLiteral("\r\n                        </dt>\r\n                        <dd>\r\n                            ");
            EndContext();
            BeginContext(1567, 46, false);
#line 57 "C:\Users\usada\Documents\BYU\CIT365\W12-W14-Planner\SacramentPlanner\Views\Sundays\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.OpeningHymn));

#line default
#line hidden
            EndContext();
            BeginContext(1613, 91, true);
            WriteLiteral("\r\n                        </dd>\r\n                        <dt>\r\n                            ");
            EndContext();
            BeginContext(1705, 50, false);
#line 60 "C:\Users\usada\Documents\BYU\CIT365\W12-W14-Planner\SacramentPlanner\Views\Sundays\Index.cshtml"
                       Write(Html.DisplayNameFor(modelItem => item.ClosingHymn));

#line default
#line hidden
            EndContext();
            BeginContext(1755, 91, true);
            WriteLiteral("\r\n                        </dt>\r\n                        <dd>\r\n                            ");
            EndContext();
            BeginContext(1847, 46, false);
#line 63 "C:\Users\usada\Documents\BYU\CIT365\W12-W14-Planner\SacramentPlanner\Views\Sundays\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ClosingHymn));

#line default
#line hidden
            EndContext();
            BeginContext(1893, 91, true);
            WriteLiteral("\r\n                        </dd>\r\n                        <dt>\r\n                            ");
            EndContext();
            BeginContext(1985, 52, false);
#line 66 "C:\Users\usada\Documents\BYU\CIT365\W12-W14-Planner\SacramentPlanner\Views\Sundays\Index.cshtml"
                       Write(Html.DisplayNameFor(modelItem => item.SacramentHymn));

#line default
#line hidden
            EndContext();
            BeginContext(2037, 91, true);
            WriteLiteral("\r\n                        </dt>\r\n                        <dd>\r\n                            ");
            EndContext();
            BeginContext(2129, 48, false);
#line 69 "C:\Users\usada\Documents\BYU\CIT365\W12-W14-Planner\SacramentPlanner\Views\Sundays\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.SacramentHymn));

#line default
#line hidden
            EndContext();
            BeginContext(2177, 91, true);
            WriteLiteral("\r\n                        </dd>\r\n                        <dt>\r\n                            ");
            EndContext();
            BeginContext(2269, 55, false);
#line 72 "C:\Users\usada\Documents\BYU\CIT365\W12-W14-Planner\SacramentPlanner\Views\Sundays\Index.cshtml"
                       Write(Html.DisplayNameFor(modelItem => item.IntermediateSong));

#line default
#line hidden
            EndContext();
            BeginContext(2324, 91, true);
            WriteLiteral("\r\n                        </dt>\r\n                        <dd>\r\n                            ");
            EndContext();
            BeginContext(2416, 51, false);
#line 75 "C:\Users\usada\Documents\BYU\CIT365\W12-W14-Planner\SacramentPlanner\Views\Sundays\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.IntermediateSong));

#line default
#line hidden
            EndContext();
            BeginContext(2467, 91, true);
            WriteLiteral("\r\n                        </dd>\r\n                        <dt>\r\n                            ");
            EndContext();
            BeginContext(2559, 52, false);
#line 78 "C:\Users\usada\Documents\BYU\CIT365\W12-W14-Planner\SacramentPlanner\Views\Sundays\Index.cshtml"
                       Write(Html.DisplayNameFor(modelItem => item.OpeningPrayer));

#line default
#line hidden
            EndContext();
            BeginContext(2611, 91, true);
            WriteLiteral("\r\n                        </dt>\r\n                        <dd>\r\n                            ");
            EndContext();
            BeginContext(2703, 48, false);
#line 81 "C:\Users\usada\Documents\BYU\CIT365\W12-W14-Planner\SacramentPlanner\Views\Sundays\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.OpeningPrayer));

#line default
#line hidden
            EndContext();
            BeginContext(2751, 91, true);
            WriteLiteral("\r\n                        </dd>\r\n                        <dt>\r\n                            ");
            EndContext();
            BeginContext(2843, 52, false);
#line 84 "C:\Users\usada\Documents\BYU\CIT365\W12-W14-Planner\SacramentPlanner\Views\Sundays\Index.cshtml"
                       Write(Html.DisplayNameFor(modelItem => item.ClosingPrayer));

#line default
#line hidden
            EndContext();
            BeginContext(2895, 91, true);
            WriteLiteral("\r\n                        </dt>\r\n                        <dd>\r\n                            ");
            EndContext();
            BeginContext(2987, 48, false);
#line 87 "C:\Users\usada\Documents\BYU\CIT365\W12-W14-Planner\SacramentPlanner\Views\Sundays\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ClosingPrayer));

#line default
#line hidden
            EndContext();
            BeginContext(3035, 131, true);
            WriteLiteral("\r\n                        </dd>\r\n                    </dl>\r\n                </td>\r\n                <td>\r\n                    <dl>\r\n");
            EndContext();
#line 93 "C:\Users\usada\Documents\BYU\CIT365\W12-W14-Planner\SacramentPlanner\Views\Sundays\Index.cshtml"
                         if (item.Speakers != null)
                        {
                            

#line default
#line hidden
#line 95 "C:\Users\usada\Documents\BYU\CIT365\W12-W14-Planner\SacramentPlanner\Views\Sundays\Index.cshtml"
                             foreach (var speaker in item.Speakers)
                            {

#line default
#line hidden
            BeginContext(3346, 36, true);
            WriteLiteral("                                <dt>");
            EndContext();
            BeginContext(3383, 42, false);
#line 97 "C:\Users\usada\Documents\BYU\CIT365\W12-W14-Planner\SacramentPlanner\Views\Sundays\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => speaker.Name));

#line default
#line hidden
            EndContext();
            BeginContext(3425, 43, true);
            WriteLiteral("</dt>\r\n                                <dd>");
            EndContext();
            BeginContext(3469, 45, false);
#line 98 "C:\Users\usada\Documents\BYU\CIT365\W12-W14-Planner\SacramentPlanner\Views\Sundays\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => speaker.Subject));

#line default
#line hidden
            EndContext();
            BeginContext(3514, 7, true);
            WriteLiteral("</dd>\r\n");
            EndContext();
#line 99 "C:\Users\usada\Documents\BYU\CIT365\W12-W14-Planner\SacramentPlanner\Views\Sundays\Index.cshtml"
                            }

#line default
#line hidden
#line 99 "C:\Users\usada\Documents\BYU\CIT365\W12-W14-Planner\SacramentPlanner\Views\Sundays\Index.cshtml"
                             
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(3636, 41, true);
            WriteLiteral("                            <p>None</p>\r\n");
            EndContext();
#line 104 "C:\Users\usada\Documents\BYU\CIT365\W12-W14-Planner\SacramentPlanner\Views\Sundays\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(3704, 92, true);
            WriteLiteral("                    </dl>\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3796, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5654a285bf934d599fd0eed3c5be80d5", async() => {
                BeginContext(3841, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 108 "C:\Users\usada\Documents\BYU\CIT365\W12-W14-Planner\SacramentPlanner\Views\Sundays\Index.cshtml"
                                           WriteLiteral(item.Id);

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
            BeginContext(3849, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(3873, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aaa2d86954de46f7b9bd108d8607dca1", async() => {
                BeginContext(3921, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 109 "C:\Users\usada\Documents\BYU\CIT365\W12-W14-Planner\SacramentPlanner\Views\Sundays\Index.cshtml"
                                              WriteLiteral(item.Id);

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
            BeginContext(3932, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(3956, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e73415237b7045e5a361a183cfa06f61", async() => {
                BeginContext(4003, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 110 "C:\Users\usada\Documents\BYU\CIT365\W12-W14-Planner\SacramentPlanner\Views\Sundays\Index.cshtml"
                                             WriteLiteral(item.Id);

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
            BeginContext(4013, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 113 "C:\Users\usada\Documents\BYU\CIT365\W12-W14-Planner\SacramentPlanner\Views\Sundays\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(4068, 28, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SacramentPlanner.Models.Sunday>> Html { get; private set; }
    }
}
#pragma warning restore 1591
