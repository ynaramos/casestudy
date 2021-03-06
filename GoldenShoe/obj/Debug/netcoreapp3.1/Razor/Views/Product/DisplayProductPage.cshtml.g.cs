#pragma checksum "D:\GIT\source\repos\casestudy\GoldenShoe\Views\Product\DisplayProductPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35ba34d47993b05f538aac1bc719f7ae5d0a6f6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_DisplayProductPage), @"mvc.1.0.view", @"/Views/Product/DisplayProductPage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/DisplayProductPage.cshtml", typeof(AspNetCore.Views_Product_DisplayProductPage))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35ba34d47993b05f538aac1bc719f7ae5d0a6f6f", @"/Views/Product/DisplayProductPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cc3fd17064f3bf9fcc0d48e0561b9e92e2cd34d", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_DisplayProductPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GoldenShoe.ViewModels.ProductViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\GIT\source\repos\casestudy\GoldenShoe\Views\Product\DisplayProductPage.cshtml"
  
    var imageFilepath = "/images/";
    var homePath = Url.Action("Index", "Home");
    var addItemToCart = Url.Action("AddProductToCart", "Product");

#line default
#line hidden
            BeginContext(210, 50, true);
            WriteLiteral("\r\n\r\n<script>\r\n    changeShoppingCartNotification(\'");
            EndContext();
            BeginContext(261, 12, false);
#line 11 "D:\GIT\source\repos\casestudy\GoldenShoe\Views\Product\DisplayProductPage.cshtml"
                               Write(Model.InCart);

#line default
#line hidden
            EndContext();
            BeginContext(273, 86, true);
            WriteLiteral("\')\r\n</script>\r\n\r\n<div class=\"row\" style=\"margin-top:15px; margin-left: 10px;\">\r\n    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 359, "\"", 375, 1);
#line 15 "D:\GIT\source\repos\casestudy\GoldenShoe\Views\Product\DisplayProductPage.cshtml"
WriteAttributeValue("", 366, homePath, 366, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(376, 270, true);
            WriteLiteral(@" class=""btn btn-outline-dark"" role=""button"">
        <i class=""fa fa-arrow-left"" style=""padding-right: 5px""></i>
        <span>Continue browsing</span>
    </a>
</div>

<div class=""row"">
    <div class=""column col-md-6"" align=""center"" style=""margin-top: 15px;"">
");
            EndContext();
#line 23 "D:\GIT\source\repos\casestudy\GoldenShoe\Views\Product\DisplayProductPage.cshtml"
          
            var source = imageFilepath + Model.Product.PhotoFilepath;
        

#line default
#line hidden
            BeginContext(740, 12, true);
            WriteLiteral("        <img");
            EndContext();
            BeginWriteAttribute("src", " src=", 752, "", 764, 1);
#line 26 "D:\GIT\source\repos\casestudy\GoldenShoe\Views\Product\DisplayProductPage.cshtml"
WriteAttributeValue("", 757, source, 757, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(764, 103, true);
            WriteLiteral(" class=\"rounded product-image\" />\r\n    </div>\r\n    <div class=\"column col-md-6 product-desc\">\r\n        ");
            EndContext();
            BeginContext(868, 33, false);
#line 29 "D:\GIT\source\repos\casestudy\GoldenShoe\Views\Product\DisplayProductPage.cshtml"
   Write(Html.HiddenFor(x => x.Product.ID));

#line default
#line hidden
            EndContext();
            BeginContext(901, 14, true);
            WriteLiteral("\r\n        <h3>");
            EndContext();
            BeginContext(916, 40, false);
#line 30 "D:\GIT\source\repos\casestudy\GoldenShoe\Views\Product\DisplayProductPage.cshtml"
       Write(Html.DisplayFor(x => x.Product.ShoeName));

#line default
#line hidden
            EndContext();
            BeginContext(956, 19, true);
            WriteLiteral("</h3>\r\n        <h4>");
            EndContext();
            BeginContext(976, 37, false);
#line 31 "D:\GIT\source\repos\casestudy\GoldenShoe\Views\Product\DisplayProductPage.cshtml"
       Write(Html.DisplayFor(x => x.Product.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1013, 22, true);
            WriteLiteral("</h4>\r\n        <div>\r\n");
            EndContext();
#line 33 "D:\GIT\source\repos\casestudy\GoldenShoe\Views\Product\DisplayProductPage.cshtml"
             for (int i = 0; i < 5; i++)
            {

#line default
#line hidden
            BeginContext(1092, 45, true);
            WriteLiteral("                <i class=\"far fa-star\"></i>\r\n");
            EndContext();
#line 36 "D:\GIT\source\repos\casestudy\GoldenShoe\Views\Product\DisplayProductPage.cshtml"
            }

#line default
#line hidden
            BeginContext(1152, 91, true);
            WriteLiteral("        </div>\r\n        <div style=\"padding-top: 15px; padding-bottom: 5px;\">\r\n            ");
            EndContext();
            BeginContext(1244, 120, false);
#line 39 "D:\GIT\source\repos\casestudy\GoldenShoe\Views\Product\DisplayProductPage.cshtml"
       Write(Html.DropDownListFor(x => x.SelectedSizeID, Model.Availabilities, new { @class = "form-control", @id = "sizeDropdown" }));

#line default
#line hidden
            EndContext();
            BeginContext(1364, 106, true);
            WriteLiteral("\r\n        </div>\r\n        <div style=\"padding-bottom: 15px;\">\r\n            <button class=\"btn btn-success\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1470, "\"", 1555, 7);
            WriteAttributeValue("", 1480, "addToCart(\'", 1480, 11, true);
#line 42 "D:\GIT\source\repos\casestudy\GoldenShoe\Views\Product\DisplayProductPage.cshtml"
WriteAttributeValue("", 1491, addItemToCart, 1491, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 1505, "\',", 1505, 2, true);
            WriteAttributeValue(" ", 1507, "\'", 1508, 2, true);
#line 42 "D:\GIT\source\repos\casestudy\GoldenShoe\Views\Product\DisplayProductPage.cshtml"
WriteAttributeValue("", 1509, Model.Product.ID, 1509, 17, false);

#line default
#line hidden
            WriteAttributeValue("", 1526, "\',", 1526, 2, true);
            WriteAttributeValue(" ", 1528, "$(\'#sizeDropdown\').val());", 1529, 27, true);
            EndWriteAttribute();
            BeginContext(1556, 170, true);
            WriteLiteral(">Add to cart</button>\r\n            <button class=\"btn btn-light\"><i class=\"far fa-heart\"></i></button>\r\n        </div>\r\n        <div class=\"card\"><p style=\"padding:5px;\">");
            EndContext();
            BeginContext(1727, 43, false);
#line 45 "D:\GIT\source\repos\casestudy\GoldenShoe\Views\Product\DisplayProductPage.cshtml"
                                             Write(Html.DisplayFor(x => x.Product.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1770, 30, true);
            WriteLiteral("</p></div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GoldenShoe.ViewModels.ProductViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
