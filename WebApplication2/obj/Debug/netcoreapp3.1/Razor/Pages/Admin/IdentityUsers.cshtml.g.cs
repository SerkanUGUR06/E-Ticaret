#pragma checksum "C:\Users\serkan\Desktop\Web Programlama  Final Ödevi - 172119010 - 172119015\Web Programalama Proje\WebApplication2\Pages\Admin\IdentityUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64602fccadce9267c79fedfff5c7bfdb3d2b518a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebApplication2.Pages.Admin.Pages_Admin_IdentityUsers), @"mvc.1.0.razor-page", @"/Pages/Admin/IdentityUsers.cshtml")]
namespace WebApplication2.Pages.Admin
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
#line 2 "C:\Users\serkan\Desktop\Web Programlama  Final Ödevi - 172119010 - 172119015\Web Programalama Proje\WebApplication2\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.RazorPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\serkan\Desktop\Web Programlama  Final Ödevi - 172119010 - 172119015\Web Programalama Proje\WebApplication2\Pages\_ViewImports.cshtml"
using WebApplication2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\serkan\Desktop\Web Programlama  Final Ödevi - 172119010 - 172119015\Web Programalama Proje\WebApplication2\Pages\_ViewImports.cshtml"
using WebApplication2.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\serkan\Desktop\Web Programlama  Final Ödevi - 172119010 - 172119015\Web Programalama Proje\WebApplication2\Pages\Admin\IdentityUsers.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\serkan\Desktop\Web Programlama  Final Ödevi - 172119010 - 172119015\Web Programalama Proje\WebApplication2\Pages\Admin\IdentityUsers.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64602fccadce9267c79fedfff5c7bfdb3d2b518a", @"/Pages/Admin/IdentityUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a739a780c3fd06bfb9d9cd45dd0f9f726d1e56b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_IdentityUsers : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h3 class=\"bg-primary text-white text-center p-2\">Yönetici</h3>\r\n<table class=\"table table-sm table-striped table-bordered\">\r\n    <tbody>\r\n        <tr><th>Kullanıcı</th><td>");
#nullable restore
#line 9 "C:\Users\serkan\Desktop\Web Programlama  Final Ödevi - 172119010 - 172119015\Web Programalama Proje\WebApplication2\Pages\Admin\IdentityUsers.cshtml"
                             Write(Model.AdminUser.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n        <tr><th>Email</th><td>");
#nullable restore
#line 10 "C:\Users\serkan\Desktop\Web Programlama  Final Ödevi - 172119010 - 172119015\Web Programalama Proje\WebApplication2\Pages\Admin\IdentityUsers.cshtml"
                         Write(Model.AdminUser.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n        <tr><th>Telefon Numarası</th><td>");
#nullable restore
#line 11 "C:\Users\serkan\Desktop\Web Programlama  Final Ödevi - 172119010 - 172119015\Web Programalama Proje\WebApplication2\Pages\Admin\IdentityUsers.cshtml"
                                    Write(Model.AdminUser.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n    </tbody>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "C:\Users\serkan\Desktop\Web Programlama  Final Ödevi - 172119010 - 172119015\Web Programalama Proje\WebApplication2\Pages\Admin\IdentityUsers.cshtml"
           
    [Authorize]
    public class IdentityUsersModel : PageModel
    {
        private UserManager<IdentityUser> userManager;
        public IdentityUsersModel(UserManager<IdentityUser> mgr)
        {
            userManager = mgr;
        }
        public IdentityUser AdminUser { get; set; }
        public async Task OnGetAsync()
        {
            AdminUser = await userManager.FindByNameAsync("Admin");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IdentityUsersModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IdentityUsersModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IdentityUsersModel>)PageContext?.ViewData;
        public IdentityUsersModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591