#pragma checksum "C:\Users\Ameur\Desktop\kraya\asp.net\Protection_civile\Areas\Identity\Pages\AuthLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67841c93881574be605c2427d466f2a3b833da76"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_AuthLayout), @"mvc.1.0.view", @"/Areas/Identity/Pages/AuthLayout.cshtml")]
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
#line 1 "C:\Users\Ameur\Desktop\kraya\asp.net\Protection_civile\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ameur\Desktop\kraya\asp.net\Protection_civile\Areas\Identity\Pages\_ViewImports.cshtml"
using Protection_civile.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ameur\Desktop\kraya\asp.net\Protection_civile\Areas\Identity\Pages\_ViewImports.cshtml"
using Protection_civile.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ameur\Desktop\kraya\asp.net\Protection_civile\Areas\Identity\Pages\_ViewImports.cshtml"
using Protection_civile.Areas.Identity.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67841c93881574be605c2427d466f2a3b833da76", @"/Areas/Identity/Pages/AuthLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53a997efac23f355f37f8b34d4061c113044e3d2", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_AuthLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Ameur\Desktop\kraya\asp.net\Protection_civile\Areas\Identity\Pages\AuthLayout.cshtml"
  

    Layout = "~/Views/shared/_Layout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div style=""direction: initial !important; margin: 40px; "">



<div class=""row"">
    <div class=""col-md-6 offset-md-3"">
        <div class=""card login-logout-tab"">
            <div class=""card-header"">
                <ul class=""nav nav-tabs card-header-tabs nav-justified"">
                    <li class=""nav-item"">
                        <a class=""nav-link"" href='/Identity/Account/Login'>تسجيل الدخول</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href='/Identity/Account/Register'> احداث حساب</a>
                    </li>
                </ul>


            </div>
            <div class=""card-content nav-justified"" style=""padding: 20px;"">
                <div class=""row"">
                    <div class=""col-md-12"">
                        ");
#nullable restore
#line 28 "C:\Users\Ameur\Desktop\kraya\asp.net\Protection_civile\Areas\Identity\Pages\AuthLayout.cshtml"
                   Write(RenderBody());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    </div>\r\n\r\n\r\n\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 42 "C:\Users\Ameur\Desktop\kraya\asp.net\Protection_civile\Areas\Identity\Pages\AuthLayout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

    <script>
        $(function () {
            var current = location.pathname;
            $('.nav-tabs li a').each(function () {
                var $this = $(this);
                if (current.indexOf($this.attr('href')) !== -1) {
                    $this.addClass('active');
                }
            })
        })
    </script>
");
            }
            );
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
