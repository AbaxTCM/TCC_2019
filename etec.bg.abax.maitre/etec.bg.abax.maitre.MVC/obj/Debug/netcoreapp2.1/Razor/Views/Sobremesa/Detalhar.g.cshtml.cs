#pragma checksum "C:\Users\Rafael.Rios\Documents\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Sobremesa\Detalhar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b361910e3eebd1e90a740f0142ae4bda7b13e96"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sobremesa_Detalhar), @"mvc.1.0.view", @"/Views/Sobremesa/Detalhar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Sobremesa/Detalhar.cshtml", typeof(AspNetCore.Views_Sobremesa_Detalhar))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b361910e3eebd1e90a740f0142ae4bda7b13e96", @"/Views/Sobremesa/Detalhar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32119c404acac2b8de83c3ea23611565b264ee74", @"/Views/_ViewImports.cshtml")]
    public class Views_Sobremesa_Detalhar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<etec.bg.abax.maitre.MVC.Models.Cardapio.Sobremesa>
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
#line 3 "C:\Users\Rafael.Rios\Documents\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Sobremesa\Detalhar.cshtml"
  
    ViewData["Title"] = "Detalhar";

#line default
#line hidden
            BeginContext(104, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(133, 103, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2be0337309c4cfc98ed6d8dbb3e8a56", async() => {
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
            BeginContext(238, 921, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b90deb6af7d245efba32db38ae9fa50b", async() => {
                BeginContext(244, 105, true);
                WriteLiteral("\r\n\r\n<div>\r\n    <h4>Sobremesa</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(350, 47, false);
#line 21 "C:\Users\Rafael.Rios\Documents\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Sobremesa\Detalhar.cshtml"
       Write(Html.DisplayNameFor(model => model.idSobremesa));

#line default
#line hidden
                EndContext();
                BeginContext(397, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(441, 43, false);
#line 24 "C:\Users\Rafael.Rios\Documents\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Sobremesa\Detalhar.cshtml"
       Write(Html.DisplayFor(model => model.idSobremesa));

#line default
#line hidden
                EndContext();
                BeginContext(484, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(528, 40, false);
#line 27 "C:\Users\Rafael.Rios\Documents\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Sobremesa\Detalhar.cshtml"
       Write(Html.DisplayNameFor(model => model.nome));

#line default
#line hidden
                EndContext();
                BeginContext(568, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(612, 36, false);
#line 30 "C:\Users\Rafael.Rios\Documents\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Sobremesa\Detalhar.cshtml"
       Write(Html.DisplayFor(model => model.nome));

#line default
#line hidden
                EndContext();
                BeginContext(648, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(692, 42, false);
#line 33 "C:\Users\Rafael.Rios\Documents\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Sobremesa\Detalhar.cshtml"
       Write(Html.DisplayNameFor(model => model.imagem));

#line default
#line hidden
                EndContext();
                BeginContext(734, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(778, 38, false);
#line 36 "C:\Users\Rafael.Rios\Documents\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Sobremesa\Detalhar.cshtml"
       Write(Html.DisplayFor(model => model.imagem));

#line default
#line hidden
                EndContext();
                BeginContext(816, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(860, 41, false);
#line 39 "C:\Users\Rafael.Rios\Documents\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Sobremesa\Detalhar.cshtml"
       Write(Html.DisplayNameFor(model => model.valor));

#line default
#line hidden
                EndContext();
                BeginContext(901, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(945, 37, false);
#line 42 "C:\Users\Rafael.Rios\Documents\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Sobremesa\Detalhar.cshtml"
       Write(Html.DisplayFor(model => model.valor));

#line default
#line hidden
                EndContext();
                BeginContext(982, 47, true);
                WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
                EndContext();
                BeginContext(1030, 65, false);
#line 47 "C:\Users\Rafael.Rios\Documents\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Sobremesa\Detalhar.cshtml"
Write(Html.ActionLink("Edit", "Editar", new { id = Model.idSobremesa }));

#line default
#line hidden
                EndContext();
                BeginContext(1095, 8, true);
                WriteLiteral(" |\r\n    ");
                EndContext();
                BeginContext(1103, 39, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ead363c4912648c38c14a318578dc98b", async() => {
                    BeginContext(1126, 12, true);
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
                BeginContext(1142, 10, true);
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
            BeginContext(1159, 11, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<etec.bg.abax.maitre.MVC.Models.Cardapio.Sobremesa> Html { get; private set; }
    }
}
#pragma warning restore 1591
