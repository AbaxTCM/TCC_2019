#pragma checksum "C:\Users\Rafael.Rios\Videos\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Bebida\Detalhar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "131ba83939699a2a818d8e29dc6e0623feda3c44"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bebida_Detalhar), @"mvc.1.0.view", @"/Views/Bebida/Detalhar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Bebida/Detalhar.cshtml", typeof(AspNetCore.Views_Bebida_Detalhar))]
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
#line 1 "C:\Users\Rafael.Rios\Videos\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\_ViewImports.cshtml"
using etec.bg.abax.maitre.MVC;

#line default
#line hidden
#line 2 "C:\Users\Rafael.Rios\Videos\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\_ViewImports.cshtml"
using etec.bg.abax.maitre.MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"131ba83939699a2a818d8e29dc6e0623feda3c44", @"/Views/Bebida/Detalhar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32119c404acac2b8de83c3ea23611565b264ee74", @"/Views/_ViewImports.cshtml")]
    public class Views_Bebida_Detalhar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<etec.bg.abax.maitre.MVC.Models.Cardapio.Bebida>
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
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Rafael.Rios\Videos\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Bebida\Detalhar.cshtml"
  
    ViewData["Title"] = "Detalhar";

#line default
#line hidden
            BeginContext(101, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(130, 103, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd4d316159b64506b630a566317ff40b", async() => {
                BeginContext(136, 90, true);
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
            BeginContext(233, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(235, 1660, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b8acf74e4ac4242aa6ada2a32688ebf", async() => {
                BeginContext(241, 153, true);
                WriteLiteral("\r\n\r\n    <div>\r\n        <h4>Detalhes da bebida</h4>\r\n        <br/>\r\n        <hr />\r\n        <dl class=\"dl-horizontal\">\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(395, 44, false);
#line 22 "C:\Users\Rafael.Rios\Videos\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Bebida\Detalhar.cshtml"
           Write(Html.DisplayNameFor(model => model.idBebida));

#line default
#line hidden
                EndContext();
                BeginContext(439, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(495, 40, false);
#line 25 "C:\Users\Rafael.Rios\Videos\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Bebida\Detalhar.cshtml"
           Write(Html.DisplayFor(model => model.idBebida));

#line default
#line hidden
                EndContext();
                BeginContext(535, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(591, 40, false);
#line 28 "C:\Users\Rafael.Rios\Videos\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Bebida\Detalhar.cshtml"
           Write(Html.DisplayNameFor(model => model.tipo));

#line default
#line hidden
                EndContext();
                BeginContext(631, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(687, 36, false);
#line 31 "C:\Users\Rafael.Rios\Videos\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Bebida\Detalhar.cshtml"
           Write(Html.DisplayFor(model => model.tipo));

#line default
#line hidden
                EndContext();
                BeginContext(723, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(779, 40, false);
#line 34 "C:\Users\Rafael.Rios\Videos\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Bebida\Detalhar.cshtml"
           Write(Html.DisplayNameFor(model => model.nome));

#line default
#line hidden
                EndContext();
                BeginContext(819, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(875, 36, false);
#line 37 "C:\Users\Rafael.Rios\Videos\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Bebida\Detalhar.cshtml"
           Write(Html.DisplayFor(model => model.nome));

#line default
#line hidden
                EndContext();
                BeginContext(911, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(967, 42, false);
#line 40 "C:\Users\Rafael.Rios\Videos\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Bebida\Detalhar.cshtml"
           Write(Html.DisplayNameFor(model => model.imagem));

#line default
#line hidden
                EndContext();
                BeginContext(1009, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(1065, 38, false);
#line 43 "C:\Users\Rafael.Rios\Videos\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Bebida\Detalhar.cshtml"
           Write(Html.DisplayFor(model => model.imagem));

#line default
#line hidden
                EndContext();
                BeginContext(1103, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(1159, 41, false);
#line 46 "C:\Users\Rafael.Rios\Videos\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Bebida\Detalhar.cshtml"
           Write(Html.DisplayNameFor(model => model.valor));

#line default
#line hidden
                EndContext();
                BeginContext(1200, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(1256, 37, false);
#line 49 "C:\Users\Rafael.Rios\Videos\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Bebida\Detalhar.cshtml"
           Write(Html.DisplayFor(model => model.valor));

#line default
#line hidden
                EndContext();
                BeginContext(1293, 77, true);
                WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n    </div>\r\n    <!--\r\n    <div>\r\n        ");
                EndContext();
                BeginContext(1371, 62, false);
#line 55 "C:\Users\Rafael.Rios\Videos\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Bebida\Detalhar.cshtml"
   Write(Html.ActionLink("Edit", "Editar", new { id = Model.idBebida }));

#line default
#line hidden
                EndContext();
                BeginContext(1433, 133, true);
                WriteLiteral(" |\r\n        <a asp-action=\"Listar\">Back to List</a>\r\n    </div>-->\r\n    <div>\r\n        <button class=\"btn btn-default\" title=\"Voltar\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 1566, "\"", 1622, 3);
                WriteAttributeValue("", 1576, "location.href=\'", 1576, 15, true);
#line 59 "C:\Users\Rafael.Rios\Videos\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Bebida\Detalhar.cshtml"
WriteAttributeValue("", 1591, Url.Action("Listar","Bebida"), 1591, 30, false);

#line default
#line hidden
                WriteAttributeValue("", 1621, "\'", 1621, 1, true);
                EndWriteAttribute();
                BeginContext(1623, 114, true);
                WriteLiteral("><i class=\"glyphicon glyphicon-chevron-left\"></i></button>\r\n        <button class=\"btn btn-default\" title=\"Editar\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 1737, "\"", 1821, 3);
                WriteAttributeValue("", 1747, "location.href=\'", 1747, 15, true);
#line 60 "C:\Users\Rafael.Rios\Videos\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Bebida\Detalhar.cshtml"
WriteAttributeValue("", 1762, Url.Action("Editar","Bebida",new { id = Model.idBebida }), 1762, 58, false);

#line default
#line hidden
                WriteAttributeValue("", 1820, "\'", 1820, 1, true);
                EndWriteAttribute();
                BeginContext(1822, 66, true);
                WriteLiteral("><i class=\"glyphicon glyphicon-pencil\"></i></button>\r\n    </div>\r\n");
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
            BeginContext(1895, 11, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<etec.bg.abax.maitre.MVC.Models.Cardapio.Bebida> Html { get; private set; }
    }
}
#pragma warning restore 1591
