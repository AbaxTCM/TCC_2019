#pragma checksum "C:\Users\Rafael.Rios\Desktop\Icones\TCC\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Bebida\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "557cf7ff95bbabb3d30a86bb0c91c79fa4095cda"
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
#line 1 "C:\Users\Rafael.Rios\Desktop\Icones\TCC\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\_ViewImports.cshtml"
using etec.bg.abax.maitre.MVC;

#line default
#line hidden
#line 2 "C:\Users\Rafael.Rios\Desktop\Icones\TCC\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\_ViewImports.cshtml"
using etec.bg.abax.maitre.MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"557cf7ff95bbabb3d30a86bb0c91c79fa4095cda", @"/Views/Bebida/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32119c404acac2b8de83c3ea23611565b264ee74", @"/Views/_ViewImports.cshtml")]
    public class Views_Bebida_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<etec.bg.abax.maitre.MVC.Models.Cardapio.Bebida>>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(68, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Rafael.Rios\Desktop\Icones\TCC\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Bebida\Listar.cshtml"
  
    ViewData["Title"] = "Listar";

#line default
#line hidden
            BeginContext(112, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(141, 101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9732a096ed6f4d6c8370a48b490fcffa", async() => {
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
            BeginContext(244, 2786, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b252c6f744d84302a299e766ce7743e6", async() => {
                BeginContext(250, 162, true);
                WriteLiteral("\r\n    <!--\r\n    <p>\r\n        <a asp-action=\"Cadastrar\">Create New</a>\r\n    </p>-->\r\n    <p>\r\n        <h3>Cadastrar bebida <button title=\"\" class=\"btn btn-primary\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 412, "\"", 471, 3);
                WriteAttributeValue("", 422, "location.href=\'", 422, 15, true);
#line 20 "C:\Users\Rafael.Rios\Desktop\Icones\TCC\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Bebida\Listar.cshtml"
WriteAttributeValue("", 437, Url.Action("Cadastrar","Bebida"), 437, 33, false);

#line default
#line hidden
                WriteAttributeValue("", 470, "\'", 470, 1, true);
                EndWriteAttribute();
                BeginContext(472, 198, true);
                WriteLiteral("><i class=\"glyphicon glyphicon-plus\"></i></h3> </button>\r\n    </p>\r\n    <br />\r\n    <br />\r\n\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(671, 44, false);
#line 29 "C:\Users\Rafael.Rios\Desktop\Icones\TCC\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Bebida\Listar.cshtml"
               Write(Html.DisplayNameFor(model => model.idBebida));

#line default
#line hidden
                EndContext();
                BeginContext(715, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(783, 40, false);
#line 32 "C:\Users\Rafael.Rios\Desktop\Icones\TCC\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Bebida\Listar.cshtml"
               Write(Html.DisplayNameFor(model => model.tipo));

#line default
#line hidden
                EndContext();
                BeginContext(823, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(891, 40, false);
#line 35 "C:\Users\Rafael.Rios\Desktop\Icones\TCC\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Bebida\Listar.cshtml"
               Write(Html.DisplayNameFor(model => model.nome));

#line default
#line hidden
                EndContext();
                BeginContext(931, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(999, 42, false);
#line 38 "C:\Users\Rafael.Rios\Desktop\Icones\TCC\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Bebida\Listar.cshtml"
               Write(Html.DisplayNameFor(model => model.imagem));

#line default
#line hidden
                EndContext();
                BeginContext(1041, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(1109, 41, false);
#line 41 "C:\Users\Rafael.Rios\Desktop\Icones\TCC\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Bebida\Listar.cshtml"
               Write(Html.DisplayNameFor(model => model.valor));

#line default
#line hidden
                EndContext();
                BeginContext(1150, 106, true);
                WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
                EndContext();
#line 47 "C:\Users\Rafael.Rios\Desktop\Icones\TCC\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Bebida\Listar.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
                BeginContext(1313, 72, true);
                WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1386, 43, false);
#line 51 "C:\Users\Rafael.Rios\Desktop\Icones\TCC\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Bebida\Listar.cshtml"
                   Write(Html.DisplayFor(modelItem => item.idBebida));

#line default
#line hidden
                EndContext();
                BeginContext(1429, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1509, 39, false);
#line 54 "C:\Users\Rafael.Rios\Desktop\Icones\TCC\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Bebida\Listar.cshtml"
                   Write(Html.DisplayFor(modelItem => item.tipo));

#line default
#line hidden
                EndContext();
                BeginContext(1548, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1628, 39, false);
#line 57 "C:\Users\Rafael.Rios\Desktop\Icones\TCC\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Bebida\Listar.cshtml"
                   Write(Html.DisplayFor(modelItem => item.nome));

#line default
#line hidden
                EndContext();
                BeginContext(1667, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1747, 41, false);
#line 60 "C:\Users\Rafael.Rios\Desktop\Icones\TCC\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Bebida\Listar.cshtml"
                   Write(Html.DisplayFor(modelItem => item.imagem));

#line default
#line hidden
                EndContext();
                BeginContext(1788, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1868, 40, false);
#line 63 "C:\Users\Rafael.Rios\Desktop\Icones\TCC\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Bebida\Listar.cshtml"
                   Write(Html.DisplayFor(modelItem => item.valor));

#line default
#line hidden
                EndContext();
                BeginContext(1908, 83, true);
                WriteLiteral("\r\n                    </td>\r\n                    <!--<td>\r\n                        ");
                EndContext();
                BeginContext(1992, 61, false);
#line 66 "C:\Users\Rafael.Rios\Desktop\Icones\TCC\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Bebida\Listar.cshtml"
                   Write(Html.ActionLink("Edit", "Editar", new { id = item.idBebida }));

#line default
#line hidden
                EndContext();
                BeginContext(2053, 28, true);
                WriteLiteral(" |\r\n                        ");
                EndContext();
                BeginContext(2082, 66, false);
#line 67 "C:\Users\Rafael.Rios\Desktop\Icones\TCC\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Bebida\Listar.cshtml"
                   Write(Html.ActionLink("Details", "Detalhar", new { id = item.idBebida }));

#line default
#line hidden
                EndContext();
                BeginContext(2148, 28, true);
                WriteLiteral(" |\r\n                        ");
                EndContext();
                BeginContext(2177, 64, false);
#line 68 "C:\Users\Rafael.Rios\Desktop\Icones\TCC\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Bebida\Listar.cshtml"
                   Write(Html.ActionLink("Delete", "Deletar", new { id = item.idBebida }));

#line default
#line hidden
                EndContext();
                BeginContext(2241, 130, true);
                WriteLiteral("\r\n                    </td>-->\r\n                    <td>\r\n                        <button title=\"Detalhar\" class=\"btn btn-primary\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 2371, "\"", 2456, 3);
                WriteAttributeValue("", 2381, "location.href=\'", 2381, 15, true);
#line 71 "C:\Users\Rafael.Rios\Desktop\Icones\TCC\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Bebida\Listar.cshtml"
WriteAttributeValue("", 2396, Url.Action("Detalhar","Bebida",new { id = item.idBebida }), 2396, 59, false);

#line default
#line hidden
                WriteAttributeValue("", 2455, "\'", 2455, 1, true);
                EndWriteAttribute();
                BeginContext(2457, 123, true);
                WriteLiteral("><i class=\"glyphicon glyphicon-search\"></i></button>\r\n                        <button title=\"Editar\"class=\"btn btn-default\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 2580, "\"", 2663, 3);
                WriteAttributeValue("", 2590, "location.href=\'", 2590, 15, true);
#line 72 "C:\Users\Rafael.Rios\Desktop\Icones\TCC\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Bebida\Listar.cshtml"
WriteAttributeValue("", 2605, Url.Action("Editar","Bebida",new { id = item.idBebida }), 2605, 57, false);

#line default
#line hidden
                WriteAttributeValue("", 2662, "\'", 2662, 1, true);
                EndWriteAttribute();
                BeginContext(2664, 123, true);
                WriteLiteral("><i class=\"glyphicon glyphicon-pencil\"></i></button>\r\n                        <button title=\"Deletar\"class=\"btn btn-danger\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 2787, "\"", 2871, 3);
                WriteAttributeValue("", 2797, "location.href=\'", 2797, 15, true);
#line 73 "C:\Users\Rafael.Rios\Desktop\Icones\TCC\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Bebida\Listar.cshtml"
WriteAttributeValue("", 2812, Url.Action("Deletar","Bebida",new { id = item.idBebida }), 2812, 58, false);

#line default
#line hidden
                WriteAttributeValue("", 2870, "\'", 2870, 1, true);
                EndWriteAttribute();
                BeginContext(2872, 104, true);
                WriteLiteral("><i class=\"glyphicon glyphicon-remove\"></i></button>\r\n                    </td>\r\n                </tr>\r\n");
                EndContext();
#line 76 "C:\Users\Rafael.Rios\Desktop\Icones\TCC\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Bebida\Listar.cshtml"
            }

#line default
#line hidden
                BeginContext(2991, 32, true);
                WriteLiteral("        </tbody>\r\n    </table>\r\n");
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
            BeginContext(3030, 11, true);
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
