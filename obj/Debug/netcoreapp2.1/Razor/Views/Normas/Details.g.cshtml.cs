#pragma checksum "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Normas\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d7e9c2712e34ddd54ef389d16a5dc86887f906b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Normas_Details), @"mvc.1.0.view", @"/Views/Normas/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Normas/Details.cshtml", typeof(AspNetCore.Views_Normas_Details))]
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
#line 1 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\_ViewImports.cshtml"
using SportApp;

#line default
#line hidden
#line 2 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\_ViewImports.cshtml"
using SportApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d7e9c2712e34ddd54ef389d16a5dc86887f906b", @"/Views/Normas/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2730d23db5410baf873b69ca3d25fbe9b2df8f39", @"/Views/_ViewImports.cshtml")]
    public class Views_Normas_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SportApp.Models.Norma>
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
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Normas\Details.cshtml"
  
    ViewData["Title"] = "Detalji";

#line default
#line hidden
            BeginContext(75, 162, true);
            WriteLiteral("\r\n<h2>Detalji</h2>\r\n\r\n<div>\r\n    <h4>Norma</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\" style=\"border-bottom: 1px solid lightgray\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(238, 40, false);
#line 14 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Normas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Spol));

#line default
#line hidden
            EndContext();
            BeginContext(278, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(322, 47, false);
#line 17 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Normas\Details.cshtml"
       Write(Html.DisplayFor(model => model.Spol.NazivSpola));

#line default
#line hidden
            EndContext();
            BeginContext(369, 57, true);
            WriteLiteral("\r\n        </dd>\r\n        <br>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(427, 42, false);
#line 21 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Normas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Razred));

#line default
#line hidden
            EndContext();
            BeginContext(469, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(513, 49, false);
#line 24 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Normas\Details.cshtml"
       Write(Html.DisplayFor(model => model.Razred.BrojRazred));

#line default
#line hidden
            EndContext();
            BeginContext(562, 57, true);
            WriteLiteral("\r\n        </dd>\r\n        <br>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(620, 46, false);
#line 28 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Normas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.VrstaTesta));

#line default
#line hidden
            EndContext();
            BeginContext(666, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(710, 53, false);
#line 31 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Normas\Details.cshtml"
       Write(Html.DisplayFor(model => model.VrstaTesta.NazivTesta));

#line default
#line hidden
            EndContext();
            BeginContext(763, 107, true);
            WriteLiteral("\r\n        </dd>\r\n        <br>\r\n        <dt>\r\n            Ocjena1\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(871, 39, false);
#line 38 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Normas\Details.cshtml"
       Write(Html.DisplayFor(model => model.Ocjena1));

#line default
#line hidden
            EndContext();
            BeginContext(910, 107, true);
            WriteLiteral("\r\n        </dd>\r\n        <br>\r\n        <dt>\r\n            Ocjena2\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1018, 39, false);
#line 45 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Normas\Details.cshtml"
       Write(Html.DisplayFor(model => model.Ocjena2));

#line default
#line hidden
            EndContext();
            BeginContext(1057, 107, true);
            WriteLiteral("\r\n        </dd>\r\n        <br>\r\n        <dt>\r\n            Ocjena3\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1165, 39, false);
#line 52 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Normas\Details.cshtml"
       Write(Html.DisplayFor(model => model.Ocjena3));

#line default
#line hidden
            EndContext();
            BeginContext(1204, 107, true);
            WriteLiteral("\r\n        </dd>\r\n        <br>\r\n        <dt>\r\n            Ocjena4\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1312, 39, false);
#line 59 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Normas\Details.cshtml"
       Write(Html.DisplayFor(model => model.Ocjena4));

#line default
#line hidden
            EndContext();
            BeginContext(1351, 107, true);
            WriteLiteral("\r\n        </dd>\r\n        <br>\r\n        <dt>\r\n            Ocjena5\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1459, 39, false);
#line 66 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Normas\Details.cshtml"
       Write(Html.DisplayFor(model => model.Ocjena5));

#line default
#line hidden
            EndContext();
            BeginContext(1498, 61, true);
            WriteLiteral("\r\n        </dd>\r\n        <br>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1559, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "144584eed7fd4d71b36295d827d25db3", async() => {
                BeginContext(1610, 7, true);
                WriteLiteral("Izmjena");
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
#line 72 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Normas\Details.cshtml"
                           WriteLiteral(Model.NormaId);

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
            BeginContext(1621, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1629, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d0f756e50364a04a499711eda2c0373", async() => {
                BeginContext(1651, 8, true);
                WriteLiteral("Povratak");
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
            BeginContext(1663, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SportApp.Models.Norma> Html { get; private set; }
    }
}
#pragma warning restore 1591
