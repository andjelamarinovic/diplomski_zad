#pragma checksum "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Students\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2540212a86a538d37754c74a1daf00ee02a1939"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Details), @"mvc.1.0.view", @"/Views/Students/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Students/Details.cshtml", typeof(AspNetCore.Views_Students_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2540212a86a538d37754c74a1daf00ee02a1939", @"/Views/Students/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2730d23db5410baf873b69ca3d25fbe9b2df8f39", @"/Views/_ViewImports.cshtml")]
    public class Views_Students_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SportApp.Models.Student>
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
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Students\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(77, 121, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Student</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(199, 39, false);
#line 14 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Ime));

#line default
#line hidden
            EndContext();
            BeginContext(238, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(282, 35, false);
#line 17 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.Ime));

#line default
#line hidden
            EndContext();
            BeginContext(317, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(361, 43, false);
#line 20 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Prezime));

#line default
#line hidden
            EndContext();
            BeginContext(404, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(448, 39, false);
#line 23 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.Prezime));

#line default
#line hidden
            EndContext();
            BeginContext(487, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(531, 48, false);
#line 26 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SifraStudent));

#line default
#line hidden
            EndContext();
            BeginContext(579, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(623, 44, false);
#line 29 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.SifraStudent));

#line default
#line hidden
            EndContext();
            BeginContext(667, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(711, 48, false);
#line 32 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.StudentDatum));

#line default
#line hidden
            EndContext();
            BeginContext(759, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(803, 44, false);
#line 35 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.StudentDatum));

#line default
#line hidden
            EndContext();
            BeginContext(847, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(891, 49, false);
#line 38 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.StudentMjesto));

#line default
#line hidden
            EndContext();
            BeginContext(940, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(984, 45, false);
#line 41 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.StudentMjesto));

#line default
#line hidden
            EndContext();
            BeginContext(1029, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1073, 47, false);
#line 44 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.GodinaMajka));

#line default
#line hidden
            EndContext();
            BeginContext(1120, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1164, 43, false);
#line 47 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.GodinaMajka));

#line default
#line hidden
            EndContext();
            BeginContext(1207, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1251, 46, false);
#line 50 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.GodinaOtac));

#line default
#line hidden
            EndContext();
            BeginContext(1297, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1341, 42, false);
#line 53 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.GodinaOtac));

#line default
#line hidden
            EndContext();
            BeginContext(1383, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1427, 46, false);
#line 56 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SportMajka));

#line default
#line hidden
            EndContext();
            BeginContext(1473, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1517, 42, false);
#line 59 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.SportMajka));

#line default
#line hidden
            EndContext();
            BeginContext(1559, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1603, 45, false);
#line 62 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SportOtac));

#line default
#line hidden
            EndContext();
            BeginContext(1648, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1692, 41, false);
#line 65 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.SportOtac));

#line default
#line hidden
            EndContext();
            BeginContext(1733, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1777, 50, false);
#line 68 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.KojiSportMajka));

#line default
#line hidden
            EndContext();
            BeginContext(1827, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1871, 46, false);
#line 71 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.KojiSportMajka));

#line default
#line hidden
            EndContext();
            BeginContext(1917, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1961, 49, false);
#line 74 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.KojiSportOtac));

#line default
#line hidden
            EndContext();
            BeginContext(2010, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2054, 45, false);
#line 77 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.KojiSportOtac));

#line default
#line hidden
            EndContext();
            BeginContext(2099, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2143, 48, false);
#line 80 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SportStudent));

#line default
#line hidden
            EndContext();
            BeginContext(2191, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2235, 44, false);
#line 83 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.SportStudent));

#line default
#line hidden
            EndContext();
            BeginContext(2279, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2323, 52, false);
#line 86 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.KojiSportStudent));

#line default
#line hidden
            EndContext();
            BeginContext(2375, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2419, 48, false);
#line 89 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.KojiSportStudent));

#line default
#line hidden
            EndContext();
            BeginContext(2467, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2511, 44, false);
#line 92 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Trajanje));

#line default
#line hidden
            EndContext();
            BeginContext(2555, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2599, 40, false);
#line 95 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.Trajanje));

#line default
#line hidden
            EndContext();
            BeginContext(2639, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2683, 47, false);
#line 98 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Istovremeno));

#line default
#line hidden
            EndContext();
            BeginContext(2730, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2774, 43, false);
#line 101 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.Istovremeno));

#line default
#line hidden
            EndContext();
            BeginContext(2817, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2861, 40, false);
#line 104 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Spol));

#line default
#line hidden
            EndContext();
            BeginContext(2901, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2945, 47, false);
#line 107 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.Spol.NazivSpola));

#line default
#line hidden
            EndContext();
            BeginContext(2992, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(3039, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c29c20f6856241739938cc58808fb37e", async() => {
                BeginContext(3092, 4, true);
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
#line 112 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Students\Details.cshtml"
                           WriteLiteral(Model.StudentId);

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
            BeginContext(3100, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(3108, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c83c661751240eea8828825126dd445", async() => {
                BeginContext(3130, 12, true);
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
            BeginContext(3146, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SportApp.Models.Student> Html { get; private set; }
    }
}
#pragma warning restore 1591
