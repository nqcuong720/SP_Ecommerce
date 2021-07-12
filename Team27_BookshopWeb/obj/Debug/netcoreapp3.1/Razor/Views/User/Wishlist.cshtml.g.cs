#pragma checksum "F:\Code\SP_Ecommerce\Team27_BookshopWeb\Views\User\Wishlist.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4231992fd7870677513ee270ba3d8daed4a7f181"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Wishlist), @"mvc.1.0.view", @"/Views/User/Wishlist.cshtml")]
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
#line 1 "F:\Code\SP_Ecommerce\Team27_BookshopWeb\Views\_ViewImports.cshtml"
using Team27_BookshopWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Code\SP_Ecommerce\Team27_BookshopWeb\Views\_ViewImports.cshtml"
using Team27_BookshopWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4231992fd7870677513ee270ba3d8daed4a7f181", @"/Views/User/Wishlist.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b095e99e3dd484b538f8cd4863877373ad092328", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Wishlist : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Team27_BookshopWeb.Entities.Wishlist>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\Code\SP_Ecommerce\Team27_BookshopWeb\Views\User\Wishlist.cshtml"
  
    ViewData["Title"] = "Danh sách yêu thích";
    Layout = "~/Views/Shared/_MyAccountLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h4>Danh sách yêu thích</h4>\r\n<div class=\"cart-table table-responsive wishlist\">\r\n");
#nullable restore
#line 9 "F:\Code\SP_Ecommerce\Team27_BookshopWeb\Views\User\Wishlist.cshtml"
     if (Model.Count() > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table"">
            <thead>
                <tr>
                    <th class=""pro-thumbnail"">Hình ảnh</th>
                    <th class=""pro-title"">Tên sách</th>
                    <th class=""pro-price"">Giá</th>
                    <th class=""pro-remove""></th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 21 "F:\Code\SP_Ecommerce\Team27_BookshopWeb\Views\User\Wishlist.cshtml"
                 foreach (var wishlist in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td class=\"pro-thumbnail\"><a");
            BeginWriteAttribute("href", " href=\"", 796, "\"", 828, 2);
            WriteAttributeValue("", 803, "/sach/", 803, 6, true);
#nullable restore
#line 24 "F:\Code\SP_Ecommerce\Team27_BookshopWeb\Views\User\Wishlist.cshtml"
WriteAttributeValue("", 809, wishlist.Book.Slug, 809, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4231992fd7870677513ee270ba3d8daed4a7f1814797", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 840, "~/Team27StaticFiles/images/books/", 840, 33, true);
#nullable restore
#line 24 "F:\Code\SP_Ecommerce\Team27_BookshopWeb\Views\User\Wishlist.cshtml"
AddHtmlAttributeValue("", 873, wishlist.Book.PrimaryImage, 873, 27, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 24 "F:\Code\SP_Ecommerce\Team27_BookshopWeb\Views\User\Wishlist.cshtml"
AddHtmlAttributeValue("", 907, wishlist.Book.DisplayName, 907, 26, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a></td>\r\n                        <td class=\"pro-title\"><a");
            BeginWriteAttribute("href", " href=\"", 994, "\"", 1026, 2);
            WriteAttributeValue("", 1001, "/sach/", 1001, 6, true);
#nullable restore
#line 25 "F:\Code\SP_Ecommerce\Team27_BookshopWeb\Views\User\Wishlist.cshtml"
WriteAttributeValue("", 1007, wishlist.Book.Slug, 1007, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 25 "F:\Code\SP_Ecommerce\Team27_BookshopWeb\Views\User\Wishlist.cshtml"
                                                                             Write(wishlist.Book.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                        <td class=\"pro-price\"><span>");
#nullable restore
#line 26 "F:\Code\SP_Ecommerce\Team27_BookshopWeb\Views\User\Wishlist.cshtml"
                                               Write(wishlist.Book.DisplayPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n                        <td class=\"pro-remove\">\r\n                            <button data-proid=\"");
#nullable restore
#line 28 "F:\Code\SP_Ecommerce\Team27_BookshopWeb\Views\User\Wishlist.cshtml"
                                           Write(wishlist.Book.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"yeuthich_remove\"><i class=\"far fa-trash-alt\"></i></button>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 31 "F:\Code\SP_Ecommerce\Team27_BookshopWeb\Views\User\Wishlist.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 34 "F:\Code\SP_Ecommerce\Team27_BookshopWeb\Views\User\Wishlist.cshtml"

    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Bạn chưa thêm sách yêu thích nào</p>\r\n");
#nullable restore
#line 39 "F:\Code\SP_Ecommerce\Team27_BookshopWeb\Views\User\Wishlist.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Team27_BookshopWeb.Entities.Wishlist>> Html { get; private set; }
    }
}
#pragma warning restore 1591
