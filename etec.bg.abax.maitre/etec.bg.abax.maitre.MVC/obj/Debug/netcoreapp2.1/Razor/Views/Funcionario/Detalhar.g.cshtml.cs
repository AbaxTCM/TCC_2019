#pragma checksum "C:\Users\gialm\Documents\Nova pasta (4)\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Funcionario\Detalhar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "050fe14c8ab0e70d64bf482d0ca3c8987d8326e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Funcionario_Detalhar), @"mvc.1.0.view", @"/Views/Funcionario/Detalhar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Funcionario/Detalhar.cshtml", typeof(AspNetCore.Views_Funcionario_Detalhar))]
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
#line 1 "C:\Users\gialm\Documents\Nova pasta (4)\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\_ViewImports.cshtml"
using etec.bg.abax.maitre.MVC;

#line default
#line hidden
#line 2 "C:\Users\gialm\Documents\Nova pasta (4)\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\_ViewImports.cshtml"
using etec.bg.abax.maitre.MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"050fe14c8ab0e70d64bf482d0ca3c8987d8326e3", @"/Views/Funcionario/Detalhar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32119c404acac2b8de83c3ea23611565b264ee74", @"/Views/_ViewImports.cshtml")]
    public class Views_Funcionario_Detalhar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<etec.bg.abax.maitre.MVC.Models.Pessoa.Funcionario>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Listar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(58, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\gialm\Documents\Nova pasta (4)\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Funcionario\Detalhar.cshtml"
  
    ViewData["Title"] = "Detalhar";

#line default
#line hidden
            BeginContext(104, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(133, 103, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af71af2700d34502b1e7275e96c82577", async() => {
                BeginContext(139, 90, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Detalhar</title>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(236, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(238, 1070, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bff6af6cd8d947e4a19124bab2b103c3", async() => {
                BeginContext(244, 107, true);
                WriteLiteral("\r\n\r\n<div>\r\n    <h4>Funcionario</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(352, 42, false);
#line 21 "C:\Users\gialm\Documents\Nova pasta (4)\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Funcionario\Detalhar.cshtml"
       Write(Html.DisplayNameFor(model => model.idFunc));

#line default
#line hidden
                EndContext();
                BeginContext(394, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(438, 38, false);
#line 24 "C:\Users\gialm\Documents\Nova pasta (4)\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Funcionario\Detalhar.cshtml"
       Write(Html.DisplayFor(model => model.idFunc));

#line default
#line hidden
                EndContext();
                BeginContext(476, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(520, 41, false);
#line 27 "C:\Users\gialm\Documents\Nova pasta (4)\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Funcionario\Detalhar.cshtml"
       Write(Html.DisplayNameFor(model => model.cargo));

#line default
#line hidden
                EndContext();
                BeginContext(561, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(605, 37, false);
#line 30 "C:\Users\gialm\Documents\Nova pasta (4)\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Funcionario\Detalhar.cshtml"
       Write(Html.DisplayFor(model => model.cargo));

#line default
#line hidden
                EndContext();
                BeginContext(642, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(686, 40, false);
#line 33 "C:\Users\gialm\Documents\Nova pasta (4)\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Funcionario\Detalhar.cshtml"
       Write(Html.DisplayNameFor(model => model.nome));

#line default
#line hidden
                EndContext();
                BeginContext(726, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(770, 36, false);
#line 36 "C:\Users\gialm\Documents\Nova pasta (4)\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Funcionario\Detalhar.cshtml"
       Write(Html.DisplayFor(model => model.nome));

#line default
#line hidden
                EndContext();
                BeginContext(806, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(850, 40, false);
#line 39 "C:\Users\gialm\Documents\Nova pasta (4)\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Funcionario\Detalhar.cshtml"
       Write(Html.DisplayNameFor(model => model.fone));

#line default
#line hidden
                EndContext();
                BeginContext(890, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(934, 36, false);
#line 42 "C:\Users\gialm\Documents\Nova pasta (4)\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Funcionario\Detalhar.cshtml"
       Write(Html.DisplayFor(model => model.fone));

#line default
#line hidden
                EndContext();
                BeginContext(970, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(1014, 41, false);
#line 45 "C:\Users\gialm\Documents\Nova pasta (4)\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Funcionario\Detalhar.cshtml"
       Write(Html.DisplayNameFor(model => model.eMail));

#line default
#line hidden
                EndContext();
                BeginContext(1055, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(1099, 37, false);
#line 48 "C:\Users\gialm\Documents\Nova pasta (4)\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Funcionario\Detalhar.cshtml"
       Write(Html.DisplayFor(model => model.eMail));

#line default
#line hidden
                EndContext();
                BeginContext(1136, 47, true);
                WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
                EndContext();
                BeginContext(1184, 60, false);
#line 53 "C:\Users\gialm\Documents\Nova pasta (4)\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Funcionario\Detalhar.cshtml"
Write(Html.ActionLink("Edit", "Editar", new { id = Model.idFunc }));

#line default
#line hidden
                EndContext();
                BeginContext(1244, 8, true);
                WriteLiteral(" |\r\n    ");
                EndContext();
                BeginContext(1252, 39, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b09fe07efe9d493ca22ece8391948be2", async() => {
                    BeginContext(1275, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1291, 10, true);
                WriteLiteral("\r\n</div>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(1308, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<etec.bg.abax.maitre.MVC.Models.Pessoa.Funcionario> Html { get; private set; }
    }
}
#pragma warning restore 1591
