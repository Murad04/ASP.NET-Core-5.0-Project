#pragma checksum "C:\Users\DELL\source\repos\WebApplication7\WebApplication7\Views\Admin\AdminNavbarPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "795c1c2c421683d1ec3e2f17802b5ae192cac584"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_AdminNavbarPartial), @"mvc.1.0.view", @"/Views/Admin/AdminNavbarPartial.cshtml")]
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
#line 1 "C:\Users\DELL\source\repos\WebApplication7\WebApplication7\Views\_ViewImports.cshtml"
using WebApplication7;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DELL\source\repos\WebApplication7\WebApplication7\Views\_ViewImports.cshtml"
using WebApplication7.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"795c1c2c421683d1ec3e2f17802b5ae192cac584", @"/Views/Admin/AdminNavbarPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7dc31cafed32aad956e8e002afa406e7283b5ab", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_AdminNavbarPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<nav class=\"navbar-default navbar-static-side\" role=\"navigation\">\r\n    <div class=\"sidebar-collapse\">\r\n        <ul class=\"nav metismenu\" id=\"side-menu\">\r\n            ");
#nullable restore
#line 4 "C:\Users\DELL\source\repos\WebApplication7\WebApplication7\Views\Admin\AdminNavbarPartial.cshtml"
       Write(await Component.InvokeAsync("Adminname"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            <li>
                <a href=""/Admin/Widget/Index/""><i class=""fa fa-th-large""></i> <span class=""nav-label"">Dashboard</span>  </a>
            </li>
            <li>
                <a href=""/Admin/Chart/Index/""><i class=""fa fa-bar-chart-o""></i> <span class=""nav-label"">Grafikler</span>  </a>
            </li>
            <li>
                <a href=""mailbox.html""><i class=""fa fa-envelope""></i> Mesajlar</a>
                <ul class=""nav nav-second-level collapse"">
                    <li><a href=""/Admin/AdminMessage/Inbox/"">Gelenler</a></li>
                    <li><a href=""/Admin/AdminMessage/Sendbox/"">Gidenler</a></li>
                    <li><a href=""/Admin/AdminMessage/Compose"">Yeni mesaj yaz</a></li>
                </ul>
            </li>
            <li>
                <a href=""metrics.html""><i class=""fa fa-pie-chart""></i> <span class=""nav-label"">Metrikler</span>  </a>
            </li>
            <li>
                <a href=""/Admin/Category/Index/""><i class=""fa fa-gr");
            WriteLiteral(@"oup""></i> <span class=""nav-label"">Kategoriler</span>  </a>
            </li>
            <li>
                <a href=""/Admin/AdminBlog/Index/""><i class=""fa fa-list""></i> <span class=""nav-label"">Bloglar</span>  </a>
            </li>
            <li>
                <a href=""metrics.html""><i class=""fa fa-comment""></i> <span class=""nav-label"">Yorumlar</span>  </a>
            </li>
            <li>
                <a href=""/Admin/Writer/Index/""><i class=""fa fa-user""></i> <span class=""nav-label"">Yazarlar</span>  </a>
            </li>
            <li>
                <a href=""/Admin/Writer/Index/""><i class=""fa fa-user""></i> <span class=""nav-label"">Yazarlar</span>  </a>
            </li>
            <li>
                <a href=""/Admin/AdminProfile/Index/""><i class=""fa fa-info""></i> <span class=""nav-label"">Ayarlar</span>  </a>
            </li>
            <li>
                <a href=""/Admin/AdminRole/Index/""><i class=""fa fa-address-book""></i> <span class=""nav-label"">Roller</span>  </a>
     ");
            WriteLiteral(@"       </li>
            <li>
                <a href=""metrics.html""><i class=""fa fa-phone""></i> <span class=""nav-label"">Iletisim</span>  </a>
            </li>
            <li>
                <a href=""metrics.html""><i class=""fa fa-address-book""></i> <span class=""nav-label"">Hakkimizda</span>  </a>
            </li>
            <li>
                <a href=""/Admin/Blog/BlogListExcel/""><i class=""fa fa-flask""></i> <span class=""nav-label"">Statik Excel Rapor</span></a>
            </li>
            <li>
                <a href=""/Admin/Blog/BlogListExcel/""><i class=""fa fa-flask""></i> <span class=""nav-label"">Dinamik Excel Rapor</span></a>
            </li>
            <li>
                <a href=""/Login/LogOut/""><i class=""fa fa-close""></i> <span class=""nav-label"">cikis yap</span></a>
            </li>
        </ul>

    </div>
</nav>
");
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
