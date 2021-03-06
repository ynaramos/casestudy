#pragma checksum "D:\GIT\source\repos\casestudy\GoldenShoe\Views\Shared\ShoppingCart\_ViewInCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa170f86ca4d887150e4504d736bce64144fc785"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ShoppingCart__ViewInCart), @"mvc.1.0.view", @"/Views/Shared/ShoppingCart/_ViewInCart.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/ShoppingCart/_ViewInCart.cshtml", typeof(AspNetCore.Views_Shared_ShoppingCart__ViewInCart))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa170f86ca4d887150e4504d736bce64144fc785", @"/Views/Shared/ShoppingCart/_ViewInCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cc3fd17064f3bf9fcc0d48e0561b9e92e2cd34d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_ShoppingCart__ViewInCart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<GoldenShoe.ViewModels.ShoppingCartItemViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(63, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\GIT\source\repos\casestudy\GoldenShoe\Views\Shared\ShoppingCart\_ViewInCart.cshtml"
  
    var imageFilepath = "/images/";
    var removeUrl = Url.Action("RemoveItem", "ShoppingCart");

#line default
#line hidden
            BeginContext(172, 118, true);
            WriteLiteral("\r\n<h3 style=\"padding: 20px\"><i class=\"fa fa-shopping-cart\" style=\"padding-right: 15px\"></i>Your Shopping Cart</h3>\r\n\r\n");
            EndContext();
