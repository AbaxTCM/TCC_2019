#pragma checksum "C:\Users\Rafael.Rios\Documents\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Porcao\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea9c00f49dcdd15e16c874b9fae1f25c53a81413"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Porcao_Listar), @"mvc.1.0.view", @"/Views/Porcao/Listar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Porcao/Listar.cshtml", typeof(AspNetCore.Views_Porcao_Listar))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea9c00f49dcdd15e16c874b9fae1f25c53a81413", @"/Views/Porcao/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32119c404acac2b8de83c3ea23611565b264ee74", @"/Views/_ViewImports.cshtml")]
    public class Views_Porcao_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<etec.bg.abax.maitre.MVC.Models.Cardapio.Porcao>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Cadastrar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(68, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Rafael.Rios\Documents\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Porcao\Listar.cshtml"
  
    ViewData["Title"] = "Listar";

#line default
#line hidden
            BeginContext(112, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(141, 101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4fa441b4c3c74530beaaf5976a3663dc", async() => {
                BeginContext(147, 88, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Listar</title>\r\n");
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
            BeginContext(242, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(244, 1543, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0beaccf8fc8044d98bc18626109f9763", async() => {
                BeginContext(250, 11, true);
                WriteLiteral("\r\n<p>\r\n    ");
                EndContext();
                BeginContext(261, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a8d72c29767d417ab3725d98eda7e74e", async() => {
                    BeginContext(287, 10, true);
                    WriteLiteral("Create New");
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
                BeginContext(301, 92, true);
                WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(394, 44, false);
#line 22 "C:\Users\Rafael.Rios\Documents\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Porcao\Listar.cshtml"
           Write(Html.DisplayNameFor(model => model.idPorcao));

#line default
#line hidden
                EndContext();
                BeginContext(438, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(494, 45, false);
#line 25 "C:\Users\Rafael.Rios\Documents\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Porcao\Listar.cshtml"
           Write(Html.DisplayNameFor(model => model.descricao));

#line default
#line hidden
                EndContext();
                BeginContext(539, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(595, 40, false);
#line 28 "C:\Users\Rafael.Rios\Documents\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Porcao\Listar.cshtml"
           Write(Html.DisplayNameFor(model => model.nome));

#line default
#line hidden
                EndContext();
                BeginContext(635, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(691, 42, false);
#line 31 "C:\Users\Rafael.Rios\Documents\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Porcao\Listar.cshtml"
           Write(Html.DisplayNameFor(model => model.imagem));

#line default
#line hidden
                EndContext();
                BeginContext(733, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(789, 41, false);
#line 34 "C:\Users\Rafael.Rios\Documents\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Porcao\Listar.cshtml"
           Write(Html.DisplayNameFor(model => model.valor));

#line default
#line hidden
                EndContext();
                BeginContext(830, 86, true);
                WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
                EndContext();
#line 40 "C:\Users\Rafael.Rios\Documents\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Porcao\Listar.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
                BeginContext(948, 48, true);
                WriteLiteral("        <tr>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(997, 43, false);
#line 43 "C:\Users\Rafael.Rios\Documents\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Porcao\Listar.cshtml"
           Write(Html.DisplayFor(modelItem => item.idPorcao));

#line default
#line hidden
                EndContext();
                BeginContext(1040, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(1096, 44, false);
#line 46 "C:\Users\Rafael.Rios\Documents\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Porcao\Listar.cshtml"
           Write(Html.DisplayFor(modelItem => item.descricao));

#line default
#line hidden
                EndContext();
                BeginContext(1140, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(1196, 39, false);
#line 49 "C:\Users\Rafael.Rios\Documents\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Porcao\Listar.cshtml"
           Write(Html.DisplayFor(modelItem => item.nome));

#line default
#line hidden
                EndContext();
                BeginContext(1235, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(1291, 41, false);
#line 52 "C:\Users\Rafael.Rios\Documents\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Porcao\Listar.cshtml"
           Write(Html.DisplayFor(modelItem => item.imagem));

#line default
#line hidden
                EndContext();
                BeginContext(1332, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(1388, 40, false);
#line 55 "C:\Users\Rafael.Rios\Documents\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Porcao\Listar.cshtml"
           Write(Html.DisplayFor(modelItem => item.valor));

#line default
#line hidden
                EndContext();
                BeginContext(1428, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(1484, 61, false);
#line 58 "C:\Users\Rafael.Rios\Documents\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Porcao\Listar.cshtml"
           Write(Html.ActionLink("Edit", "Editar", new { id = item.idPorcao }));

#line default
#line hidden
                EndContext();
                BeginContext(1545, 20, true);
                WriteLiteral(" |\r\n                ");
                EndContext();
                BeginContext(1566, 66, false);
#line 59 "C:\Users\Rafael.Rios\Documents\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Porcao\Listar.cshtml"
           Write(Html.ActionLink("Details", "Detalhar", new { id = item.idPorcao }));

#line default
#line hidden
                EndContext();
                BeginContext(1632, 20, true);
                WriteLiteral(" |\r\n                ");
                EndContext();
                BeginContext(1653, 64, false);
#line 60 "C:\Users\Rafael.Rios\Documents\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Porcao\Listar.cshtml"
           Write(Html.ActionLink("Delete", "Deletar", new { id = item.idPorcao }));

#line default
#line hidden
                EndContext();
                BeginContext(1717, 36, true);
                WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
                EndContext();
#line 63 "C:\Users\Rafael.Rios\Documents\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Porcao\Listar.cshtml"
}

#line default
#line hidden
                BeginContext(1756, 24, true);
                WriteLiteral("    </tbody>\r\n</table>\r\n");
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
            BeginContext(1787, 11, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<etec.bg.abax.maitre.MVC.Models.Cardapio.Porcao>> Html { get; private set; }
    }
}
#pragma warning restore 1591
