#pragma checksum "C:\Users\Lenovo\source\repos\MVCapp\MVCapp\Views\Home\Option.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36f862464618a5ba364cbcbbc7022d0ed631eed3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Option), @"mvc.1.0.view", @"/Views/Home/Option.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Option.cshtml", typeof(AspNetCore.Views_Home_Option))]
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
#line 1 "C:\Users\Lenovo\source\repos\MVCapp\MVCapp\Views\_ViewImports.cshtml"
using MVCapp;

#line default
#line hidden
#line 2 "C:\Users\Lenovo\source\repos\MVCapp\MVCapp\Views\_ViewImports.cshtml"
using MVCapp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36f862464618a5ba364cbcbbc7022d0ed631eed3", @"/Views/Home/Option.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ebc124ce2b6d6335131dfbc906dc321149a24d1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Option : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 453, true);
            WriteLiteral(@"

<div style=""color:grey;margin:0 700px;"">
  <h1> Select color theme </h1>
  <br><br>
  <a class=""btn"" style=""background:grey;color:white;margin-left:20px;"" href=""/Home/ChangeTheme?theme=light"">Light</a>
  <a class=""btn"" style=""background:black;color:white;margin-left:20px;"" href=""/Home/ChangeTheme?theme=dark"">Dark</a>
  <a class=""btn"" style=""background:green;color:black;margin-left:20px;"" href=""/Home/ChangeTheme?theme=colorful"">Colorful</a>
</div>
");
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
