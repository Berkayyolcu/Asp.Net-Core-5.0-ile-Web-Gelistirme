#pragma checksum "C:\Users\Byolcu\source\repos\Core_Proje\Core_Proje\Views\Feature\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c1694648c98150d9070524650fbebd4d79ee2fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Feature_Index), @"mvc.1.0.view", @"/Views/Feature/Index.cshtml")]
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
#line 1 "C:\Users\Byolcu\source\repos\Core_Proje\Core_Proje\Views\Feature\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c1694648c98150d9070524650fbebd4d79ee2fa", @"/Views/Feature/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3916d9c95bde3173996b91a771a7fba1f38cc4f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Feature_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Feature>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Byolcu\source\repos\Core_Proje\Core_Proje\Views\Feature\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""col-lg-12 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title"">Öne Çıkan Yazı</h4>

            <div class=""table-responsive"">
                <table class=""table"">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>Header</th>
                            <th>Name</th>
                            <th>Baslık</th>
                            <th>Sil</th>
                            <th>Düzenle</th>
                        </tr>
                    </thead>
");
#nullable restore
#line 26 "C:\Users\Byolcu\source\repos\Core_Proje\Core_Proje\Views\Feature\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tbody>\r\n\r\n                            <tr>\r\n                                <td>");
#nullable restore
#line 31 "C:\Users\Byolcu\source\repos\Core_Proje\Core_Proje\Views\Feature\Index.cshtml"
                               Write(item.FeatureID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 32 "C:\Users\Byolcu\source\repos\Core_Proje\Core_Proje\Views\Feature\Index.cshtml"
                               Write(item.Header);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 33 "C:\Users\Byolcu\source\repos\Core_Proje\Core_Proje\Views\Feature\Index.cshtml"
                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 34 "C:\Users\Byolcu\source\repos\Core_Proje\Core_Proje\Views\Feature\Index.cshtml"
                               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1182, "\"", 1227, 2);
            WriteAttributeValue("", 1189, "/Feature/DeleteFeature/", 1189, 23, true);
#nullable restore
#line 36 "C:\Users\Byolcu\source\repos\Core_Proje\Core_Proje\Views\Feature\Index.cshtml"
WriteAttributeValue("", 1212, item.FeatureID, 1212, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1312, "\"", 1355, 2);
            WriteAttributeValue("", 1319, "/Feature/EditFeature/", 1319, 21, true);
#nullable restore
#line 37 "C:\Users\Byolcu\source\repos\Core_Proje\Core_Proje\Views\Feature\Index.cshtml"
WriteAttributeValue("", 1340, item.FeatureID, 1340, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Güncelle</a></td>\r\n                            </tr>\r\n\r\n                        </tbody>\r\n");
#nullable restore
#line 41 "C:\Users\Byolcu\source\repos\Core_Proje\Core_Proje\Views\Feature\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </table>\r\n                <a href=\"/Feature/AddFeature/\" class=\"btn btn-outline-primary\">Öne Çıkan Yazı Ekle</a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Feature>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591