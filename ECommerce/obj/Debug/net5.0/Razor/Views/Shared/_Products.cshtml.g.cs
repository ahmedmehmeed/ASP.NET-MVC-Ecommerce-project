#pragma checksum "E:\PROJECT\MVC\Ecommerce\Views\Shared\_Products.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7671a23bf82e583c89b292b4e3342ea01549a0a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Products), @"mvc.1.0.view", @"/Views/Shared/_Products.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7671a23bf82e583c89b292b4e3342ea01549a0a6", @"/Views/Shared/_Products.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bbcd7c65731fc074a835809e73fcf2cf9014c29", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__Products : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "E:\PROJECT\MVC\Ecommerce\Views\Shared\_Products.cshtml"
  foreach(var i in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container-overlay-products\" >\r\n<div class=\"row\">\r\n<div class=\"col-lg-3 col-sm-6 d-flex flex-column align-items-center justify-content-center product-item my-3\">\r\n       <div class=\"product\"> <img");
            BeginWriteAttribute("src", " src=\"", 261, "\"", 283, 2);
            WriteAttributeValue("", 267, "\\Images\\", 267, 8, true);
#nullable restore
#line 8 "E:\PROJECT\MVC\Ecommerce\Views\Shared\_Products.cshtml"
WriteAttributeValue("", 275, i.Image, 275, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""Card image"">
           <ul class=""d-flex align-items-center justify-content-center list-unstyled icons"">
               <li class=""icon""><span class=""fas fa-expand-arrows-alt""></span></li>
               <li class=""icon mx-3""><span class=""far fa-heart""></span></li>
               <li class=""icon""><span class=""fas fa-shopping-bag""></span></li>
           </ul>
       </div>
       <div class=""tag bg-black"">sale</div>
       <div class=""title pt-4 pb-1"">");
#nullable restore
#line 16 "E:\PROJECT\MVC\Ecommerce\Views\Shared\_Products.cshtml"
                               Write(i.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n       \r\n       <div class=\"price\">$ ");
#nullable restore
#line 18 "E:\PROJECT\MVC\Ecommerce\Views\Shared\_Products.cshtml"
                       Write(i.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n   </div>\r\n </div>\r\n</div>\r\n");
#nullable restore
#line 22 "E:\PROJECT\MVC\Ecommerce\Views\Shared\_Products.cshtml"
 }  

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
