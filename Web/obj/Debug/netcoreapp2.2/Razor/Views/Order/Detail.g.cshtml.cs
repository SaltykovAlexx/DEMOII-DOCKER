#pragma checksum "D:\@@@SS\DEMO-II\eshop\src\Web\Views\Order\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e320e0446afd64d1294b507187a6baa7e8766eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Microsoft.eShopWeb.Web.Pages.Order.Views_Order_Detail), @"mvc.1.0.view", @"/Views/Order/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/Detail.cshtml", typeof(Microsoft.eShopWeb.Web.Pages.Order.Views_Order_Detail))]
namespace Microsoft.eShopWeb.Web.Pages.Order
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\@@@SS\DEMO-II\eshop\src\Web\Views\_ViewImports.cshtml"
using Microsoft.eShopWeb.Web;

#line default
#line hidden
#line 2 "D:\@@@SS\DEMO-II\eshop\src\Web\Views\_ViewImports.cshtml"
using Microsoft.eShopWeb.Web.ViewModels;

#line default
#line hidden
#line 3 "D:\@@@SS\DEMO-II\eshop\src\Web\Views\_ViewImports.cshtml"
using Microsoft.eShopWeb.Web.ViewModels.Account;

#line default
#line hidden
#line 4 "D:\@@@SS\DEMO-II\eshop\src\Web\Views\_ViewImports.cshtml"
using Microsoft.eShopWeb.Web.ViewModels.Manage;

#line default
#line hidden
#line 5 "D:\@@@SS\DEMO-II\eshop\src\Web\Views\_ViewImports.cshtml"
using Microsoft.eShopWeb.Web.Pages;

#line default
#line hidden
#line 6 "D:\@@@SS\DEMO-II\eshop\src\Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 7 "D:\@@@SS\DEMO-II\eshop\src\Web\Views\_ViewImports.cshtml"
using Microsoft.eShopWeb.Infrastructure.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e320e0446afd64d1294b507187a6baa7e8766eb", @"/Views/Order/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3eac3cadc9c5c1e04416db60e767f2c2d60b242", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrderViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\@@@SS\DEMO-II\eshop\src\Web\Views\Order\Detail.cshtml"
  
    ViewData["Title"] = "My Order History";

#line default
#line hidden
#line 5 "D:\@@@SS\DEMO-II\eshop\src\Web\Views\Order\Detail.cshtml"
  
    ViewData["Title"] = "Order Detail";

