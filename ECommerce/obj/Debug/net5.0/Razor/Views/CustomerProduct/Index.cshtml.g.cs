#pragma checksum "E:\PROJECT\MVC\Ecommerce\Views\CustomerProduct\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b9eb959e7e54a9deaf098c09260834f6c5dceb5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CustomerProduct_Index), @"mvc.1.0.view", @"/Views/CustomerProduct/Index.cshtml")]
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
#line 1 "E:\PROJECT\MVC\Ecommerce\Views\_ViewImports.cshtml"
using Ecommerce;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\PROJECT\MVC\Ecommerce\Views\_ViewImports.cshtml"
using Ecommerce.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b9eb959e7e54a9deaf098c09260834f6c5dceb5", @"/Views/CustomerProduct/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bbcd7c65731fc074a835809e73fcf2cf9014c29", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_CustomerProduct_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Ecommerce.Models.Product>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\PROJECT\MVC\Ecommerce\Views\CustomerProduct\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"





<!-- ***** Main Banner Area Start ***** -->
    <div class=""page-heading"" id=""top"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <div class=""inner-content"">
                        <h2>Check Our Products</h2>
                        <span>Awesome &amp; Creative HTML CSS layout by TemplateMo</span>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- ***** Main Banner Area End ***** -->
<!-- Section-->

        <section class=""py-5"">
            <div class=""container px-4 px-lg-5 mt-5"">
                <div class=""row gx-3 gx-lg-5 row-cols-1 row-cols-md-3 row-cols-xl-3 justify-content-center"">
");
#nullable restore
#line 32 "E:\PROJECT\MVC\Ecommerce\Views\CustomerProduct\Index.cshtml"
                         foreach(var item in Model){


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col mb-5\">\r\n                        <div class=\"card h-100\">\r\n                            <!-- Product image-->\r\n                            <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 1127, "\"", 1152, 2);
            WriteAttributeValue("", 1133, "/Images/", 1133, 8, true);
#nullable restore
#line 37 "E:\PROJECT\MVC\Ecommerce\Views\CustomerProduct\Index.cshtml"
WriteAttributeValue("", 1141, item.Image, 1141, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""..."" />
                            <!-- Product details-->
                            <div class=""card-body p-4"">
                                <div class=""text-center"">
                                    <!-- Product name-->
                                    <h5 class=""fw-bolder"">");
#nullable restore
#line 42 "E:\PROJECT\MVC\Ecommerce\Views\CustomerProduct\Index.cshtml"
                                                     Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                    <!-- Product price-->\r\n                                    ");
#nullable restore
#line 44 "E:\PROJECT\MVC\Ecommerce\Views\CustomerProduct\Index.cshtml"
                               Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                            <!-- Product actions-->
                            <div class=""card-footer p-4 pt-0 border-top-0 bg-transparent"">
                                <div class=""text-center""><a class=""btn btn-outline-dark mt-auto""");
            BeginWriteAttribute("href", " href=\"", 1895, "\"", 1931, 2);
            WriteAttributeValue("", 1902, "/Home/ProductDetails/", 1902, 21, true);
#nullable restore
#line 49 "E:\PROJECT\MVC\Ecommerce\Views\CustomerProduct\Index.cshtml"
WriteAttributeValue("", 1923, item.Id, 1923, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a></div>\r\n                            </div>\r\n                        </div>\r\n                        \r\n                    </div>\r\n");
#nullable restore
#line 54 "E:\PROJECT\MVC\Ecommerce\Views\CustomerProduct\Index.cshtml"
               
                   }

#line default
#line hidden
#nullable disable
            WriteLiteral("                \r\n                </div>\r\n                \r\n            </div>\r\n        </section>\r\n        ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Ecommerce.Models.Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
