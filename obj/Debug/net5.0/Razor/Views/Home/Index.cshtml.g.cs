#pragma checksum "C:\Users\moise\OneDrive\Área de Trabalho\UsandoViews.v1\UsandoViews\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c3551828df41e7b30b12baca5a54ff724b63af8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(UsandoViews.Models.Home.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace UsandoViews.Models.Home
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c3551828df41e7b30b12baca5a54ff724b63af8", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55e5dcf798f67e806855b3cbcd0728dff488210b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\moise\OneDrive\Área de Trabalho\UsandoViews.v1\UsandoViews\Views\Home\Index.cshtml"
  
    ViewBag.Subtitulo = "Página Principal";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text-primary\">CRUD com ASP.NET Core</h1>\r\n<hr>\r\n<h3 class=\"text-info\">Usuários Cadastrados: ");
#nullable restore
#line 7 "C:\Users\moise\OneDrive\Área de Trabalho\UsandoViews.v1\UsandoViews\Views\Home\Index.cshtml"
                                       Write(ViewBag.QtdeUsuarios);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<hr>\r\n<a href=\"/Home/Usuarios\" class=\"btn btn-primary\">Usuarios</a>\r\n\r\n");
            DefineSection("Footer", async() => {
                WriteLiteral("\r\n    <span class=\"text-info\">Página principal</span>\r\n");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
