#pragma checksum "C:\Users\Rafael.Rios\Documents\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Prato\Detalhar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba2a27587240d3f197ba2bd7967b8a025c07da64"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Prato_Detalhar), @"mvc.1.0.view", @"/Views/Prato/Detalhar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Prato/Detalhar.cshtml", typeof(AspNetCore.Views_Prato_Detalhar))]
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
#line 1 "C:\Users\Rafael.Rios\Documents\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\_ViewImports.cshtml"
using etec.bg.abax.maitre.MVC;

#line default
#line hidden
#line 2 "C:\Users\Rafael.Rios\Documents\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\_ViewImports.cshtml"
using etec.bg.abax.maitre.MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba2a27587240d3f197ba2bd7967b8a025c07da64", @"/Views/Prato/Detalhar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32119c404acac2b8de83c3ea23611565b264ee74", @"/Views/_ViewImports.cshtml")]
    public class Views_Prato_Detalhar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<etec.bg.abax.maitre.MVC.Models.Cardapio.Prato>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Rafael.Rios\Documents\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Prato\Detalhar.cshtml"
  
    ViewData["Title"] = "Detalhar";

#line default
#line hidden
            BeginContext(100, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(129, 103, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "154ff365a9804394ac7149b8006f39e6", async() => {
                BeginContext(135, 90, true);
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
            BeginContext(232, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(234, 911, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e6f3bb85cfc4ff3a76585db8cc00561", async() => {
                BeginContext(240, 101, true);
                WriteLiteral("\r\n\r\n<div>\r\n    <h4>Prato</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(342, 43, false);
#line 21 "C:\Users\Rafael.Rios\Documents\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Prato\Detalhar.cshtml"
       Write(Html.DisplayNameFor(model => model.idPrato));

#line default
#line hidden
                EndContext();
                BeginContext(385, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(429, 39, false);
#line 24 "C:\Users\Rafael.Rios\Documents\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Prato\Detalhar.cshtml"
       Write(Html.DisplayFor(model => model.idPrato));

#line default
#line hidden
                EndContext();
                BeginContext(468, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(512, 40, false);
#line 27 "C:\Users\Rafael.Rios\Documents\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Prato\Detalhar.cshtml"
       Write(Html.DisplayNameFor(model => model.nome));

#line default
#line hidden
                EndContext();
                BeginContext(552, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(596, 36, false);
#line 30 "C:\Users\Rafael.Rios\Documents\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Prato\Detalhar.cshtml"
       Write(Html.DisplayFor(model => model.nome));

#line default
#line hidden
                EndContext();
                BeginContext(632, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(676, 42, false);
#line 33 "C:\Users\Rafael.Rios\Documents\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Prato\Detalhar.cshtml"
       Write(Html.DisplayNameFor(model => model.imagem));

#line default
#line hidden
                EndContext();
                BeginContext(718, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(762, 38, false);
#line 36 "C:\Users\Rafael.Rios\Documents\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Prato\Detalhar.cshtml"
       Write(Html.DisplayFor(model => model.imagem));

#line default
#line hidden
                EndContext();
                BeginContext(800, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(844, 41, false);
#line 39 "C:\Users\Rafael.Rios\Documents\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Prato\Detalhar.cshtml"
       Write(Html.DisplayNameFor(model => model.valor));

#line default
#line hidden
                EndContext();
                BeginContext(885, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(929, 37, false);
#line 42 "C:\Users\Rafael.Rios\Documents\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Prato\Detalhar.cshtml"
       Write(Html.DisplayFor(model => model.valor));

#line default
#line hidden
                EndContext();
                BeginContext(966, 47, true);
                WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
                EndContext();
                BeginContext(1014, 68, false);
#line 47 "C:\Users\Rafael.Rios\Documents\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Prato\Detalhar.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
                EndContext();
                BeginContext(1082, 8, true);
                WriteLiteral(" |\r\n    ");
                EndContext();
                BeginContext(1090, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "017d2ed8bd074e429009305662537b3f", async() => {
                    BeginContext(1112, 12, true);
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
                BeginContext(1128, 10, true);
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
            BeginContext(1145, 11, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<etec.bg.abax.maitre.MVC.Models.Cardapio.Prato> Html { get; private set; }
    }
}
#pragma warning restore 1591
