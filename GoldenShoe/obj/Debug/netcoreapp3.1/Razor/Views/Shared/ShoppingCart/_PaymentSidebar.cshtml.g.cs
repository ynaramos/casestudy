#pragma checksum "D:\GIT\source\repos\casestudy\GoldenShoe\Views\Shared\ShoppingCart\_PaymentSidebar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3e9819d84ae27650230f6469f27dd888005bbe5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ShoppingCart__PaymentSidebar), @"mvc.1.0.view", @"/Views/Shared/ShoppingCart/_PaymentSidebar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/ShoppingCart/_PaymentSidebar.cshtml", typeof(AspNetCore.Views_Shared_ShoppingCart__PaymentSidebar))]
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
#line 1 "D:\GIT\source\repos\casestudy\GoldenShoe\Views\_ViewImports.cshtml"
using GoldenShoe;

#line default
#line hidden
#line 2 "D:\GIT\source\repos\casestudy\GoldenShoe\Views\_ViewImports.cshtml"
using GoldenShoe.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3e9819d84ae27650230f6469f27dd888005bbe5", @"/Views/Shared/ShoppingCart/_PaymentSidebar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cc3fd17064f3bf9fcc0d48e0561b9e92e2cd34d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_ShoppingCart__PaymentSidebar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GoldenShoe.ViewModels.CartTotalViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 162, true);
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-10\">\r\n        <div class=\"sidebar rounded-top rounded-bottom\">\r\n            <div class=\"form-row\">\r\n                ");
            EndContext();
            BeginContext(212, 56, false);
#line 8 "D:\GIT\source\repos\casestudy\GoldenShoe\Views\Shared\ShoppingCart\_PaymentSidebar.cshtml"
           Write(Html.LabelFor(x => x.Voucher.ID, "Enter a voucher code"));

#line default
#line hidden
            EndContext();
            BeginContext(268, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(287, 67, false);
#line 9 "D:\GIT\source\repos\casestudy\GoldenShoe\Views\Shared\ShoppingCart\_PaymentSidebar.cshtml"
           Write(Html.TextBoxFor(x => x.Voucher.ID, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(354, 246, true);
            WriteLiteral("\r\n                <button type=\"button\" class=\"btn btn-secondary\" style=\"margin-top: 10px\">Apply voucher code</button>\r\n            </div>\r\n\r\n            <hr />\r\n            <div style=\"margin-top:20px\" align=\"right\">\r\n                <h3>Total: ");
            EndContext();
            BeginContext(601, 29, false);
#line 15 "D:\GIT\source\repos\casestudy\GoldenShoe\Views\Shared\ShoppingCart\_PaymentSidebar.cshtml"
                      Write(Html.DisplayFor(x => x.Total));

#line default
#line hidden
            EndContext();
            BeginContext(630, 198, true);
            WriteLiteral("</h3>\r\n                <button type=\"button\" class=\"btn btn-success\">Checkout</button>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"col-md-2\">\r\n\r\n    </div>\r\n\r\n    <hr />\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GoldenShoe.ViewModels.CartTotalViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591