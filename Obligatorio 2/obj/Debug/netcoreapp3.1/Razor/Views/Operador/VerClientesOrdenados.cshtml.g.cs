#pragma checksum "C:\Users\usuario\Documents\ORT 2DO SEMESTRE\PROGRAMACION 2\OBLIGATORIO 2\Obligatorio 2 V15\Obligatorio 2\Views\Operador\VerClientesOrdenados.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67c21d49a82218ef46e15ace004de6bd775bbfe1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Operador_VerClientesOrdenados), @"mvc.1.0.view", @"/Views/Operador/VerClientesOrdenados.cshtml")]
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
#nullable restore
#line 1 "C:\Users\usuario\Documents\ORT 2DO SEMESTRE\PROGRAMACION 2\OBLIGATORIO 2\Obligatorio 2 V15\Obligatorio 2\Views\_ViewImports.cshtml"
using Obligatorio_2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\usuario\Documents\ORT 2DO SEMESTRE\PROGRAMACION 2\OBLIGATORIO 2\Obligatorio 2 V15\Obligatorio 2\Views\_ViewImports.cshtml"
using Obligatorio_2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67c21d49a82218ef46e15ace004de6bd775bbfe1", @"/Views/Operador/VerClientesOrdenados.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa1fa0cac6fa0da02617e49b258346fde14fcf01", @"/Views/_ViewImports.cshtml")]
    public class Views_Operador_VerClientesOrdenados : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Obligatorio_P2.Cliente>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\usuario\Documents\ORT 2DO SEMESTRE\PROGRAMACION 2\OBLIGATORIO 2\Obligatorio 2 V15\Obligatorio 2\Views\Operador\VerClientesOrdenados.cshtml"
  
    ViewData["Title"] = "View";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Ver Todos los Clientes Ordenados por Apellido</h1>


<table class=""table"">
    <thead>
        <tr>
            <th>
               Id Cliente
            </th>
            <th>
                Nombre
            </th>
            <th>
                Apellido
            </th>
            <th>
                Username
            </th>
            <th>
                Password
            </th>
            <th>
                Rol
            </th>

            <th>
                email
            </th>
            <th>
               Fecha de Nacimiento
            </th>
            
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 42 "C:\Users\usuario\Documents\ORT 2DO SEMESTRE\PROGRAMACION 2\OBLIGATORIO 2\Obligatorio 2 V15\Obligatorio 2\Views\Operador\VerClientesOrdenados.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 45 "C:\Users\usuario\Documents\ORT 2DO SEMESTRE\PROGRAMACION 2\OBLIGATORIO 2\Obligatorio 2 V15\Obligatorio 2\Views\Operador\VerClientesOrdenados.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdCliente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 48 "C:\Users\usuario\Documents\ORT 2DO SEMESTRE\PROGRAMACION 2\OBLIGATORIO 2\Obligatorio 2 V15\Obligatorio 2\Views\Operador\VerClientesOrdenados.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\Users\usuario\Documents\ORT 2DO SEMESTRE\PROGRAMACION 2\OBLIGATORIO 2\Obligatorio 2 V15\Obligatorio 2\Views\Operador\VerClientesOrdenados.cshtml"
           Write(Html.DisplayFor(modelItem => item.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
#nullable restore
#line 56 "C:\Users\usuario\Documents\ORT 2DO SEMESTRE\PROGRAMACION 2\OBLIGATORIO 2\Obligatorio 2 V15\Obligatorio 2\Views\Operador\VerClientesOrdenados.cshtml"
           Write(Html.DisplayFor(modelItem => item.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 59 "C:\Users\usuario\Documents\ORT 2DO SEMESTRE\PROGRAMACION 2\OBLIGATORIO 2\Obligatorio 2 V15\Obligatorio 2\Views\Operador\VerClientesOrdenados.cshtml"
           Write(Html.DisplayFor(modelItem => item.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 62 "C:\Users\usuario\Documents\ORT 2DO SEMESTRE\PROGRAMACION 2\OBLIGATORIO 2\Obligatorio 2 V15\Obligatorio 2\Views\Operador\VerClientesOrdenados.cshtml"
           Write(Html.DisplayFor(modelItem => item.Rol));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
#nullable restore
#line 66 "C:\Users\usuario\Documents\ORT 2DO SEMESTRE\PROGRAMACION 2\OBLIGATORIO 2\Obligatorio 2 V15\Obligatorio 2\Views\Operador\VerClientesOrdenados.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 69 "C:\Users\usuario\Documents\ORT 2DO SEMESTRE\PROGRAMACION 2\OBLIGATORIO 2\Obligatorio 2 V15\Obligatorio 2\Views\Operador\VerClientesOrdenados.cshtml"
           Write(Html.DisplayFor(modelItem => item.FechaNacimiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            \r\n        </tr>\r\n");
#nullable restore
#line 73 "C:\Users\usuario\Documents\ORT 2DO SEMESTRE\PROGRAMACION 2\OBLIGATORIO 2\Obligatorio 2 V15\Obligatorio 2\Views\Operador\VerClientesOrdenados.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Obligatorio_P2.Cliente>> Html { get; private set; }
    }
}
#pragma warning restore 1591
