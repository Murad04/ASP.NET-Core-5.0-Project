#pragma checksum "C:\Users\DELL\source\repos\WebApplication7\WebApplication7\Areas\Admin\Views\AdminRole\UserRoleList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f387aa44cc193e19b3408afbf2a101a1b9a4ae0f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminRole_UserRoleList), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminRole/UserRoleList.cshtml")]
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
#line 1 "C:\Users\DELL\source\repos\WebApplication7\WebApplication7\Areas\Admin\Views\_ViewImports.cshtml"
using WebApplication7.Areas.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DELL\source\repos\WebApplication7\WebApplication7\Areas\Admin\Views\_ViewImports.cshtml"
using WebApplication7.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\DELL\source\repos\WebApplication7\WebApplication7\Areas\Admin\Views\AdminRole\UserRoleList.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f387aa44cc193e19b3408afbf2a101a1b9a4ae0f", @"/Areas/Admin/Views/AdminRole/UserRoleList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66070ce1040bfe5b12ba4ece085e0cab6da3d3c2", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AdminRole_UserRoleList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AppUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\DELL\source\repos\WebApplication7\WebApplication7\Areas\Admin\Views\AdminRole\UserRoleList.cshtml"
   
    ViewData["Title"] = "UserRoleList";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1> Kullanıcı rol list</h1>\r\n\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>Kullanıcı</th>\r\n        <th>Rol ata</th>\r\n    </tr>\r\n");
#nullable restore
#line 15 "C:\Users\DELL\source\repos\WebApplication7\WebApplication7\Areas\Admin\Views\AdminRole\UserRoleList.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 18 "C:\Users\DELL\source\repos\WebApplication7\WebApplication7\Areas\Admin\Views\AdminRole\UserRoleList.cshtml"
           Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 426, "\"", 469, 2);
            WriteAttributeValue("", 433, "/Admin/AdminRole/AssignRole/", 433, 28, true);
#nullable restore
#line 20 "C:\Users\DELL\source\repos\WebApplication7\WebApplication7\Areas\Admin\Views\AdminRole\UserRoleList.cshtml"
WriteAttributeValue("", 461, item.Id, 461, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Role ata</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 23 "C:\Users\DELL\source\repos\WebApplication7\WebApplication7\Areas\Admin\Views\AdminRole\UserRoleList.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n<a href=\"/Admin/AdminRole/Index/\" class=\"btn btn-outline-primary\">Role listesine geri dön</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AppUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
