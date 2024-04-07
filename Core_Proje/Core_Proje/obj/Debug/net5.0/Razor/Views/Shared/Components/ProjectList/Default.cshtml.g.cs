#pragma checksum "C:\Users\Byolcu\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\ProjectList\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "cc1c49d336a7451e68c2e81937d2fcd4a81848042ec4c6f663d6e833e11ffb0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ProjectList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ProjectList/Default.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Byolcu\source\repos\Core_Proje\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Byolcu\source\repos\Core_Proje\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Byolcu\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\ProjectList\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"cc1c49d336a7451e68c2e81937d2fcd4a81848042ec4c6f663d6e833e11ffb0b", @"/Views/Shared/Components/ProjectList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"6ce2767b5e9aacf9218c5ea7d9b3dff0f71adde816b8961150960e416b571dcd", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_ProjectList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Portfolio>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<div class=""row "">
    <div class=""col-12 grid-margin"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title""> Proje Listesi </h4>
                <div class=""table-responsive"">
                    <table class=""table"">
                        <thead>
                            <tr>
                                <th> # </th>
                                <th> Görsel </th>
                                <th> Proje Adı </th>
                                <th> Url </th>
                                <th> Fiyat </th>
                                <th> Tamamlanma Oranı </th>
                                <th> Durum </th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 24 "C:\Users\Byolcu\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\ProjectList\Default.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td> ");
#nullable restore
#line 27 "C:\Users\Byolcu\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\ProjectList\Default.cshtml"
                                    Write(item.PortfolioID);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                    <td> <img");
            BeginWriteAttribute("src", " src=\"", 1099, "\"", 1119, 1);
#nullable restore
#line 28 "C:\Users\Byolcu\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\ProjectList\Default.cshtml"
WriteAttributeValue("", 1105, item.ImageUrl, 1105, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /> </td>\r\n                                    <td> ");
#nullable restore
#line 29 "C:\Users\Byolcu\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\ProjectList\Default.cshtml"
                                    Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                    <td> ");
#nullable restore
#line 30 "C:\Users\Byolcu\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\ProjectList\Default.cshtml"
                                    Write(item.ProjeUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </td>\r\n                                    <td> ");
#nullable restore
#line 31 "C:\Users\Byolcu\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\ProjectList\Default.cshtml"
                                    Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </td>\r\n                                    <td> ");
#nullable restore
#line 32 "C:\Users\Byolcu\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\ProjectList\Default.cshtml"
                                    Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </td>\r\n                                    <td><a");
            BeginWriteAttribute("href", " href=\"", 1418, "\"", 1468, 3);
            WriteAttributeValue("", 1425, "/Portfolio/EditPortfolio/", 1425, 25, true);
#nullable restore
#line 33 "C:\Users\Byolcu\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\ProjectList\Default.cshtml"
WriteAttributeValue("", 1450, item.PortfolioID, 1450, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1467, "/", 1467, 1, true);
            EndWriteAttribute();
            WriteLiteral("> <div class=\"badge badge-outline-success\"> Detayları Gör  </div></a>  </td>\r\n\r\n                                </tr>\r\n");
#nullable restore
#line 36 "C:\Users\Byolcu\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\ProjectList\Default.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Portfolio>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591