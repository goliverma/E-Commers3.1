#pragma checksum "/home/goli/program/demo/demo/Views/Order/CheckoutComplete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae27c139e82b0dfdb28ff15428f2a9cfaf08a87a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_CheckoutComplete), @"mvc.1.0.view", @"/Views/Order/CheckoutComplete.cshtml")]
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
#line 1 "/home/goli/program/demo/demo/Views/_ViewImports.cshtml"
using demo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/goli/program/demo/demo/Views/_ViewImports.cshtml"
using demo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/goli/program/demo/demo/Views/_ViewImports.cshtml"
using demo.Models.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/goli/program/demo/demo/Views/_ViewImports.cshtml"
using demo.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae27c139e82b0dfdb28ff15428f2a9cfaf08a87a", @"/Views/Order/CheckoutComplete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8913f5edf792d93d519c5f8751a29fc8ad8f0f53", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_CheckoutComplete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>\n    ");
#nullable restore
#line 2 "/home/goli/program/demo/demo/Views/Order/CheckoutComplete.cshtml"
Write(ViewBag.CheckoutComplete);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</h1>");
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