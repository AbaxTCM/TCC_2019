#pragma checksum "C:\Users\Rafael.Rios\Videos\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\ReservaRest\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f258e917e2021f20a39ee1c5c959c72a157a083"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ReservaRest_Listar), @"mvc.1.0.view", @"/Views/ReservaRest/Listar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ReservaRest/Listar.cshtml", typeof(AspNetCore.Views_ReservaRest_Listar))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f258e917e2021f20a39ee1c5c959c72a157a083", @"/Views/ReservaRest/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32119c404acac2b8de83c3ea23611565b264ee74", @"/Views/_ViewImports.cshtml")]
    public class Views_ReservaRest_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<etec.bg.abax.maitre.MVC.Models.Reserva.Reserva>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(68, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Rafael.Rios\Videos\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\ReservaRest\Listar.cshtml"
  
    ViewData["Title"] = "Listar";

#line default
#line hidden
            BeginContext(112, 168, true);
            WriteLiteral("\r\n<h2>Reservas</h2>\r\n\r\n<p>\r\n    <!--<a asp-action=\"Create\">Create New</a>-->\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(281, 45, false);
#line 16 "C:\Users\Rafael.Rios\Videos\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\ReservaRest\Listar.cshtml"
           Write(Html.DisplayNameFor(model => model.idReserva));

#line default
#line hidden
            EndContext();
            BeginContext(326, 57, true);
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(384, 47, false);
#line 20 "C:\Users\Rafael.Rios\Videos\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\ReservaRest\Listar.cshtml"
           Write(Html.DisplayNameFor(model => model.nomeCliente));

#line default
#line hidden
            EndContext();
            BeginContext(431, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(487, 40, false);
#line 23 "C:\Users\Rafael.Rios\Videos\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\ReservaRest\Listar.cshtml"
           Write(Html.DisplayNameFor(model => model.mesa));

#line default
#line hidden
            EndContext();
            BeginContext(527, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(583, 46, false);
#line 26 "C:\Users\Rafael.Rios\Videos\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\ReservaRest\Listar.cshtml"
           Write(Html.DisplayNameFor(model => model.finalidade));

#line default
#line hidden
            EndContext();
            BeginContext(629, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(685, 42, false);
#line 29 "C:\Users\Rafael.Rios\Videos\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\ReservaRest\Listar.cshtml"
           Write(Html.DisplayNameFor(model => model.agenda));

#line default
#line hidden
            EndContext();
            BeginContext(727, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(783, 47, false);
#line 32 "C:\Users\Rafael.Rios\Videos\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\ReservaRest\Listar.cshtml"
           Write(Html.DisplayNameFor(model => model.atendimento));

#line default
#line hidden
            EndContext();
            BeginContext(830, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 38 "C:\Users\Rafael.Rios\Videos\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\ReservaRest\Listar.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(965, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1026, 44, false);
#line 42 "C:\Users\Rafael.Rios\Videos\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\ReservaRest\Listar.cshtml"
               Write(Html.DisplayFor(modelItem => item.idReserva));

#line default
#line hidden
            EndContext();
            BeginContext(1070, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1138, 46, false);
#line 45 "C:\Users\Rafael.Rios\Videos\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\ReservaRest\Listar.cshtml"
               Write(Html.DisplayFor(modelItem => item.nomeCliente));

#line default
#line hidden
            EndContext();
            BeginContext(1184, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1252, 39, false);
#line 48 "C:\Users\Rafael.Rios\Videos\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\ReservaRest\Listar.cshtml"
               Write(Html.DisplayFor(modelItem => item.mesa));

#line default
#line hidden
            EndContext();
            BeginContext(1291, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1359, 45, false);
#line 51 "C:\Users\Rafael.Rios\Videos\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\ReservaRest\Listar.cshtml"
               Write(Html.DisplayFor(modelItem => item.finalidade));

#line default
#line hidden
            EndContext();
            BeginContext(1404, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1472, 41, false);
#line 54 "C:\Users\Rafael.Rios\Videos\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\ReservaRest\Listar.cshtml"
               Write(Html.DisplayFor(modelItem => item.agenda));

#line default
#line hidden
            EndContext();
            BeginContext(1513, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1581, 46, false);
#line 57 "C:\Users\Rafael.Rios\Videos\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\ReservaRest\Listar.cshtml"
               Write(Html.DisplayFor(modelItem => item.atendimento));

#line default
#line hidden
            EndContext();
            BeginContext(1627, 89, true);
            WriteLiteral("\r\n                </td>\r\n                <!--\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1717, 65, false);
#line 61 "C:\Users\Rafael.Rios\Videos\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\ReservaRest\Listar.cshtml"
               Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1782, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(1807, 71, false);
#line 62 "C:\Users\Rafael.Rios\Videos\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\ReservaRest\Listar.cshtml"
               Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1878, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(1903, 69, false);
#line 63 "C:\Users\Rafael.Rios\Videos\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\ReservaRest\Listar.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1972, 118, true);
            WriteLiteral("\r\n                </td>-->\r\n                <td>\r\n                    <button title=\"Detalhar\" class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2090, "\"", 2153, 3);
            WriteAttributeValue("", 2100, "location.href=\'", 2100, 15, true);
#line 66 "C:\Users\Rafael.Rios\Videos\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\ReservaRest\Listar.cshtml"
WriteAttributeValue("", 2115, Url.Action("Detalhar","ReservaRest"), 2115, 37, false);

#line default
#line hidden
            WriteAttributeValue("", 2152, "\'", 2152, 1, true);
            EndWriteAttribute();
            BeginContext(2154, 98, true);
            WriteLiteral("><i class=\"glyphicon glyphicon-search\"></i></button>\r\n\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 70 "C:\Users\Rafael.Rios\Videos\TCC_2019\etec.bg.abax.maitre\etec.bg.abax.maitre.MVC\Views\ReservaRest\Listar.cshtml"
        }

#line default
#line hidden
            BeginContext(2263, 24, true);
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
