#pragma checksum "C:\Users\Byolcu\source\repos\Core_Proje\Core_Proje\Views\Skill\EditSkill.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6225ecc5dc6592972bfe67edc8d02998835c937"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Skill_EditSkill), @"mvc.1.0.view", @"/Views/Skill/EditSkill.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6225ecc5dc6592972bfe67edc8d02998835c937", @"/Views/Skill/EditSkill.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3916d9c95bde3173996b91a771a7fba1f38cc4f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Skill_EditSkill : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Skill>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Byolcu\source\repos\Core_Proje\Core_Proje\Views\Skill\EditSkill.cshtml"
  
    ViewData["Title"] = "EditSkill";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card-header border-0\">\r\n    <h3 class=\"mb-0\">Yetenek Düzenleme</h3>\r\n</div>\r\n\r\n");
#nullable restore
#line 11 "C:\Users\Byolcu\source\repos\Core_Proje\Core_Proje\Views\Skill\EditSkill.cshtml"
 using(Html.BeginForm("EditSkill","Skill",FormMethod.Post))
{

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Byolcu\source\repos\Core_Proje\Core_Proje\Views\Skill\EditSkill.cshtml"
Write(Html.HiddenFor(x=> x.SkillID));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Byolcu\source\repos\Core_Proje\Core_Proje\Views\Skill\EditSkill.cshtml"
Write(Html.Label("Yetenek Başlığı"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Byolcu\source\repos\Core_Proje\Core_Proje\Views\Skill\EditSkill.cshtml"
Write(Html.TextBoxFor(x => x.Title,new{@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br>\r\n");
#nullable restore
#line 19 "C:\Users\Byolcu\source\repos\Core_Proje\Core_Proje\Views\Skill\EditSkill.cshtml"
Write(Html.Label("Değer"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Byolcu\source\repos\Core_Proje\Core_Proje\Views\Skill\EditSkill.cshtml"
Write(Html.TextBoxFor(x => x.Value,new{@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-primary\">Kaydet</button>\r\n");
#nullable restore
#line 23 "C:\Users\Byolcu\source\repos\Core_Proje\Core_Proje\Views\Skill\EditSkill.cshtml"


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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Skill> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