#line default
#line hidden
            BeginContext(116, 654, true);
            WriteLiteral(@"
<div class=""esh-orders_detail"">
    <div class=""container"">
        <section class=""esh-orders_detail-section"">
            <article class=""esh-orders_detail-titles row"">
                <section class=""esh-orders_detail-title col-xs-3"">Order number</section>
                <section class=""esh-orders_detail-title col-xs-3"">Date</section>
                <section class=""esh-orders_detail-title col-xs-3"">Total</section>
                <section class=""esh-orders_detail-title col-xs-3"">Status</section>
            </article>

            <article class=""esh-orders_detail-items row"">
                <section class=""esh-orders_detail-item col-xs-3"">");
            EndContext();
            BeginContext(771, 17, false);
#line 20 "D:\@@@SS\DEMO-II\eshop\src\Web\Views\Order\Detail.cshtml"
                                                            Write(Model.OrderNumber);

#line default
#line hidden
            EndContext();
            BeginContext(788, 76, true);
            WriteLiteral("</section>\n                <section class=\"esh-orders_detail-item col-xs-3\">");
            EndContext();
            BeginContext(865, 15, false);
#line 21 "D:\@@@SS\DEMO-II\eshop\src\Web\Views\Order\Detail.cshtml"
                                                            Write(Model.OrderDate);

#line default
#line hidden
            EndContext();
            BeginContext(880, 77, true);
            WriteLiteral("</section>\n                <section class=\"esh-orders_detail-item col-xs-3\">$");
            EndContext();
            BeginContext(958, 11, false);
#line 22 "D:\@@@SS\DEMO-II\eshop\src\Web\Views\Order\Detail.cshtml"
                                                             Write(Model.Total);

#line default
#line hidden
            EndContext();
            BeginContext(969, 77, true);
            WriteLiteral("</section>\n                <section class=\"esh-orders_detail-title col-xs-3\">");
            EndContext();
            BeginContext(1047, 12, false);
#line 23 "D:\@@@SS\DEMO-II\eshop\src\Web\Views\Order\Detail.cshtml"
                                                             Write(Model.Status);

#line default
#line hidden
            EndContext();
            BeginContext(1059, 54, true);
            WriteLiteral("</section>\n            </article>\n        </section>\n\n");
            EndContext();
            BeginContext(1564, 354, true);
            WriteLiteral(@"
        <section class=""esh-orders_detail-section"">
            <article class=""esh-orders_detail-titles row"">
                <section class=""esh-orders_detail-title col-xs-12"">Shipping Address</section>
            </article>

            <article class=""esh-orders_detail-items row"">
                <section class=""esh-orders_detail-item col-xs-12"">");
            EndContext();
            BeginContext(1919, 28, false);
#line 43 "D:\@@@SS\DEMO-II\eshop\src\Web\Views\Order\Detail.cshtml"
                                                             Write(Model.ShippingAddress.Street);

#line default
#line hidden
            EndContext();
            BeginContext(1947, 159, true);
            WriteLiteral("</section>\n            </article>\n\n            <article class=\"esh-orders_detail-items row\">\n                <section class=\"esh-orders_detail-item col-xs-12\">");
            EndContext();
            BeginContext(2107, 26, false);
#line 47 "D:\@@@SS\DEMO-II\eshop\src\Web\Views\Order\Detail.cshtml"
                                                             Write(Model.ShippingAddress.City);

#line default
#line hidden
            EndContext();
            BeginContext(2133, 159, true);
            WriteLiteral("</section>\n            </article>\n\n            <article class=\"esh-orders_detail-items row\">\n                <section class=\"esh-orders_detail-item col-xs-12\">");
            EndContext();
            BeginContext(2293, 29, false);
#line 51 "D:\@@@SS\DEMO-II\eshop\src\Web\Views\Order\Detail.cshtml"
                                                             Write(Model.ShippingAddress.Country);

#line default
#line hidden
            EndContext();
            BeginContext(2322, 280, true);
            WriteLiteral(@"</section>
            </article>
        </section>

        <section class=""esh-orders_detail-section"">
            <article class=""esh-orders_detail-titles row"">
                <section class=""esh-orders_detail-title col-xs-12"">ORDER DETAILS</section>
            </article>

");
            EndContext();
#line 60 "D:\@@@SS\DEMO-II\eshop\src\Web\Views\Order\Detail.cshtml"
             for (int i = 0; i < Model.OrderItems.Count; i++)
            {
                var item = Model.OrderItems[i];

#line default
#line hidden
            BeginContext(2726, 239, true);
            WriteLiteral("                <article class=\"esh-orders_detail-items esh-orders_detail-items--border row\">\n                    <section class=\"esh-orders_detail-item col-md-4 hidden-md-down\">\n                        <img class=\"esh-orders_detail-image\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2965, "\"", 2987, 1);
#line 65 "D:\@@@SS\DEMO-II\eshop\src\Web\Views\Order\Detail.cshtml"
WriteAttributeValue("", 2971, item.PictureUrl, 2971, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2988, 133, true);
            WriteLiteral(">\n                    </section>\n                    <section class=\"esh-orders_detail-item esh-orders_detail-item--middle col-xs-4\">");
            EndContext();
            BeginContext(3122, 16, false);
#line 67 "D:\@@@SS\DEMO-II\eshop\src\Web\Views\Order\Detail.cshtml"
                                                                                               Write(item.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(3138, 113, true);
            WriteLiteral("</section>\n                    <section class=\"esh-orders_detail-item esh-orders_detail-item--middle col-xs-1\">$ ");
            EndContext();
            BeginContext(3252, 29, false);
#line 68 "D:\@@@SS\DEMO-II\eshop\src\Web\Views\Order\Detail.cshtml"
                                                                                                 Write(item.UnitPrice.ToString("N2"));

#line default
#line hidden
            EndContext();
            BeginContext(3281, 111, true);
            WriteLiteral("</section>\n                    <section class=\"esh-orders_detail-item esh-orders_detail-item--middle col-xs-1\">");
            EndContext();
            BeginContext(3393, 10, false);
#line 69 "D:\@@@SS\DEMO-II\eshop\src\Web\Views\Order\Detail.cshtml"
                                                                                               Write(item.Units);

#line default
#line hidden
            EndContext();
            BeginContext(3403, 113, true);
            WriteLiteral("</section>\n                    <section class=\"esh-orders_detail-item esh-orders_detail-item--middle col-xs-2\">$ ");
            EndContext();
            BeginContext(3517, 57, false);
#line 70 "D:\@@@SS\DEMO-II\eshop\src\Web\Views\Order\Detail.cshtml"
                                                                                                 Write(Math.Round(item.Units * item.UnitPrice, 2).ToString("N2"));

#line default
#line hidden
            EndContext();
            BeginContext(3574, 38, true);
            WriteLiteral("</section>\n                </article>\n");
            EndContext();
#line 72 "D:\@@@SS\DEMO-II\eshop\src\Web\Views\Order\Detail.cshtml"
            }

#line default
#line hidden
            BeginContext(3626, 602, true);
            WriteLiteral(@"        </section>

        <section class=""esh-orders_detail-section esh-orders_detail-section--right"">
            <article class=""esh-orders_detail-titles esh-basket-titles--clean row"">
                <section class=""esh-orders_detail-title col-xs-9""></section>
                <section class=""esh-orders_detail-title col-xs-2"">TOTAL</section>
            </article>

            <article class=""esh-orders_detail-items row"">
                <section class=""esh-orders_detail-item col-xs-9""></section>
                <section class=""esh-orders_detail-item esh-orders_detail-item--mark col-xs-2"">$ ");
            EndContext();
            BeginContext(4229, 26, false);
#line 83 "D:\@@@SS\DEMO-II\eshop\src\Web\Views\Order\Detail.cshtml"
                                                                                           Write(Model.Total.ToString("N2"));

#line default
#line hidden
            EndContext();
            BeginContext(4255, 71, true);
            WriteLiteral("</section>\n            </article>\n        </section>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrderViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
