#pragma checksum "C:\Users\DELL\source\repos\WebApplication7\WebApplication7\Areas\Admin\Views\AdminMessageMenu\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6c67086ddce0953c8b798b15d0b8ee010ef0e3d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminMessageMenu_Default), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminMessageMenu/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6c67086ddce0953c8b798b15d0b8ee010ef0e3d", @"/Areas/Admin/Views/AdminMessageMenu/Default.cshtml")]
    public class Areas_Admin_Views_AdminMessageMenu_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<div class=""col-lg-3"">
    <div class=""ibox "">
        <div class=""ibox-content mailbox-content"">
            <div class=""file-manager"">
                <a class=""btn btn-block btn-outline-primary compose-mail"" href=""/Admin/AdminMessage/Compose/"">Mesaj yaz</a>
                <div class=""space-25""></div>
                <h5>Dosyalar</h5>
                <ul class=""folder-list m-b-md"" style=""padding: 0"">
                    <li><a href=""/Admin/AdminMessage/Inbox/""> <i class=""fa fa-inbox ""></i> Gelen Mesajlar <span class=""label label-warning float-right""></span> </a></li>
                    <li><a href=""/Admin/AdminMessage/Sendbox/""> <i class=""fa fa-envelope-o""></i> Giden Mesajlar</a></li>
                    <li><a href=""/Admin/AdminMessage/ImportantMessage/""> <i class=""fa fa-certificate""></i>Önemli </a></li>
                    <li><a href=""#""> <i class=""fa fa-file-text-o""></i> Taslaklar <span class=""label label-danger float-right""></span></a></li>
                    <li><a href=""/Admin/Mess");
            WriteLiteral(@"age2TrashBin/Trash/""> <i class=""fa fa-trash-o""></i> Çöp kutusu</a></li>
                </ul>
                <h5>Kategoriler</h5>
                <ul class=""category-list"" style=""padding: 0"">
                    <li><a href=""/Admin/AdminMessage/WorkMessage/""> <i class=""fa fa-circle text-navy""></i> İş </a></li>
                    <li><a href=""/Admin/AdminMessage/DocumentMessage/""> <i class=""fa fa-circle text-danger""></i> Dökümanlar</a></li>
                    <li><a href=""/Admin/AdminMessage/PromotionMessage/""> <i class=""fa fa-circle text-info""></i> Tanıtımlar</a></li>
                    <li><a href=""/Admin/AdminMessage/DemandMessage/""> <i class=""fa fa-circle text-warning""></i> Talepler</a></li>
                </ul>
                <div class=""clearfix""></div>
            </div>
        </div>
    </div>
</div>
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
