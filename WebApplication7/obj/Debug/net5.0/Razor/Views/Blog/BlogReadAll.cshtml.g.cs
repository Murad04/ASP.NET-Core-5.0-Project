#pragma checksum "C:\Users\DELL\source\repos\WebApplication7\WebApplication7\Views\Blog\BlogReadAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03f3a8c43b88873b60f10767d6b578b417538574"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_BlogReadAll), @"mvc.1.0.view", @"/Views/Blog/BlogReadAll.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03f3a8c43b88873b60f10767d6b578b417538574", @"/Views/Blog/BlogReadAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7dc31cafed32aad956e8e002afa406e7283b5ab", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_BlogReadAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Blog>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/CoreBlogTema-main/web/images/banner1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\DELL\source\repos\WebApplication7\WebApplication7\Views\Blog\BlogReadAll.cshtml"
  
    ViewData["Title"] = "BlogReadAll";
    Layout = "~/Views/Shared/UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<!DOCTYPE html>\r\n<html lang=\"zxx\">\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03f3a8c43b88873b60f10767d6b578b4175385744692", async() => {
                WriteLiteral(@"

    <!--//banner-->
    <section class=""banner-bottom"">
        <!--/blog-->
        <div class=""container"">
            <div class=""row"">
                <!--left-->
                <div class=""col-lg-8 left-blog-info-w3layouts-agileits text-left"">
");
#nullable restore
#line 22 "C:\Users\DELL\source\repos\WebApplication7\WebApplication7\Views\Blog\BlogReadAll.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"blog-grid-top\">\r\n                            <div class=\"b-grid-top\">\r\n                                <div class=\"blog_info_left_grid\">\r\n                                    <a");
                BeginWriteAttribute("href", " href=\"", 733, "\"", 771, 3);
                WriteAttributeValue("", 740, "/Blog/BlogReadAll/", 740, 18, true);
#nullable restore
#line 27 "C:\Users\DELL\source\repos\WebApplication7\WebApplication7\Views\Blog\BlogReadAll.cshtml"
WriteAttributeValue("", 758, item.BlogID, 758, 12, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 770, "/", 770, 1, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                        <img");
                BeginWriteAttribute("src", " src=\"", 819, "\"", 840, 1);
#nullable restore
#line 28 "C:\Users\DELL\source\repos\WebApplication7\WebApplication7\Views\Blog\BlogReadAll.cshtml"
WriteAttributeValue("", 825, item.BlogImage, 825, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"img-fluid\"");
                BeginWriteAttribute("alt", " alt=\"", 859, "\"", 865, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                    </a>
                                </div>
                                <div class=""blog-info-middle"">
                                    <ul>
                                        <li>
                                            <a href=""#"">
                                                <i class=""far fa-calendar-alt""></i>");
#nullable restore
#line 35 "C:\Users\DELL\source\repos\WebApplication7\WebApplication7\Views\Blog\BlogReadAll.cshtml"
                                                                               Write(((DateTime)item.BlogDate).ToString("dd.MMM.yy"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                            </a>
                                        </li>
                                        <li class=""mx-2"">
                                            <a href=""#"">
                                                <i class=""far fa-thumbs-up"" id=""like""></i> ");
#nullable restore
#line 40 "C:\Users\DELL\source\repos\WebApplication7\WebApplication7\Views\Blog\BlogReadAll.cshtml"
                                                                                      Write(ViewBag.bloglike);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" Likes
                                            </a>
                                        </li>
                                        <li>
                                            <a href=""#"">
                                                <i class=""far fa-comment""></i> ");
#nullable restore
#line 45 "C:\Users\DELL\source\repos\WebApplication7\WebApplication7\Views\Blog\BlogReadAll.cshtml"
                                                                          Write(ViewBag.commentc);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" Comments
                                            </a>
                                        </li>

                                    </ul>
                                </div>
                            </div>

                            <h3>
                                <a href=""single.html"">");
#nullable restore
#line 54 "C:\Users\DELL\source\repos\WebApplication7\WebApplication7\Views\Blog\BlogReadAll.cshtml"
                                                 Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </a>\r\n                            </h3>\r\n                            <p>\r\n                                ");
#nullable restore
#line 57 "C:\Users\DELL\source\repos\WebApplication7\WebApplication7\Views\Blog\BlogReadAll.cshtml"
                           Write(item.BlogContent);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </p>\r\n                            <a href=\"/Blog/Index/\" class=\"btn btn-primary read-m\">Bloglar</a>\r\n                        </div>\r\n");
#nullable restore
#line 61 "C:\Users\DELL\source\repos\WebApplication7\WebApplication7\Views\Blog\BlogReadAll.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
#nullable restore
#line 62 "C:\Users\DELL\source\repos\WebApplication7\WebApplication7\Views\Blog\BlogReadAll.cshtml"
               Write(await Component.InvokeAsync("CommentListByBlog", new { id = ViewBag.i }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral("                    ");
#nullable restore
#line 64 "C:\Users\DELL\source\repos\WebApplication7\WebApplication7\Views\Blog\BlogReadAll.cshtml"
               Write(await Html.PartialAsync("~/Views/Comment/PartialAddComment.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                </div>

                <!--//left-->
                <!--right-->
                <aside class=""col-lg-4 agileits-w3ls-right-blog-con text-right"">
                    <div class=""right-blog-info text-left"">
                        <div class=""tech-btm"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "03f3a8c43b88873b60f10767d6b578b41753857411172", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
                WriteLiteral("                        </div>\r\n                        ");
#nullable restore
#line 76 "C:\Users\DELL\source\repos\WebApplication7\WebApplication7\Views\Blog\BlogReadAll.cshtml"
                   Write(await Component.InvokeAsync("WriterLastBlog", new { writerid = ViewBag.i }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <h4>Mail bultenine abone olunn</h4>\r\n\r\n                        ");
#nullable restore
#line 79 "C:\Users\DELL\source\repos\WebApplication7\WebApplication7\Views\Blog\BlogReadAll.cshtml"
                   Write(await Html.PartialAsync("~/Views/NewsLetter/SubscribeMail.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                        <div class=""single-gd my-5 tech-btm"">
                            <h4>Blog ve comment say??</h4>
                            <div class=""progress"">
                                <div class=""progress-bar progress-bar-striped"" role=""progressbar"" style=""width: 10%""");
                BeginWriteAttribute("aria-valuenow", " aria-valuenow=\"", 3896, "\"", 3930, 1);
#nullable restore
#line 84 "C:\Users\DELL\source\repos\WebApplication7\WebApplication7\Views\Blog\BlogReadAll.cshtml"
WriteAttributeValue("", 3912, ViewBag.countblog, 3912, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" aria-valuemin=""0""
                                     aria-valuemax=""100""></div>
                            </div>
                            <div class=""progress"">
                                <div class=""progress-bar progress-bar-striped bg-success"" role=""progressbar"" style=""width: 25%""");
                BeginWriteAttribute("aria-valuenow", " aria-valuenow=\"", 4231, "\"", 4268, 1);
#nullable restore
#line 88 "C:\Users\DELL\source\repos\WebApplication7\WebApplication7\Views\Blog\BlogReadAll.cshtml"
WriteAttributeValue("", 4247, ViewBag.commentcount, 4247, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" aria-valuemin=""0""
                                     aria-valuemax=""100""></div>
                            </div>
                        </div>
                    </div>

                </aside>
                <!--//right-->
            </div>
        </div>
    </section>
    <!--//main-->
    
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
