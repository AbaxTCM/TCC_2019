#pragma checksum "C:\Users\Rafael.Rios\Desktop\TCC\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Reserva\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01afa29b78999a4b6015fd5c58b04258f1aceaac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reserva_Listar), @"mvc.1.0.view", @"/Views/Reserva/Listar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Reserva/Listar.cshtml", typeof(AspNetCore.Views_Reserva_Listar))]
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
#line 1 "C:\Users\Rafael.Rios\Desktop\TCC\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\_ViewImports.cshtml"
using etec.bg.abax.maitre.MVC;

#line default
#line hidden
#line 2 "C:\Users\Rafael.Rios\Desktop\TCC\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\_ViewImports.cshtml"
using etec.bg.abax.maitre.MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01afa29b78999a4b6015fd5c58b04258f1aceaac", @"/Views/Reserva/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32119c404acac2b8de83c3ea23611565b264ee74", @"/Views/_ViewImports.cshtml")]
    public class Views_Reserva_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<etec.bg.abax.maitre.MVC.Models.Reserva.Reserva>>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(68, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Rafael.Rios\Desktop\TCC\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Reserva\Listar.cshtml"
  
    ViewData["Title"] = "Listar";

#line default
#line hidden
            BeginContext(112, 30, true);
            WriteLiteral("\r\n<h2>Listar</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(142, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "358aa0d7be8e48edaf6b3b68e99529f6", async() => {
                BeginContext(165, 10, true);
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
            BeginContext(179, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(272, 45, false);
#line 16 "C:\Users\Rafael.Rios\Desktop\TCC\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Reserva\Listar.cshtml"
           Write(Html.DisplayNameFor(model => model.idReserva));

#line default
#line hidden
            EndContext();
            BeginContext(317, 57, true);
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(375, 47, false);
#line 20 "C:\Users\Rafael.Rios\Desktop\TCC\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Reserva\Listar.cshtml"
           Write(Html.DisplayNameFor(model => model.mesa.numero));

#line default
#line hidden
            EndContext();
            BeginContext(422, 57, true);
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(480, 51, false);
#line 24 "C:\Users\Rafael.Rios\Desktop\TCC\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Reserva\Listar.cshtml"
           Write(Html.DisplayNameFor(model => model.finalidade.nome));

#line default
#line hidden
            EndContext();
            BeginContext(531, 57, true);
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(589, 51, false);
#line 28 "C:\Users\Rafael.Rios\Desktop\TCC\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Reserva\Listar.cshtml"
           Write(Html.DisplayNameFor(model => model.agenda.dataHora));

#line default
#line hidden
            EndContext();
            BeginContext(640, 57, true);
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(698, 47, false);
#line 32 "C:\Users\Rafael.Rios\Desktop\TCC\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Reserva\Listar.cshtml"
           Write(Html.DisplayNameFor(model => model.atendimento));

#line default
#line hidden
            EndContext();
            BeginContext(745, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 38 "C:\Users\Rafael.Rios\Desktop\TCC\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Reserva\Listar.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(863, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(912, 44, false);
#line 41 "C:\Users\Rafael.Rios\Desktop\TCC\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Reserva\Listar.cshtml"
           Write(Html.DisplayFor(modelItem => item.idReserva));

#line default
#line hidden
            EndContext();
            BeginContext(956, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1012, 46, false);
#line 44 "C:\Users\Rafael.Rios\Desktop\TCC\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Reserva\Listar.cshtml"
           Write(Html.DisplayFor(modelItem => item.atendimento));

#line default
#line hidden
            EndContext();
            BeginContext(1058, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1114, 65, false);
#line 47 "C:\Users\Rafael.Rios\Desktop\TCC\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Reserva\Listar.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1179, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1200, 71, false);
#line 48 "C:\Users\Rafael.Rios\Desktop\TCC\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Reserva\Listar.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1271, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1292, 69, false);
#line 49 "C:\Users\Rafael.Rios\Desktop\TCC\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Reserva\Listar.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1361, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 52 "C:\Users\Rafael.Rios\Desktop\TCC\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\Reserva\Listar.cshtml"
}

#line default
#line hidden
            BeginContext(1400, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<etec.bg.abax.maitre.MVC.Models.Reserva.Reserva>> Html { get; private set; }
    }
}
#pragma warning restore 1591
