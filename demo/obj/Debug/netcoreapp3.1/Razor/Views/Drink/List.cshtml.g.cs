#pragma checksum "/home/goli/Desktop/code/demo/E-Commers3.1/demo/Views/Drink/List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a57347d830c71532b164cbb0205eb36a4d520df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Drink_List), @"mvc.1.0.view", @"/Views/Drink/List.cshtml")]
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
#line 1 "/home/goli/Desktop/code/demo/E-Commers3.1/demo/Views/_ViewImports.cshtml"
using demo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/goli/Desktop/code/demo/E-Commers3.1/demo/Views/_ViewImports.cshtml"
using demo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/goli/Desktop/code/demo/E-Commers3.1/demo/Views/_ViewImports.cshtml"
using demo.Models.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/goli/Desktop/code/demo/E-Commers3.1/demo/Views/_ViewImports.cshtml"
using demo.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/goli/Desktop/code/demo/E-Commers3.1/demo/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/goli/Desktop/code/demo/E-Commers3.1/demo/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a57347d830c71532b164cbb0205eb36a4d520df", @"/Views/Drink/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d13171b0cd35be8bed3f90b17010b415e0e9cf7c", @"/Views/_ViewImports.cshtml")]
    public class Views_Drink_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DrinkListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/home/goli/Desktop/code/demo/E-Commers3.1/demo/Views/Drink/List.cshtml"
  
    ViewData["Title"]="List";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div>\n    <h2>All Drink are shown here</h2>\n</div>\n<h2>");
#nullable restore
#line 10 "/home/goli/Desktop/code/demo/E-Commers3.1/demo/Views/Drink/List.cshtml"
Write(Model.CurrentCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n");
#nullable restore
#line 11 "/home/goli/Desktop/code/demo/E-Commers3.1/demo/Views/Drink/List.cshtml"
  
    foreach(var drink in Model.Drinks)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/home/goli/Desktop/code/demo/E-Commers3.1/demo/Views/Drink/List.cshtml"
   Write(await Html.PartialAsync("DrinkSummary", drink));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/home/goli/Desktop/code/demo/E-Commers3.1/demo/Views/Drink/List.cshtml"
                                                       ;
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DrinkListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