#line 10 "D:\GIT\source\repos\casestudy\GoldenShoe\Views\Shared\ShoppingCart\_ViewInCart.cshtml"
 for (int i = 0; i < Model.Count; i++)
{

#line default
#line hidden
            BeginContext(333, 155, true);
            WriteLiteral("    <div class=\"row\" style=\"margin-top: 10px;\">\r\n        <div class=\"col-md-1\"></div>\r\n        <div class=\"col-md-auto col-sm-6 col-xs-4\" align=\"center\">\r\n");
            EndContext();
#line 15 "D:\GIT\source\repos\casestudy\GoldenShoe\Views\Shared\ShoppingCart\_ViewInCart.cshtml"
              
                var source = imageFilepath + Model[i].PhotoFilePath;
            

#line default
#line hidden
            BeginContext(589, 16, true);
            WriteLiteral("            <img");
            EndContext();
            BeginWriteAttribute("src", " src=", 605, "", 617, 1);
#line 18 "D:\GIT\source\repos\casestudy\GoldenShoe\Views\Shared\ShoppingCart\_ViewInCart.cshtml"
WriteAttributeValue("", 610, source, 610, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(617, 190, true);
            WriteLiteral(" class=\"img-thumbnail cart-product-image\" />\r\n        </div>\r\n        <div class=\"col-md-auto col-sm-6 col-xs-8\" style=\"padding-left: 50px;\">\r\n            <div class=\"row\">\r\n                ");
            EndContext();
            BeginContext(808, 35, false);
#line 22 "D:\GIT\source\repos\casestudy\GoldenShoe\Views\Shared\ShoppingCart\_ViewInCart.cshtml"
           Write(Html.HiddenFor(x => x[i].ProductID));

#line default
#line hidden
            EndContext();
            BeginContext(843, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 23 "D:\GIT\source\repos\casestudy\GoldenShoe\Views\Shared\ShoppingCart\_ViewInCart.cshtml"
                 if (Model[i].Available)
                {

#line default
#line hidden
            BeginContext(906, 24, true);
            WriteLiteral("                    <h6>");
            EndContext();
            BeginContext(931, 118, false);
#line 25 "D:\GIT\source\repos\casestudy\GoldenShoe\Views\Shared\ShoppingCart\_ViewInCart.cshtml"
                   Write(Html.ActionLink(Model[i].ShoeName.ToString(), "DisplayProductPage", "Product", new { productId = Model[i].ProductID }));

#line default
#line hidden
            EndContext();
            BeginContext(1049, 7, true);
            WriteLiteral("</h6>\r\n");
            EndContext();
#line 26 "D:\GIT\source\repos\casestudy\GoldenShoe\Views\Shared\ShoppingCart\_ViewInCart.cshtml"
                }
                else
                { 

#line default
#line hidden
            BeginContext(1117, 24, true);
            WriteLiteral("                    <h6>");
            EndContext();
            BeginContext(1142, 118, false);
#line 29 "D:\GIT\source\repos\casestudy\GoldenShoe\Views\Shared\ShoppingCart\_ViewInCart.cshtml"
                   Write(Html.ActionLink(Model[i].ShoeName.ToString(), "DisplayProductPage", "Product", new { productId = Model[i].ProductID }));

#line default
#line hidden
            EndContext();
            BeginContext(1260, 35, true);
            WriteLiteral(" (Size no longer available) </h6>\r\n");
            EndContext();
#line 30 "D:\GIT\source\repos\casestudy\GoldenShoe\Views\Shared\ShoppingCart\_ViewInCart.cshtml"
                }

#line default
#line hidden
            BeginContext(1314, 67, true);
            WriteLiteral("            </div>\r\n            <div class=\"row\">\r\n                ");
            EndContext();
            BeginContext(1382, 32, false);
#line 33 "D:\GIT\source\repos\casestudy\GoldenShoe\Views\Shared\ShoppingCart\_ViewInCart.cshtml"
           Write(Html.HiddenFor(x => x[i].SizeID));

#line default
#line hidden
            EndContext();
            BeginContext(1414, 35, true);
            WriteLiteral("\r\n                <h7><b>Size:</b> ");
            EndContext();
            BeginContext(1450, 31, false);
#line 34 "D:\GIT\source\repos\casestudy\GoldenShoe\Views\Shared\ShoppingCart\_ViewInCart.cshtml"
                            Write(Html.DisplayFor(x => x[i].Size));

#line default
#line hidden
            EndContext();
            BeginContext(1481, 96, true);
            WriteLiteral(" </h7>\r\n            </div>\r\n            <div class=\"row\">\r\n                <h7><b>Quantity:</b> ");
            EndContext();
            BeginContext(1578, 35, false);
#line 37 "D:\GIT\source\repos\casestudy\GoldenShoe\Views\Shared\ShoppingCart\_ViewInCart.cshtml"
                                Write(Html.DisplayFor(x => x[i].Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(1613, 59, true);
            WriteLiteral(" </h7>\r\n            </div>\r\n            <div class=\"row\">\r\n");
            EndContext();
#line 40 "D:\GIT\source\repos\casestudy\GoldenShoe\Views\Shared\ShoppingCart\_ViewInCart.cshtml"
                 if (Model[i].DiscountedPrice > 0)
                {

#line default
#line hidden
            BeginContext(1743, 46, true);
            WriteLiteral("                    <h7><b>Price:</b> <strike>");
            EndContext();
            BeginContext(1790, 32, false);
#line 42 "D:\GIT\source\repos\casestudy\GoldenShoe\Views\Shared\ShoppingCart\_ViewInCart.cshtml"
                                         Write(Html.DisplayFor(x => x[i].Price));

#line default
#line hidden
            EndContext();
            BeginContext(1822, 39, true);
            WriteLiteral("</strike> <span class=\"discount-style\">");
            EndContext();
            BeginContext(1862, 42, false);
#line 42 "D:\GIT\source\repos\casestudy\GoldenShoe\Views\Shared\ShoppingCart\_ViewInCart.cshtml"
                                                                                                                 Write(Html.DisplayFor(x => x[i].DiscountedPrice));

#line default
#line hidden
            EndContext();
            BeginContext(1904, 14, true);
            WriteLiteral("</span></h7>\r\n");
            EndContext();
#line 43 "D:\GIT\source\repos\casestudy\GoldenShoe\Views\Shared\ShoppingCart\_ViewInCart.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(1978, 38, true);
            WriteLiteral("                    <h7><b>Price:</b> ");
            EndContext();
            BeginContext(2017, 32, false);
#line 46 "D:\GIT\source\repos\casestudy\GoldenShoe\Views\Shared\ShoppingCart\_ViewInCart.cshtml"
                                 Write(Html.DisplayFor(x => x[i].Price));

#line default
#line hidden
            EndContext();
            BeginContext(2049, 7, true);
            WriteLiteral("</h7>\r\n");
            EndContext();
#line 47 "D:\GIT\source\repos\casestudy\GoldenShoe\Views\Shared\ShoppingCart\_ViewInCart.cshtml"
                }

#line default
#line hidden
            BeginContext(2075, 51, true);
            WriteLiteral("            </div>\r\n            <div class=\"row\">\r\n");
            EndContext();
#line 50 "D:\GIT\source\repos\casestudy\GoldenShoe\Views\Shared\ShoppingCart\_ViewInCart.cshtml"
                 if (Model[i].DiscountedTotalPrice > 0)
                {

#line default
#line hidden
            BeginContext(2202, 49, true);
            WriteLiteral("                    <h7><b>Subtotal:</b> <strike>");
            EndContext();
            BeginContext(2252, 37, false);
#line 52 "D:\GIT\source\repos\casestudy\GoldenShoe\Views\Shared\ShoppingCart\_ViewInCart.cshtml"
                                            Write(Html.DisplayFor(x => x[i].TotalPrice));

#line default
#line hidden
            EndContext();
            BeginContext(2289, 39, true);
            WriteLiteral("</strike> <span class=\"discount-style\">");
            EndContext();
            BeginContext(2329, 47, false);
#line 52 "D:\GIT\source\repos\casestudy\GoldenShoe\Views\Shared\ShoppingCart\_ViewInCart.cshtml"
                                                                                                                         Write(Html.DisplayFor(x => x[i].DiscountedTotalPrice));

#line default
#line hidden
            EndContext();
            BeginContext(2376, 14, true);
            WriteLiteral("</span></h7>\r\n");
            EndContext();
#line 53 "D:\GIT\source\repos\casestudy\GoldenShoe\Views\Shared\ShoppingCart\_ViewInCart.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(2450, 41, true);
            WriteLiteral("                    <h7><b>Subtotal:</b> ");
            EndContext();
            BeginContext(2492, 37, false);
#line 56 "D:\GIT\source\repos\casestudy\GoldenShoe\Views\Shared\ShoppingCart\_ViewInCart.cshtml"
                                    Write(Html.DisplayFor(x => x[i].TotalPrice));

#line default
#line hidden
            EndContext();
            BeginContext(2529, 8, true);
            WriteLiteral(" </h7>\r\n");
            EndContext();
#line 57 "D:\GIT\source\repos\casestudy\GoldenShoe\Views\Shared\ShoppingCart\_ViewInCart.cshtml"
                }

#line default
#line hidden
            BeginContext(2556, 111, true);
            WriteLiteral("            </div>\r\n            <div class=\"row\">\r\n                <button class=\"btn btn-danger\" type=\"button\"");
            EndContext();
            BeginWriteAttribute("onclick", "\r\n                        onclick=\"", 2667, "\"", 2884, 25);
            WriteAttributeValue("", 2702, "event.stopPropagation();", 2702, 24, true);
            WriteAttributeValue(" ", 2726, "if", 2727, 3, true);
            WriteAttributeValue(" ", 2729, "(confirm(\'Are", 2730, 14, true);
            WriteAttributeValue(" ", 2743, "you", 2744, 4, true);
            WriteAttributeValue(" ", 2747, "sure", 2748, 5, true);
            WriteAttributeValue(" ", 2752, "you", 2753, 4, true);
            WriteAttributeValue(" ", 2756, "want", 2757, 5, true);
            WriteAttributeValue(" ", 2761, "to", 2762, 3, true);
            WriteAttributeValue(" ", 2764, "remove", 2765, 7, true);
            WriteAttributeValue(" ", 2771, "this", 2772, 5, true);
            WriteAttributeValue(" ", 2776, "item", 2777, 5, true);
            WriteAttributeValue(" ", 2781, "from", 2782, 5, true);
            WriteAttributeValue(" ", 2786, "your", 2787, 5, true);
            WriteAttributeValue(" ", 2791, "cart?\'))", 2792, 9, true);
            WriteAttributeValue(" ", 2800, "{", 2801, 2, true);
            WriteAttributeValue(" ", 2802, "removeShoppingCartItem(\'", 2803, 25, true);
#line 61 "D:\GIT\source\repos\casestudy\GoldenShoe\Views\Shared\ShoppingCart\_ViewInCart.cshtml"
WriteAttributeValue("", 2827, removeUrl, 2827, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 2837, "\',", 2837, 2, true);
            WriteAttributeValue(" ", 2839, "\'", 2840, 2, true);
#line 61 "D:\GIT\source\repos\casestudy\GoldenShoe\Views\Shared\ShoppingCart\_ViewInCart.cshtml"
WriteAttributeValue("", 2841, Model[i].ProductID, 2841, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 2860, "\',", 2860, 2, true);
            WriteAttributeValue(" ", 2862, "\'", 2863, 2, true);
#line 61 "D:\GIT\source\repos\casestudy\GoldenShoe\Views\Shared\ShoppingCart\_ViewInCart.cshtml"
WriteAttributeValue("", 2864, Model[i].SizeID, 2864, 16, false);

#line default
#line hidden
            WriteAttributeValue("", 2880, "\')", 2880, 2, true);
            WriteAttributeValue(" ", 2882, "}", 2883, 2, true);
            EndWriteAttribute();
            BeginContext(2885, 127, true);
            WriteLiteral(">\r\n                    <i class=\"fa fa-trash\"></i>\r\n                </button>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
            BeginContext(3014, 12, true);
            WriteLiteral("    <hr />\r\n");
            EndContext();
#line 69 "D:\GIT\source\repos\casestudy\GoldenShoe\Views\Shared\ShoppingCart\_ViewInCart.cshtml"
}

#line default
#line hidden
            BeginContext(3029, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<GoldenShoe.ViewModels.ShoppingCartItemViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
