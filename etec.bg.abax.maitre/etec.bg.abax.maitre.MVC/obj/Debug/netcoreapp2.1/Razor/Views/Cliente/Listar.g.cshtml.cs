#pragma checksum "C:\Users\3binfo\Documents\Rafael\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Cliente\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad6fa94b0565273390d3d6f1e39ed42cbdf9eb75"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Listar), @"mvc.1.0.view", @"/Views/Cliente/Listar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cliente/Listar.cshtml", typeof(AspNetCore.Views_Cliente_Listar))]
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
#line 1 "C:\Users\3binfo\Documents\Rafael\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\_ViewImports.cshtml"
using etec.bg.abax.maitre.MVC;

#line default
#line hidden
#line 2 "C:\Users\3binfo\Documents\Rafael\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\_ViewImports.cshtml"
using etec.bg.abax.maitre.MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad6fa94b0565273390d3d6f1e39ed42cbdf9eb75", @"/Views/Cliente/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32119c404acac2b8de83c3ea23611565b264ee74", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<etec.bg.abax.maitre.MVC.Models.Pessoa.Cliente>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(67, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\3binfo\Documents\Rafael\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Cliente\Listar.cshtml"
  
    ViewData["Title"] = "Listar";

#line default
#line hidden
            BeginContext(111, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(140, 101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e880dca57a4845d480aa172c1b057c66", async() => {
                BeginContext(146, 88, true);
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
            BeginContext(241, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(243, 1540, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21e51109bcab4c3486b5bf36812de074", async() => {
                BeginContext(249, 11, true);
                WriteLiteral("\r\n<p>\r\n    ");
                EndContext();
                BeginContext(260, 37, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8468b187d4b64911a3c50419fd39e10f", async() => {
                    BeginContext(283, 10, true);
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
                BeginContext(297, 92, true);
                WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(390, 45, false);
#line 22 "C:\Users\3binfo\Documents\Rafael\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Cliente\Listar.cshtml"
           Write(Html.DisplayNameFor(model => model.idCliente));

#line default
#line hidden
                EndContext();
                BeginContext(435, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(491, 39, false);
#line 25 "C:\Users\3binfo\Documents\Rafael\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Cliente\Listar.cshtml"
           Write(Html.DisplayNameFor(model => model.cpf));

#line default
#line hidden
                EndContext();
                BeginContext(530, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(586, 40, false);
#line 28 "C:\Users\3binfo\Documents\Rafael\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Cliente\Listar.cshtml"
           Write(Html.DisplayNameFor(model => model.nome));

#line default
#line hidden
                EndContext();
                BeginContext(626, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(682, 40, false);
#line 31 "C:\Users\3binfo\Documents\Rafael\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Cliente\Listar.cshtml"
           Write(Html.DisplayNameFor(model => model.fone));

#line default
#line hidden
                EndContext();
                BeginContext(722, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(778, 41, false);
#line 34 "C:\Users\3binfo\Documents\Rafael\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Cliente\Listar.cshtml"
           Write(Html.DisplayNameFor(model => model.eMail));

#line default
#line hidden
                EndContext();
                BeginContext(819, 86, true);
                WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
                EndContext();
#line 40 "C:\Users\3binfo\Documents\Rafael\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Cliente\Listar.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
                BeginContext(937, 48, true);
                WriteLiteral("        <tr>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(986, 44, false);
#line 43 "C:\Users\3binfo\Documents\Rafael\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Cliente\Listar.cshtml"
           Write(Html.DisplayFor(modelItem => item.idCliente));

#line default
#line hidden
                EndContext();
                BeginContext(1030, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(1086, 38, false);
#line 46 "C:\Users\3binfo\Documents\Rafael\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Cliente\Listar.cshtml"
           Write(Html.DisplayFor(modelItem => item.cpf));

#line default
#line hidden
                EndContext();
                BeginContext(1124, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(1180, 39, false);
#line 49 "C:\Users\3binfo\Documents\Rafael\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Cliente\Listar.cshtml"
           Write(Html.DisplayFor(modelItem => item.nome));

#line default
#line hidden
                EndContext();
                BeginContext(1219, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(1275, 39, false);
#line 52 "C:\Users\3binfo\Documents\Rafael\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Cliente\Listar.cshtml"
           Write(Html.DisplayFor(modelItem => item.fone));

#line default
#line hidden
                EndContext();
                BeginContext(1314, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(1370, 40, false);
#line 55 "C:\Users\3binfo\Documents\Rafael\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Cliente\Listar.cshtml"
           Write(Html.DisplayFor(modelItem => item.eMail));

#line default
#line hidden
                EndContext();
                BeginContext(1410, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(1466, 65, false);
#line 58 "C:\Users\3binfo\Documents\Rafael\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Cliente\Listar.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
                EndContext();
                BeginContext(1531, 20, true);
                WriteLiteral(" |\r\n                ");
                EndContext();
                BeginContext(1552, 71, false);
#line 59 "C:\Users\3binfo\Documents\Rafael\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Cliente\Listar.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
                EndContext();
                BeginContext(1623, 20, true);
                WriteLiteral(" |\r\n                ");
                EndContext();
                BeginContext(1644, 69, false);
#line 60 "C:\Users\3binfo\Documents\Rafael\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Cliente\Listar.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
                EndContext();
                BeginContext(1713, 36, true);
                WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
                EndContext();
#line 63 "C:\Users\3binfo\Documents\Rafael\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Cliente\Listar.cshtml"
}

#line default
#line hidden
                BeginContext(1752, 24, true);
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
            BeginContext(1783, 11, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<etec.bg.abax.maitre.MVC.Models.Pessoa.Cliente>> Html { get; private set; }
    }
}
#pragma warning restore 1591
