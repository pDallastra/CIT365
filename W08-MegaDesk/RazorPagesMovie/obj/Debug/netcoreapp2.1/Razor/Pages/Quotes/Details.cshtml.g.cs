#pragma checksum "C:\Users\usada\Documents\BYU\CIT365\W08-MegaDesk\RazorPagesMovie\Pages\Quotes\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc2d01b5a167d2770e061d309a4ca846e7ea7b9d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MegaDesk.Pages.Quotes.Pages_Quotes_Details), @"mvc.1.0.razor-page", @"/Pages/Quotes/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Quotes/Details.cshtml", typeof(MegaDesk.Pages.Quotes.Pages_Quotes_Details), @"{id:int?}")]
namespace MegaDesk.Pages.Quotes
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\usada\Documents\BYU\CIT365\W08-MegaDesk\RazorPagesMovie\Pages\_ViewImports.cshtml"
using MegaDesk;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id:int?}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc2d01b5a167d2770e061d309a4ca846e7ea7b9d", @"/Pages/Quotes/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"460365d825535bcbd8bf03b94cf81c137a23c898", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Quotes_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(62, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\usada\Documents\BYU\CIT365\W08-MegaDesk\RazorPagesMovie\Pages\Quotes\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(107, 170, true);
            WriteLiteral("<div class=\"container\">\r\n    <h2>Details</h2>\r\n\r\n    <div>\r\n        <h4>Quote</h4>\r\n        <hr />\r\n        <dl class=\"dl-horizontal\">\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(278, 46, false);
#line 15 "C:\Users\usada\Documents\BYU\CIT365\W08-MegaDesk\RazorPagesMovie\Pages\Quotes\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Quote.name));

#line default
#line hidden
            EndContext();
            BeginContext(324, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(380, 42, false);
#line 18 "C:\Users\usada\Documents\BYU\CIT365\W08-MegaDesk\RazorPagesMovie\Pages\Quotes\Details.cshtml"
           Write(Html.DisplayFor(model => model.Quote.name));

#line default
#line hidden
            EndContext();
            BeginContext(422, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(478, 47, false);
#line 21 "C:\Users\usada\Documents\BYU\CIT365\W08-MegaDesk\RazorPagesMovie\Pages\Quotes\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Quote.width));

#line default
#line hidden
            EndContext();
            BeginContext(525, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(581, 43, false);
#line 24 "C:\Users\usada\Documents\BYU\CIT365\W08-MegaDesk\RazorPagesMovie\Pages\Quotes\Details.cshtml"
           Write(Html.DisplayFor(model => model.Quote.width));

#line default
#line hidden
            EndContext();
            BeginContext(624, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(680, 47, false);
#line 27 "C:\Users\usada\Documents\BYU\CIT365\W08-MegaDesk\RazorPagesMovie\Pages\Quotes\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Quote.depth));

#line default
#line hidden
            EndContext();
            BeginContext(727, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(783, 43, false);
#line 30 "C:\Users\usada\Documents\BYU\CIT365\W08-MegaDesk\RazorPagesMovie\Pages\Quotes\Details.cshtml"
           Write(Html.DisplayFor(model => model.Quote.depth));

#line default
#line hidden
            EndContext();
            BeginContext(826, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(882, 52, false);
#line 33 "C:\Users\usada\Documents\BYU\CIT365\W08-MegaDesk\RazorPagesMovie\Pages\Quotes\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Quote.numDrawers));

#line default
#line hidden
            EndContext();
            BeginContext(934, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(990, 48, false);
#line 36 "C:\Users\usada\Documents\BYU\CIT365\W08-MegaDesk\RazorPagesMovie\Pages\Quotes\Details.cshtml"
           Write(Html.DisplayFor(model => model.Quote.numDrawers));

#line default
#line hidden
            EndContext();
            BeginContext(1038, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(1094, 47, false);
#line 39 "C:\Users\usada\Documents\BYU\CIT365\W08-MegaDesk\RazorPagesMovie\Pages\Quotes\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Quote.price));

#line default
#line hidden
            EndContext();
            BeginContext(1141, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1197, 43, false);
#line 42 "C:\Users\usada\Documents\BYU\CIT365\W08-MegaDesk\RazorPagesMovie\Pages\Quotes\Details.cshtml"
           Write(Html.DisplayFor(model => model.Quote.price));

#line default
#line hidden
            EndContext();
            BeginContext(1240, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(1296, 52, false);
#line 45 "C:\Users\usada\Documents\BYU\CIT365\W08-MegaDesk\RazorPagesMovie\Pages\Quotes\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Quote.surfaceMat));

#line default
#line hidden
            EndContext();
            BeginContext(1348, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1404, 48, false);
#line 48 "C:\Users\usada\Documents\BYU\CIT365\W08-MegaDesk\RazorPagesMovie\Pages\Quotes\Details.cshtml"
           Write(Html.DisplayFor(model => model.Quote.surfaceMat));

#line default
#line hidden
            EndContext();
            BeginContext(1452, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(1508, 49, false);
#line 51 "C:\Users\usada\Documents\BYU\CIT365\W08-MegaDesk\RazorPagesMovie\Pages\Quotes\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Quote.rushOrd));

#line default
#line hidden
            EndContext();
            BeginContext(1557, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1613, 45, false);
#line 54 "C:\Users\usada\Documents\BYU\CIT365\W08-MegaDesk\RazorPagesMovie\Pages\Quotes\Details.cshtml"
           Write(Html.DisplayFor(model => model.Quote.rushOrd));

#line default
#line hidden
            EndContext();
            BeginContext(1658, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(1714, 51, false);
#line 57 "C:\Users\usada\Documents\BYU\CIT365\W08-MegaDesk\RazorPagesMovie\Pages\Quotes\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Quote.DateAdded));

#line default
#line hidden
            EndContext();
            BeginContext(1765, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1821, 47, false);
#line 60 "C:\Users\usada\Documents\BYU\CIT365\W08-MegaDesk\RazorPagesMovie\Pages\Quotes\Details.cshtml"
           Write(Html.DisplayFor(model => model.Quote.DateAdded));

#line default
#line hidden
            EndContext();
            BeginContext(1868, 67, true);
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n    </div>\r\n    <div>\r\n        ");
            EndContext();
            BeginContext(1935, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d332983b5d5b43c9ba88ca064813c302", async() => {
                BeginContext(1987, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 65 "C:\Users\usada\Documents\BYU\CIT365\W08-MegaDesk\RazorPagesMovie\Pages\Quotes\Details.cshtml"
                               WriteLiteral(Model.Quote.ID);

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
            BeginContext(1995, 12, true);
            WriteLiteral(" |\r\n        ");
            EndContext();
            BeginContext(2007, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0496c64f92a74dd2bd8f2eb9832b8f54", async() => {
                BeginContext(2029, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2045, 20, true);
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MegaDesk.Pages.Quotes.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MegaDesk.Pages.Quotes.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MegaDesk.Pages.Quotes.DetailsModel>)PageContext?.ViewData;
        public MegaDesk.Pages.Quotes.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
