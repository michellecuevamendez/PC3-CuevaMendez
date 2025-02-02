#pragma checksum "D:\app\Views\Home\Busco.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1aaa47c07b42d208124cac859daff932d83d660d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Busco), @"mvc.1.0.view", @"/Views/Home/Busco.cshtml")]
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
#line 1 "D:\app\Views\_ViewImports.cshtml"
using app;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\app\Views\_ViewImports.cshtml"
using app.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1aaa47c07b42d208124cac859daff932d83d660d", @"/Views/Home/Busco.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35d7228549089a448a9c85c9fd74602bc83b83a3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Busco : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Producto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/Eliminar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color: #B9B9B9;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\app\Views\Home\Busco.cshtml"
  
    ViewData["Title"] = "Solicitudes de productos añadidas";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1aaa47c07b42d208124cac859daff932d83d660d4361", async() => {
                WriteLiteral("  \r\n<div class=\"text-center\" style=\"margin-top: 50px;\">\r\n    <h1 class=\"display-4\">Solicitudes registradas en los ultimos 7 dias</h1>\r\n</div>\r\n\r\n<div style=\"margin-top: 30px; text-align: center;\">\r\n");
#nullable restore
#line 11 "D:\app\Views\Home\Busco.cshtml"
     if (Model.Count == 0)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"p-3 mb-2 bg-danger text-white\">Aún no se han obtenido datos de registro de productos, le invitamos a registrar sus productos:)</div>\r\n");
#nullable restore
#line 14 "D:\app\Views\Home\Busco.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n\r\n<div style=\"margin-top: 30px;\">\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 19 "D:\app\Views\Home\Busco.cshtml"
         foreach (var producto in Model)
        { 

#line default
#line hidden
#nullable disable
                WriteLiteral("            <span class=\"border border-warning\">\r\n            <div class=\"col-lg-4\">\r\n                <div class=\"card\" style=\"width: 18rem; margin-bottom: 20px;\">\r\n                    <img");
                BeginWriteAttribute("src", " src=\"", 836, "\"", 864, 1);
#nullable restore
#line 24 "D:\app\Views\Home\Busco.cshtml"
WriteAttributeValue("", 842, producto.url_producto, 842, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"card-img-top\">\r\n                        <div class=\"card-body\" style=\"text-align: center; margin-top: 10px;\">\r\n                            <h5 class=\"card-title\">");
#nullable restore
#line 26 "D:\app\Views\Home\Busco.cshtml"
                                              Write(producto.nombre);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                        </div>\r\n                        <ul class=\"list-group list-group-flush\">\r\n                            <li class=\"list-group-item\"><strong>Descripción: </strong>");
#nullable restore
#line 29 "D:\app\Views\Home\Busco.cshtml"
                                                                                 Write(producto.descripcion);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                            <li class=\"list-group-item\"><strong>Precio: </strong>");
#nullable restore
#line 30 "D:\app\Views\Home\Busco.cshtml"
                                                                            Write(producto.precio);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                            <li class=\"list-group-item\"><strong>Celular: </strong>");
#nullable restore
#line 31 "D:\app\Views\Home\Busco.cshtml"
                                                                             Write(producto.celular);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                            <li class=\"list-group-item\"><strong>Lugar: </strong>");
#nullable restore
#line 32 "D:\app\Views\Home\Busco.cshtml"
                                                                           Write(producto.lugarcompraproducto);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                            <li class=\"list-group-item\"><strong>Usuario: </strong>");
#nullable restore
#line 33 "D:\app\Views\Home\Busco.cshtml"
                                                                             Write(producto.usuario);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                        </ul>\r\n                        <div class=\"card-body\" style=\"text-align: center;\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1aaa47c07b42d208124cac859daff932d83d660d8528", async() => {
                    WriteLiteral("\r\n                                <input type=\"hidden\" name=\"Id\"");
                    BeginWriteAttribute("value", " value=\"", 1946, "\"", 1966, 1);
#nullable restore
#line 37 "D:\app\Views\Home\Busco.cshtml"
WriteAttributeValue("", 1954, producto.id, 1954, 12, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">\r\n                                <button class=\"btn btn-danger\">Eliminar</button>\r\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </div>\r\n                </div>\r\n            </div>\r\n            </span>\r\n");
#nullable restore
#line 44 "D:\app\Views\Home\Busco.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n</div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Producto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
