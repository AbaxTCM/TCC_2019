#pragma checksum "C:\Users\3binfo\Documents\Rafael\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Porcao\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0ce51bf37d67810d85596ba73b8e39c10fc5f85"
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
#line 1 "C:\Users\3binfo\Documents\Rafael\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\_ViewImports.cshtml"
using etec.bg.abax.maitre.MVC;

#line default
#line hidden
#line 2 "C:\Users\3binfo\Documents\Rafael\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\_ViewImports.cshtml"
using etec.bg.abax.maitre.MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0ce51bf37d67810d85596ba73b8e39c10fc5f85", @"/Views/Porcao/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32119c404acac2b8de83c3ea23611565b264ee74", @"/Views/_ViewImports.cshtml")]
    public class Views_Porcao_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<etec.bg.abax.maitre.MVC.Models.Cardapio.Porcao>>
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
            BeginContext(68, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\3binfo\Documents\Rafael\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Porcao\Listar.cshtml"
  
    ViewData["Title"] = "Listar";

#line default
#line hidden
            BeginContext(112, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(141, 101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82cb901e72ba4a99b8004b5343985ead", async() => {
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
            BeginContext(244, 1554, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "549a4554c03d49d0ad6d2c8c723c3f84", async() => {
                BeginContext(250, 11, true);
                WriteLiteral("\r\n<p>\r\n    ");
                EndContext();
                BeginContext(261, 37, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "779ab4066761487b8b09318d3a31e9ac", async() => {
                    BeginContext(284, 10, true);
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
                BeginContext(298, 92, true);
                WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(391, 44, false);
#line 22 "C:\Users\3binfo\Documents\Rafael\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Porcao\Listar.cshtml"
           Write(Html.DisplayNameFor(model => model.idPorcao));

#line default
#line hidden
                EndContext();
                BeginContext(435, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(491, 45, false);
#line 25 "C:\Users\3binfo\Documents\Rafael\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Porcao\Listar.cshtml"
           Write(Html.DisplayNameFor(model => model.descricao));

#line default
#line hidden
                EndContext();
                BeginContext(536, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(592, 40, false);
#line 28 "C:\Users\3binfo\Documents\Rafael\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Porcao\Listar.cshtml"
           Write(Html.DisplayNameFor(model => model.nome));

#line default
#line hidden
                EndContext();
                BeginContext(632, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(688, 42, false);
#line 31 "C:\Users\3binfo\Documents\Rafael\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Porcao\Listar.cshtml"
           Write(Html.DisplayNameFor(model => model.imagem));

#line default
#line hidden
                EndContext();
                BeginContext(730, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(786, 41, false);
#line 34 "C:\Users\3binfo\Documents\Rafael\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Porcao\Listar.cshtml"
           Write(Html.DisplayNameFor(model => model.valor));

#line default
#line hidden
                EndContext();
                BeginContext(827, 86, true);
                WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
                EndContext();
#line 40 "C:\Users\3binfo\Documents\Rafael\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Porcao\Listar.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
                BeginContext(945, 48, true);
                WriteLiteral("        <tr>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(994, 43, false);
#line 43 "C:\Users\3binfo\Documents\Rafael\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Porcao\Listar.cshtml"
           Write(Html.DisplayFor(modelItem => item.idPorcao));

#line default
#line hidden
                EndContext();
                BeginContext(1037, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(1093, 44, false);
#line 46 "C:\Users\3binfo\Documents\Rafael\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Porcao\Listar.cshtml"
           Write(Html.DisplayFor(modelItem => item.descricao));

#line default
#line hidden
                EndContext();
                BeginContext(1137, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(1193, 39, false);
#line 49 "C:\Users\3binfo\Documents\Rafael\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Porcao\Listar.cshtml"
           Write(Html.DisplayFor(modelItem => item.nome));

#line default
#line hidden
                EndContext();
                BeginContext(1232, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(1288, 41, false);
#line 52 "C:\Users\3binfo\Documents\Rafael\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Porcao\Listar.cshtml"
           Write(Html.DisplayFor(modelItem => item.imagem));

#line default
#line hidden
                EndContext();
                BeginContext(1329, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(1385, 40, false);
#line 55 "C:\Users\3binfo\Documents\Rafael\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Porcao\Listar.cshtml"
           Write(Html.DisplayFor(modelItem => item.valor));

#line default
#line hidden
                EndContext();
                BeginContext(1425, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(1481, 65, false);
#line 58 "C:\Users\3binfo\Documents\Rafael\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Porcao\Listar.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
                EndContext();
                BeginContext(1546, 20, true);
                WriteLiteral(" |\r\n                ");
                EndContext();
                BeginContext(1567, 71, false);
#line 59 "C:\Users\3binfo\Documents\Rafael\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Porcao\Listar.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
                EndContext();
                BeginContext(1638, 20, true);
                WriteLiteral(" |\r\n                ");
                EndContext();
                BeginContext(1659, 69, false);
#line 60 "C:\Users\3binfo\Documents\Rafael\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Porcao\Listar.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
                EndContext();
                BeginContext(1728, 36, true);
                WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
                EndContext();
#line 63 "C:\Users\3binfo\Documents\Rafael\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Porcao\Listar.cshtml"
}

#line default
#line hidden
                BeginContext(1767, 24, true);
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
            BeginContext(1798, 11, true);
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
