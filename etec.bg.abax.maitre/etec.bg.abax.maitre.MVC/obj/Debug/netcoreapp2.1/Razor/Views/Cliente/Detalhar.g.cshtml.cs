#pragma checksum "C:\Users\gialm\Documents\Nova pasta\Nova pasta\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Cliente\Detalhar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1a447515ac403f70c788f41b0f54c86bf1f9bad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Detalhar), @"mvc.1.0.view", @"/Views/Cliente/Detalhar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cliente/Detalhar.cshtml", typeof(AspNetCore.Views_Cliente_Detalhar))]
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
#line 1 "C:\Users\gialm\Documents\Nova pasta\Nova pasta\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\_ViewImports.cshtml"
using etec.bg.abax.maitre.MVC;

#line default
#line hidden
#line 2 "C:\Users\gialm\Documents\Nova pasta\Nova pasta\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\_ViewImports.cshtml"
using etec.bg.abax.maitre.MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1a447515ac403f70c788f41b0f54c86bf1f9bad", @"/Views/Cliente/Detalhar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32119c404acac2b8de83c3ea23611565b264ee74", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_Detalhar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<etec.bg.abax.maitre.MVC.Models.Pessoa.Cliente>
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
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\gialm\Documents\Nova pasta\Nova pasta\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Cliente\Detalhar.cshtml"
  
    ViewData["Title"] = "Detalhar";

#line default
#line hidden
            BeginContext(100, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(129, 103, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8eafecaf32e4f3f91b7e871fb0c57fe", async() => {
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
            BeginContext(234, 1482, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b87078ec0acd43a09aaf6b70414c893c", async() => {
                BeginContext(240, 136, true);
                WriteLiteral("\r\n\r\n    <div>\r\n        <h4>Detalhes cliente</h4>\r\n        <hr />\r\n        <dl class=\"dl-horizontal\">\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(377, 45, false);
#line 21 "C:\Users\gialm\Documents\Nova pasta\Nova pasta\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Cliente\Detalhar.cshtml"
           Write(Html.DisplayNameFor(model => model.idCliente));

#line default
#line hidden
                EndContext();
                BeginContext(422, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(478, 41, false);
#line 24 "C:\Users\gialm\Documents\Nova pasta\Nova pasta\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Cliente\Detalhar.cshtml"
           Write(Html.DisplayFor(model => model.idCliente));

#line default
#line hidden
                EndContext();
                BeginContext(519, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(575, 39, false);
#line 27 "C:\Users\gialm\Documents\Nova pasta\Nova pasta\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Cliente\Detalhar.cshtml"
           Write(Html.DisplayNameFor(model => model.cpf));

#line default
#line hidden
                EndContext();
                BeginContext(614, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(670, 35, false);
#line 30 "C:\Users\gialm\Documents\Nova pasta\Nova pasta\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Cliente\Detalhar.cshtml"
           Write(Html.DisplayFor(model => model.cpf));

#line default
#line hidden
                EndContext();
                BeginContext(705, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(761, 40, false);
#line 33 "C:\Users\gialm\Documents\Nova pasta\Nova pasta\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Cliente\Detalhar.cshtml"
           Write(Html.DisplayNameFor(model => model.nome));

#line default
#line hidden
                EndContext();
                BeginContext(801, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(857, 36, false);
#line 36 "C:\Users\gialm\Documents\Nova pasta\Nova pasta\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Cliente\Detalhar.cshtml"
           Write(Html.DisplayFor(model => model.nome));

#line default
#line hidden
                EndContext();
                BeginContext(893, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(949, 40, false);
#line 39 "C:\Users\gialm\Documents\Nova pasta\Nova pasta\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Cliente\Detalhar.cshtml"
           Write(Html.DisplayNameFor(model => model.fone));

#line default
#line hidden
                EndContext();
                BeginContext(989, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(1045, 36, false);
#line 42 "C:\Users\gialm\Documents\Nova pasta\Nova pasta\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Cliente\Detalhar.cshtml"
           Write(Html.DisplayFor(model => model.fone));

#line default
#line hidden
                EndContext();
                BeginContext(1081, 55, true);
                WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(1137, 41, false);
#line 45 "C:\Users\gialm\Documents\Nova pasta\Nova pasta\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Cliente\Detalhar.cshtml"
           Write(Html.DisplayNameFor(model => model.eMail));

#line default
#line hidden
                EndContext();
                BeginContext(1178, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(1234, 37, false);
#line 48 "C:\Users\gialm\Documents\Nova pasta\Nova pasta\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Cliente\Detalhar.cshtml"
           Write(Html.DisplayFor(model => model.eMail));

#line default
#line hidden
                EndContext();
                BeginContext(1271, 113, true);
                WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n    </div>\r\n    <div>\r\n        <button class=\"btn btn-default\" title=\"Voltar\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 1384, "\"", 1441, 3);
                WriteAttributeValue("", 1394, "location.href=\'", 1394, 15, true);
#line 53 "C:\Users\gialm\Documents\Nova pasta\Nova pasta\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Cliente\Detalhar.cshtml"
WriteAttributeValue("", 1409, Url.Action("Listar","Cliente"), 1409, 31, false);

#line default
#line hidden
                WriteAttributeValue("", 1440, "\'", 1440, 1, true);
                EndWriteAttribute();
                BeginContext(1442, 114, true);
                WriteLiteral("><i class=\"glyphicon glyphicon-chevron-left\"></i></button>\r\n        <button class=\"btn btn-default\" title=\"Editar\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 1556, "\"", 1642, 3);
                WriteAttributeValue("", 1566, "location.href=\'", 1566, 15, true);
#line 54 "C:\Users\gialm\Documents\Nova pasta\Nova pasta\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Cliente\Detalhar.cshtml"
WriteAttributeValue("", 1581, Url.Action("Editar","Cliente",new { id = Model.idCliente }), 1581, 60, false);

#line default
#line hidden
                WriteAttributeValue("", 1641, "\'", 1641, 1, true);
                EndWriteAttribute();
                BeginContext(1643, 66, true);
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
            BeginContext(1716, 11, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<etec.bg.abax.maitre.MVC.Models.Pessoa.Cliente> Html { get; private set; }
    }
}
#pragma warning restore 1591
