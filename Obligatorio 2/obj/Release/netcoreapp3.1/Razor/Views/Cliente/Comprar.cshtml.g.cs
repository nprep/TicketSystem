#pragma checksum "C:\Users\Nahuel\Desktop\Obligatorio 2 V15\Obligatorio 2\Views\Cliente\Comprar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0807815afffa9363e3b6936f13fb54f801a1b6e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Comprar), @"mvc.1.0.view", @"/Views/Cliente/Comprar.cshtml")]
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
#line 1 "C:\Users\Nahuel\Desktop\Obligatorio 2 V15\Obligatorio 2\Views\_ViewImports.cshtml"
using Obligatorio_2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nahuel\Desktop\Obligatorio 2 V15\Obligatorio 2\Views\_ViewImports.cshtml"
using Obligatorio_2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0807815afffa9363e3b6936f13fb54f801a1b6e", @"/Views/Cliente/Comprar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa1fa0cac6fa0da02617e49b258346fde14fcf01", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_Comprar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("cantidadEntradas"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Comprar</h1>\r\n\r\n<h3>Datos de la compra</h3>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f0807815afffa9363e3b6936f13fb54f801a1b6e3951", async() => {
                WriteLiteral("\r\n\r\n    <label>ID</label><br>\r\n    <input type=\"text\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 156, "\"", 194, 1);
#nullable restore
#line 8 "C:\Users\Nahuel\Desktop\Obligatorio 2 V15\Obligatorio 2\Views\Cliente\Comprar.cshtml"
WriteAttributeValue("", 164, ViewBag.Actividad.IdActividad, 164, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly><br>\r\n\r\n    <label>Título</label><br>\r\n    <input type=\"text\" name=\"nombre\"");
                BeginWriteAttribute("value", " value=\"", 280, "\"", 313, 1);
#nullable restore
#line 11 "C:\Users\Nahuel\Desktop\Obligatorio 2 V15\Obligatorio 2\Views\Cliente\Comprar.cshtml"
WriteAttributeValue("", 288, ViewBag.Actividad.Nombre, 288, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly><br>\r\n\r\n    <label>Cantidad de Entradas</label><br>\r\n    <input type=\"number\" id=\"cantidadEntradas\" name=\"cant\" value=\"Cantidad Entradas\"><br>\r\n\r\n    <label>Costo de cada entrada</label><br>\r\n    <input type=\"text\" name=\"costo\"");
                BeginWriteAttribute("value", " value=\"", 551, "\"", 609, 2);
                WriteAttributeValue("", 559, "$", 559, 1, true);
#nullable restore
#line 17 "C:\Users\Nahuel\Desktop\Obligatorio 2 V15\Obligatorio 2\Views\Cliente\Comprar.cshtml"
WriteAttributeValue("", 560, ViewBag.Actividad.CalcularCosto().ToString("N2"), 560, 49, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly><br>\r\n\r\n    <input type=\"submit\" value=\"Comprar\">\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 23 "C:\Users\Nahuel\Desktop\Obligatorio 2 V15\Obligatorio 2\Views\Cliente\Comprar.cshtml"
Write(ViewBag.Resultado);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(" \r\n    <script>\r\n        document.querySelector(\"#cantidadEntradas\").addEventListener(\"change\", devolverPrecioTotal);\r\n\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
