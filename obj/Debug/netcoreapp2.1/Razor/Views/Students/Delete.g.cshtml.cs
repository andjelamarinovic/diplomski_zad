#pragma checksum "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Students\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "477ea93f49be7999fbea4dae354a9ca5dcbfd959"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Delete), @"mvc.1.0.view", @"/Views/Students/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Students/Delete.cshtml", typeof(AspNetCore.Views_Students_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"477ea93f49be7999fbea4dae354a9ca5dcbfd959", @"/Views/Students/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2730d23db5410baf873b69ca3d25fbe9b2df8f39", @"/Views/_ViewImports.cshtml")]
    public class Views_Students_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SportApp.Models.Student>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Students\Delete.cshtml"
  
    ViewData["Title"] = "Brisanje";

#line default
#line hidden
            BeginContext(78, 241, true);
            WriteLiteral("\r\n<h2>Brisanje</h2>\r\n\r\n<h3>Jeste li sigurni da želite obrisati ipitanika?</h3>\r\n<div>\r\n    <hr />\r\n    <dl class=\"\">\r\n        <div class=\"row\">\r\n            <div class=\"col-sm-12\">\r\n                <dt class=\"col-sm-6\">\r\n                    ");
            EndContext();
            BeginContext(320, 40, false);
#line 16 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Students\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.Spol));

#line default
#line hidden
            EndContext();
            BeginContext(360, 84, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-4\">\r\n                    ");
            EndContext();
            BeginContext(445, 47, false);
#line 19 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Students\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Spol.NazivSpola));

#line default
#line hidden
            EndContext();
            BeginContext(492, 128, true);
            WriteLiteral("\r\n                </dd>\r\n                <br>\r\n                <br>\r\n                <dt class=\"col-sm-6\">\r\n                    ");
            EndContext();
            BeginContext(621, 39, false);
#line 24 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Students\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.Ime));

#line default
#line hidden
            EndContext();
            BeginContext(660, 84, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-4\">\r\n                    ");
            EndContext();
            BeginContext(745, 35, false);
#line 27 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Students\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Ime));

#line default
#line hidden
            EndContext();
            BeginContext(780, 128, true);
            WriteLiteral("\r\n                </dd>\r\n                <br>\r\n                <br>\r\n                <dt class=\"col-sm-6\">\r\n                    ");
            EndContext();
            BeginContext(909, 43, false);
#line 32 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Students\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.Prezime));

#line default
#line hidden
            EndContext();
            BeginContext(952, 84, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-4\">\r\n                    ");
            EndContext();
            BeginContext(1037, 39, false);
#line 35 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Students\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Prezime));

#line default
#line hidden
            EndContext();
            BeginContext(1076, 128, true);
            WriteLiteral("\r\n                </dd>\r\n                <br>\r\n                <br>\r\n                <dt class=\"col-sm-6\">\r\n                    ");
            EndContext();
            BeginContext(1205, 48, false);
#line 40 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Students\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.SifraStudent));

#line default
#line hidden
            EndContext();
            BeginContext(1253, 84, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-4\">\r\n                    ");
            EndContext();
            BeginContext(1338, 44, false);
#line 43 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Students\Delete.cshtml"
               Write(Html.DisplayFor(model => model.SifraStudent));

#line default
#line hidden
            EndContext();
            BeginContext(1382, 128, true);
            WriteLiteral("\r\n                </dd>\r\n                <br>\r\n                <br>\r\n                <dt class=\"col-sm-6\">\r\n                    ");
            EndContext();
            BeginContext(1511, 48, false);
#line 48 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Students\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.StudentDatum));

#line default
#line hidden
            EndContext();
            BeginContext(1559, 84, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-4\">\r\n                    ");
            EndContext();
            BeginContext(1644, 44, false);
#line 51 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Students\Delete.cshtml"
               Write(Html.DisplayFor(model => model.StudentDatum));

#line default
#line hidden
            EndContext();
            BeginContext(1688, 128, true);
            WriteLiteral("\r\n                </dd>\r\n                <br>\r\n                <br>\r\n                <dt class=\"col-sm-6\">\r\n                    ");
            EndContext();
            BeginContext(1817, 49, false);
#line 56 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Students\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.StudentMjesto));

#line default
#line hidden
            EndContext();
            BeginContext(1866, 84, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-4\">\r\n                    ");
            EndContext();
            BeginContext(1951, 45, false);
#line 59 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Students\Delete.cshtml"
               Write(Html.DisplayFor(model => model.StudentMjesto));

#line default
#line hidden
            EndContext();
            BeginContext(1996, 128, true);
            WriteLiteral("\r\n                </dd>\r\n                <br>\r\n                <br>\r\n                <dt class=\"col-sm-6\">\r\n                    ");
            EndContext();
            BeginContext(2125, 47, false);
#line 64 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Students\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.GodinaMajka));

#line default
#line hidden
            EndContext();
            BeginContext(2172, 84, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-4\">\r\n                    ");
            EndContext();
            BeginContext(2257, 43, false);
#line 67 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Students\Delete.cshtml"
               Write(Html.DisplayFor(model => model.GodinaMajka));

#line default
#line hidden
            EndContext();
            BeginContext(2300, 128, true);
            WriteLiteral("\r\n                </dd>\r\n                <br>\r\n                <br>\r\n                <dt class=\"col-sm-6\">\r\n                    ");
            EndContext();
            BeginContext(2429, 46, false);
#line 72 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Students\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.GodinaOtac));

#line default
#line hidden
            EndContext();
            BeginContext(2475, 84, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-4\">\r\n                    ");
            EndContext();
            BeginContext(2560, 42, false);
#line 75 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Students\Delete.cshtml"
               Write(Html.DisplayFor(model => model.GodinaOtac));

