#pragma checksum "/Users/sgryt/Sites/C#/DutchTreat/Views/App/Shop.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "245c709b41a8419040a5e11181a368b21498ba5f"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"245c709b41a8419040a5e11181a368b21498ba5f", @"/Views/App/Shop.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4a3ad7f18022ec7d179eeb291786d4302cfb376", @"/Views/_ViewImports.cshtml")]
    public class Views_App_Shop : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
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
            BeginContext(68, 24, true);
            WriteLiteral("</h1>\n<div class=\"row\">\n");
            EndContext();
#line 6 "/Users/sgryt/Sites/C#/DutchTreat/Views/App/Shop.cshtml"
     foreach (var p in Model)
    {

#line default
#line hidden
            BeginContext(128, 101, true);
            WriteLiteral("        <div class=\"col-md-3\">\n            <div class=\"border bg-light rounded p-1\">\n                ");
            EndContext();
            BeginContext(229, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f02e3bab38eb4c2ba81dcac9d784f46f", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 239, "~/img/", 239, 6, true);
#line 10 "/Users/sgryt/Sites/C#/DutchTreat/Views/App/Shop.cshtml"
AddHtmlAttributeValue("", 245, p.ArtId, 245, 10, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 255, ".jpg", 255, 4, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 10 "/Users/sgryt/Sites/C#/DutchTreat/Views/App/Shop.cshtml"
AddHtmlAttributeValue("", 284, p.Title, 284, 8, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(295, 21, true);
            WriteLiteral("\n                <h3>");
            EndContext();
            BeginContext(317, 10, false);
#line 11 "/Users/sgryt/Sites/C#/DutchTreat/Views/App/Shop.cshtml"
               Write(p.Category);

#line default
#line hidden
            EndContext();
            BeginContext(327, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(331, 6, false);
#line 11 "/Users/sgryt/Sites/C#/DutchTreat/Views/App/Shop.cshtml"
                             Write(p.Size);

#line default
#line hidden
            EndContext();
            BeginContext(337, 80, true);
            WriteLiteral("</h3>\n                <ul class=\"product-props\">\n                    <li>Price: ");
            EndContext();
            BeginContext(419, 15, false);
#line 13 "/Users/sgryt/Sites/C#/DutchTreat/Views/App/Shop.cshtml"
                           Write($"{p.Price:C2}");

#line default
#line hidden
            EndContext();
            BeginContext(435, 38, true);
            WriteLiteral("</li>\n                    <li>Artist: ");
            EndContext();
            BeginContext(474, 8, false);
#line 14 "/Users/sgryt/Sites/C#/DutchTreat/Views/App/Shop.cshtml"
                           Write(p.Artist);

#line default
#line hidden
            EndContext();
            BeginContext(482, 37, true);
            WriteLiteral("</li>\n                    <li>Title: ");
            EndContext();
            BeginContext(520, 7, false);
#line 15 "/Users/sgryt/Sites/C#/DutchTreat/Views/App/Shop.cshtml"
                          Write(p.Title);

#line default
#line hidden
            EndContext();
            BeginContext(527, 43, true);
            WriteLiteral("</li>\n                    <li>Description: ");
            EndContext();
            BeginContext(571, 16, false);
#line 16 "/Users/sgryt/Sites/C#/DutchTreat/Views/App/Shop.cshtml"
                                Write(p.ArtDescription);

#line default
#line hidden
            EndContext();
            BeginContext(587, 139, true);
            WriteLiteral("</li>\n                </ul>\n                <button id=\"buyButton\" class=\"btn btn-success\">Buy</button>\n            </div >\n        </div>\n");
            EndContext();
#line 21 "/Users/sgryt/Sites/C#/DutchTreat/Views/App/Shop.cshtml"
    }

#line default
#line hidden
            BeginContext(732, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
