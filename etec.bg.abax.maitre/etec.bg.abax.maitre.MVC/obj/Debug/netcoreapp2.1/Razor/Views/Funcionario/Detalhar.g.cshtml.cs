#pragma checksum "C:\Users\Rafael.Rios\Videos\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Funcionario\Detalhar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb08da210c274e40d0c4705f4af4eb2d44266334"
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
#line 1 "C:\Users\Rafael.Rios\Videos\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\_ViewImports.cshtml"
using etec.bg.abax.maitre.MVC;

#line default
#line hidden
#line 2 "C:\Users\Rafael.Rios\Videos\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\_ViewImports.cshtml"
using etec.bg.abax.maitre.MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb08da210c274e40d0c4705f4af4eb2d44266334", @"/Views/Funcionario/Detalhar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32119c404acac2b8de83c3ea23611565b264ee74", @"/Views/_ViewImports.cshtml")]
    public class Views_Funcionario_Detalhar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<etec.bg.abax.maitre.MVC.Models.Pessoa.Funcionario>
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
            BeginContext(58, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Rafael.Rios\Videos\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Funcionario\Detalhar.cshtml"
  
    ViewData["Title"] = "Detalhar";

#line default
#line hidden
            BeginContext(104, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(133, 103, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9bbd66a72414ba5adcda52e00d46158", async() => {
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
            BeginContext(238, 1488, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e3d3ece78d645bcb0199a4a42069591", async() => {
                BeginContext(244, 107, true);
                WriteLiteral("\r\n\r\n<div>\r\n    <h4>Funcionario</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(352, 42, false);
#line 21 "C:\Users\Rafael.Rios\Videos\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Funcionario\Detalhar.cshtml"
       Write(Html.DisplayNameFor(model => model.idFunc));

#line default
#line hidden
                EndContext();
                BeginContext(394, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(438, 38, false);
#line 24 "C:\Users\Rafael.Rios\Videos\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Funcionario\Detalhar.cshtml"
       Write(Html.DisplayFor(model => model.idFunc));

#line default
#line hidden
                EndContext();
                BeginContext(476, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(520, 41, false);
#line 27 "C:\Users\Rafael.Rios\Videos\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Funcionario\Detalhar.cshtml"
       Write(Html.DisplayNameFor(model => model.cargo));

#line default
#line hidden
                EndContext();
                BeginContext(561, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(605, 37, false);
#line 30 "C:\Users\Rafael.Rios\Videos\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Funcionario\Detalhar.cshtml"
       Write(Html.DisplayFor(model => model.cargo));

#line default
#line hidden
                EndContext();
                BeginContext(642, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(686, 40, false);
#line 33 "C:\Users\Rafael.Rios\Videos\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Funcionario\Detalhar.cshtml"
       Write(Html.DisplayNameFor(model => model.nome));

#line default
#line hidden
                EndContext();
                BeginContext(726, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(770, 36, false);
#line 36 "C:\Users\Rafael.Rios\Videos\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Funcionario\Detalhar.cshtml"
       Write(Html.DisplayFor(model => model.nome));

#line default
#line hidden
                EndContext();
                BeginContext(806, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(850, 40, false);
#line 39 "C:\Users\Rafael.Rios\Videos\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Funcionario\Detalhar.cshtml"
       Write(Html.DisplayNameFor(model => model.fone));

#line default
#line hidden
                EndContext();
                BeginContext(890, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(934, 36, false);
#line 42 "C:\Users\Rafael.Rios\Videos\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Funcionario\Detalhar.cshtml"
       Write(Html.DisplayFor(model => model.fone));

#line default
#line hidden
                EndContext();
                BeginContext(970, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(1014, 41, false);
#line 45 "C:\Users\Rafael.Rios\Videos\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Funcionario\Detalhar.cshtml"
       Write(Html.DisplayNameFor(model => model.eMail));

#line default
#line hidden
                EndContext();
                BeginContext(1055, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(1099, 37, false);
#line 48 "C:\Users\Rafael.Rios\Videos\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Funcionario\Detalhar.cshtml"
       Write(Html.DisplayFor(model => model.eMail));

#line default
#line hidden
                EndContext();
                BeginContext(1136, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(1180, 42, false);
#line 51 "C:\Users\Rafael.Rios\Videos\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Funcionario\Detalhar.cshtml"
       Write(Html.DisplayNameFor(model => model.funcao));

#line default
#line hidden
                EndContext();
                BeginContext(1222, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(1266, 38, false);
#line 54 "C:\Users\Rafael.Rios\Videos\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Funcionario\Detalhar.cshtml"
       Write(Html.DisplayFor(model => model.funcao));

#line default
#line hidden
                EndContext();
                BeginContext(1304, 93, true);
                WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <button class=\"btn btn-default\" title=\"Voltar\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 1397, "\"", 1458, 3);
                WriteAttributeValue("", 1407, "location.href=\'", 1407, 15, true);
#line 59 "C:\Users\Rafael.Rios\Videos\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Funcionario\Detalhar.cshtml"
WriteAttributeValue("", 1422, Url.Action("Listar","Funcionario"), 1422, 35, false);

#line default
#line hidden
                WriteAttributeValue("", 1457, "\'", 1457, 1, true);
                EndWriteAttribute();
                BeginContext(1459, 110, true);
                WriteLiteral("><i class=\"glyphicon glyphicon-chevron-left\"></i></button>\r\n    <button class=\"btn btn-default\" title=\"Editar\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 1569, "\"", 1656, 3);
                WriteAttributeValue("", 1579, "location.href=\'", 1579, 15, true);
#line 60 "C:\Users\Rafael.Rios\Videos\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Funcionario\Detalhar.cshtml"
WriteAttributeValue("", 1594, Url.Action("Editar","Funcionario",new { id = Model.idFunc }), 1594, 61, false);

#line default
#line hidden
                WriteAttributeValue("", 1655, "\'", 1655, 1, true);
                EndWriteAttribute();
                BeginContext(1657, 62, true);
                WriteLiteral("><i class=\"glyphicon glyphicon-pencil\"></i></button>\r\n</div>\r\n");
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
            BeginContext(1726, 11, true);
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
