#pragma checksum "C:\Users\Acer\Desktop\BilalKarakan\AspNet Core 5.0\AspNetCore_017\sampleProject\sampleProject.web\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5028389aec63ccbb0725dcd6bcdca6a89b18ce39"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5028389aec63ccbb0725dcd6bcdca6a89b18ce39", @"/Views/Product/Index.cshtml")]
    #nullable restore
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h3>ViewBag</h3>\r\n<ul>\r\n");
#nullable restore
#line 16 "C:\Users\Acer\Desktop\BilalKarakan\AspNet Core 5.0\AspNetCore_017\sampleProject\sampleProject.web\Views\Product\Index.cshtml"
     foreach (var product in ViewBag.products as List<sampleProject.web.Models.Product>)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
#nullable restore
#line 18 "C:\Users\Acer\Desktop\BilalKarakan\AspNet Core 5.0\AspNetCore_017\sampleProject\sampleProject.web\Views\Product\Index.cshtml"
       Write(product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 19 "C:\Users\Acer\Desktop\BilalKarakan\AspNet Core 5.0\AspNetCore_017\sampleProject\sampleProject.web\Views\Product\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n\r\n<h3>ViewData</h3>\r\n\r\n<ul>\r\n");
#nullable restore
#line 25 "C:\Users\Acer\Desktop\BilalKarakan\AspNet Core 5.0\AspNetCore_017\sampleProject\sampleProject.web\Views\Product\Index.cshtml"
     foreach (var product in ViewData["products"] as List<sampleProject.web.Models.Product>)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
#nullable restore
#line 27 "C:\Users\Acer\Desktop\BilalKarakan\AspNet Core 5.0\AspNetCore_017\sampleProject\sampleProject.web\Views\Product\Index.cshtml"
       Write(product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 28 "C:\Users\Acer\Desktop\BilalKarakan\AspNet Core 5.0\AspNetCore_017\sampleProject\sampleProject.web\Views\Product\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n\r\n<h3>TempData</h3>\r\n\r\n<ul>\r\n");
#nullable restore
#line 34 "C:\Users\Acer\Desktop\BilalKarakan\AspNet Core 5.0\AspNetCore_017\sampleProject\sampleProject.web\Views\Product\Index.cshtml"
     foreach (var product in TempData["products"] as List<sampleProject.web.Models.Product>)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
#nullable restore
#line 36 "C:\Users\Acer\Desktop\BilalKarakan\AspNet Core 5.0\AspNetCore_017\sampleProject\sampleProject.web\Views\Product\Index.cshtml"
       Write(product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 37 "C:\Users\Acer\Desktop\BilalKarakan\AspNet Core 5.0\AspNetCore_017\sampleProject\sampleProject.web\Views\Product\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591