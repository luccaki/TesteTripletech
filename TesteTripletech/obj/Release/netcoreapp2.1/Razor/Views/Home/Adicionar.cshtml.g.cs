#pragma checksum "C:\Users\lucca\Desktop\TesteTripletech\TesteTripletech\Views\Home\Adicionar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7cc0a0902298798ecf525a4383d8389a958479c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Adicionar), @"mvc.1.0.view", @"/Views/Home/Adicionar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Adicionar.cshtml", typeof(AspNetCore.Views_Home_Adicionar))]
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
#line 1 "C:\Users\lucca\Desktop\TesteTripletech\TesteTripletech\Views\_ViewImports.cshtml"
using TesteTripletech;

#line default
#line hidden
#line 2 "C:\Users\lucca\Desktop\TesteTripletech\TesteTripletech\Views\_ViewImports.cshtml"
using TesteTripletech.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cc0a0902298798ecf525a4383d8389a958479c7", @"/Views/Home/Adicionar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7090e28d4ecfa407331c5ef79c5d280fc3a2160", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Adicionar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\lucca\Desktop\TesteTripletech\TesteTripletech\Views\Home\Adicionar.cshtml"
  
    ViewData["Title"] = "Adicionar";
    var texto = ViewData["Menssagem"];

#line default
#line hidden
            BeginContext(85, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(92, 5, false);
#line 6 "C:\Users\lucca\Desktop\TesteTripletech\TesteTripletech\Views\Home\Adicionar.cshtml"
Write(texto);

#line default
#line hidden
            EndContext();
            BeginContext(97, 13, true);
            WriteLiteral("</h1>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
