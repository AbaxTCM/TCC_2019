#pragma checksum "C:\Users\Rafael.Rios\Documents\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Bebida\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb10b7a6dfe720106bc0edf90399b7f7be04ca60"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bebida_Listar), @"mvc.1.0.view", @"/Views/Bebida/Listar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Bebida/Listar.cshtml", typeof(AspNetCore.Views_Bebida_Listar))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb10b7a6dfe720106bc0edf90399b7f7be04ca60", @"/Views/Bebida/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32119c404acac2b8de83c3ea23611565b264ee74", @"/Views/_ViewImports.cshtml")]
    public class Views_Bebida_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<etec.bg.abax.maitre.MVC.Models.Cardapio.Bebida>>
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
#line 3 "C:\Users\Rafael.Rios\Documents\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Bebida\Listar.cshtml"
  
    ViewData["Title"] = "Listar";

#line default
#line hidden
            BeginContext(112, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(141, 101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e5ea39aa4a3143bbbba71db8abc828cf", async() => {
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
            BeginContext(244, 1533, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86e33c6b12cd4ae9b02a5721554bb0c7", async() => {
                BeginContext(250, 11, true);
                WriteLiteral("\r\n<p>\r\n    ");
                EndContext();
                BeginContext(261, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "885bfa678c2c416197244d6194a46835", async() => {
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
#line 22 "C:\Users\Rafael.Rios\Documents\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Bebida\Listar.cshtml"
           Write(Html.DisplayNameFor(model => model.idBebida));

#line default
#line hidden
                EndContext();
                BeginContext(438, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(494, 40, false);
#line 25 "C:\Users\Rafael.Rios\Documents\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Bebida\Listar.cshtml"
           Write(Html.DisplayNameFor(model => model.tipo));

#line default
#line hidden
                EndContext();
                BeginContext(534, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(590, 40, false);
#line 28 "C:\Users\Rafael.Rios\Documents\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Bebida\Listar.cshtml"
           Write(Html.DisplayNameFor(model => model.nome));

#line default
#line hidden
                EndContext();
                BeginContext(630, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(686, 42, false);
#line 31 "C:\Users\Rafael.Rios\Documents\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Bebida\Listar.cshtml"
           Write(Html.DisplayNameFor(model => model.imagem));

#line default
#line hidden
                EndContext();
                BeginContext(728, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(784, 41, false);
#line 34 "C:\Users\Rafael.Rios\Documents\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Bebida\Listar.cshtml"
           Write(Html.DisplayNameFor(model => model.valor));

#line default
#line hidden
                EndContext();
                BeginContext(825, 86, true);
                WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
                EndContext();
#line 40 "C:\Users\Rafael.Rios\Documents\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Bebida\Listar.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
                BeginContext(943, 48, true);
                WriteLiteral("        <tr>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(992, 43, false);
#line 43 "C:\Users\Rafael.Rios\Documents\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Bebida\Listar.cshtml"
           Write(Html.DisplayFor(modelItem => item.idBebida));

#line default
#line hidden
                EndContext();
                BeginContext(1035, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(1091, 39, false);
#line 46 "C:\Users\Rafael.Rios\Documents\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Bebida\Listar.cshtml"
           Write(Html.DisplayFor(modelItem => item.tipo));

#line default
#line hidden
                EndContext();
                BeginContext(1130, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(1186, 39, false);
#line 49 "C:\Users\Rafael.Rios\Documents\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Bebida\Listar.cshtml"
           Write(Html.DisplayFor(modelItem => item.nome));

#line default
#line hidden
                EndContext();
                BeginContext(1225, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(1281, 41, false);
#line 52 "C:\Users\Rafael.Rios\Documents\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Bebida\Listar.cshtml"
           Write(Html.DisplayFor(modelItem => item.imagem));

#line default
#line hidden
                EndContext();
                BeginContext(1322, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(1378, 40, false);
#line 55 "C:\Users\Rafael.Rios\Documents\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Bebida\Listar.cshtml"
           Write(Html.DisplayFor(modelItem => item.valor));

#line default
#line hidden
                EndContext();
                BeginContext(1418, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(1474, 61, false);
#line 58 "C:\Users\Rafael.Rios\Documents\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Bebida\Listar.cshtml"
           Write(Html.ActionLink("Edit", "Editar", new { id = item.idBebida }));

#line default
#line hidden
                EndContext();
                BeginContext(1535, 20, true);
                WriteLiteral(" |\r\n                ");
                EndContext();
                BeginContext(1556, 66, false);
#line 59 "C:\Users\Rafael.Rios\Documents\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Bebida\Listar.cshtml"
           Write(Html.ActionLink("Details", "Detalhar", new { id = item.idBebida }));

#line default
#line hidden
                EndContext();
                BeginContext(1622, 20, true);
                WriteLiteral(" |\r\n                ");
                EndContext();
                BeginContext(1643, 64, false);
#line 60 "C:\Users\Rafael.Rios\Documents\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Bebida\Listar.cshtml"
           Write(Html.ActionLink("Delete", "Deletar", new { id = item.idBebida }));

#line default
#line hidden
                EndContext();
                BeginContext(1707, 36, true);
                WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
                EndContext();
#line 63 "C:\Users\Rafael.Rios\Documents\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Bebida\Listar.cshtml"
}

#line default
#line hidden
                BeginContext(1746, 24, true);
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
            BeginContext(1777, 11, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<etec.bg.abax.maitre.MVC.Models.Cardapio.Bebida>> Html { get; private set; }
    }
}
#pragma warning restore 1591