#line default
#line hidden
            EndContext();
            BeginContext(2602, 128, true);
            WriteLiteral("\r\n                </dd>\r\n                <br>\r\n                <br>\r\n                <dt class=\"col-sm-6\">\r\n                    ");
            EndContext();
            BeginContext(2731, 46, false);
#line 80 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Students\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.SportMajka));

#line default
#line hidden
            EndContext();
            BeginContext(2777, 84, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-4\">\r\n                    ");
            EndContext();
            BeginContext(2862, 42, false);
#line 83 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Students\Delete.cshtml"
               Write(Html.DisplayFor(model => model.SportMajka));

#line default
#line hidden
            EndContext();
            BeginContext(2904, 128, true);
            WriteLiteral("\r\n                </dd>\r\n                <br>\r\n                <br>\r\n                <dt class=\"col-sm-6\">\r\n                    ");
            EndContext();
            BeginContext(3033, 45, false);
#line 88 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Students\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.SportOtac));

#line default
#line hidden
            EndContext();
            BeginContext(3078, 84, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-4\">\r\n                    ");
            EndContext();
            BeginContext(3163, 41, false);
#line 91 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Students\Delete.cshtml"
               Write(Html.DisplayFor(model => model.SportOtac));

#line default
#line hidden
            EndContext();
            BeginContext(3204, 128, true);
            WriteLiteral("\r\n                </dd>\r\n                <br>\r\n                <br>\r\n                <dt class=\"col-sm-6\">\r\n                    ");
            EndContext();
            BeginContext(3333, 50, false);
#line 96 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Students\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.KojiSportMajka));

#line default
#line hidden
            EndContext();
            BeginContext(3383, 84, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-4\">\r\n                    ");
            EndContext();
            BeginContext(3468, 46, false);
#line 99 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Students\Delete.cshtml"
               Write(Html.DisplayFor(model => model.KojiSportMajka));

#line default
#line hidden
            EndContext();
            BeginContext(3514, 128, true);
            WriteLiteral("\r\n                </dd>\r\n                <br>\r\n                <br>\r\n                <dt class=\"col-sm-6\">\r\n                    ");
            EndContext();
            BeginContext(3643, 49, false);
#line 104 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Students\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.KojiSportOtac));

#line default
#line hidden
            EndContext();
            BeginContext(3692, 84, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-4\">\r\n                    ");
            EndContext();
            BeginContext(3777, 45, false);
#line 107 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Students\Delete.cshtml"
               Write(Html.DisplayFor(model => model.KojiSportOtac));

#line default
#line hidden
            EndContext();
            BeginContext(3822, 128, true);
            WriteLiteral("\r\n                </dd>\r\n                <br>\r\n                <br>\r\n                <dt class=\"col-sm-6\">\r\n                    ");
            EndContext();
            BeginContext(3951, 48, false);
#line 112 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Students\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.SportStudent));

#line default
#line hidden
            EndContext();
            BeginContext(3999, 84, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-4\">\r\n                    ");
            EndContext();
            BeginContext(4084, 44, false);
#line 115 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Students\Delete.cshtml"
               Write(Html.DisplayFor(model => model.SportStudent));

#line default
#line hidden
            EndContext();
            BeginContext(4128, 128, true);
            WriteLiteral("\r\n                </dd>\r\n                <br>\r\n                <br>\r\n                <dt class=\"col-sm-6\">\r\n                    ");
            EndContext();
            BeginContext(4257, 52, false);
#line 120 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Students\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.KojiSportStudent));

#line default
#line hidden
            EndContext();
            BeginContext(4309, 84, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-4\">\r\n                    ");
            EndContext();
            BeginContext(4394, 48, false);
#line 123 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Students\Delete.cshtml"
               Write(Html.DisplayFor(model => model.KojiSportStudent));

#line default
#line hidden
            EndContext();
            BeginContext(4442, 130, true);
            WriteLiteral("\r\n                </dd>\r\n                <br>\r\n                <br>\r\n\r\n                <dt class=\"col-sm-6\">\r\n                    ");
            EndContext();
            BeginContext(4573, 44, false);
#line 129 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Students\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.Trajanje));

#line default
#line hidden
            EndContext();
            BeginContext(4617, 84, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-4\">\r\n                    ");
            EndContext();
            BeginContext(4702, 40, false);
#line 132 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Students\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Trajanje));

#line default
#line hidden
            EndContext();
            BeginContext(4742, 128, true);
            WriteLiteral("\r\n                </dd>\r\n                <br>\r\n                <br>\r\n                <dt class=\"col-sm-6\">\r\n                    ");
            EndContext();
            BeginContext(4871, 47, false);
#line 137 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Students\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.Istovremeno));

#line default
#line hidden
            EndContext();
            BeginContext(4918, 84, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-4\">\r\n                    ");
            EndContext();
            BeginContext(5003, 43, false);
#line 140 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Students\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Istovremeno));

#line default
#line hidden
            EndContext();
            BeginContext(5046, 76, true);
            WriteLiteral("\r\n                </dd>\r\n            </div>\r\n        </div>\r\n    </dl>\r\n    ");
            EndContext();
            BeginContext(5122, 219, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04d8df27be0d497e8a5a2587c9b2dacb", async() => {
                BeginContext(5148, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(5158, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e29a28726736436ca9fab1bc35bfee74", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 146 "C:\Users\Anđela\source\repos\SportApp\SportApp\Views\Students\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.StudentId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5201, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Obriši\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(5285, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a38a7214036c46a5a3cf48211beba77e", async() => {
                    BeginContext(5307, 17, true);
                    WriteLiteral("Povratak na listu");
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
                BeginContext(5328, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5341, 10, true);
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
