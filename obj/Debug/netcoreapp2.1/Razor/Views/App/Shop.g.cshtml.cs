#pragma checksum "/Users/sgryt/Sites/C#/DutchTreat/Views/App/Shop.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33d45b41c2fc1f1585b2a4316555a9d08a3d447c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_App_Shop), @"mvc.1.0.view", @"/Views/App/Shop.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/App/Shop.cshtml", typeof(AspNetCore.Views_App_Shop))]
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
#line 1 "/Users/sgryt/Sites/C#/DutchTreat/Views/_ViewImports.cshtml"
using DutchTreat.Controllers;

#line default
#line hidden
#line 2 "/Users/sgryt/Sites/C#/DutchTreat/Views/_ViewImports.cshtml"
using DutchTreat.ViewModels;

#line default
#line hidden
#line 3 "/Users/sgryt/Sites/C#/DutchTreat/Views/_ViewImports.cshtml"
using DutchTreat.Data.Entities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33d45b41c2fc1f1585b2a4316555a9d08a3d447c", @"/Views/App/Shop.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4a3ad7f18022ec7d179eeb291786d4302cfb376", @"/Views/_ViewImports.cshtml")]
    public class Views_App_Shop : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(28, 26, true);
            WriteLiteral("\n<h1>Shop</h1>\n<h1>Count: ");
            EndContext();
            BeginContext(55, 13, false);
#line 4 "/Users/sgryt/Sites/C#/DutchTreat/Views/App/Shop.cshtml"
      Write(Model.Count());

#line default
#line hidden
            EndContext();
            BeginContext(68, 6, true);
            WriteLiteral("</h1>\n");
            EndContext();
#line 5 "/Users/sgryt/Sites/C#/DutchTreat/Views/App/Shop.cshtml"
 foreach (var p in Model)
{

#line default
#line hidden
            BeginContext(102, 8, true);
            WriteLiteral("    <li>");
            EndContext();
            BeginContext(111, 7, false);
#line 7 "/Users/sgryt/Sites/C#/DutchTreat/Views/App/Shop.cshtml"
   Write(p.Title);

#line default
#line hidden
            EndContext();
            BeginContext(118, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 8 "/Users/sgryt/Sites/C#/DutchTreat/Views/App/Shop.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
