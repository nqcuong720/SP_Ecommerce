#pragma checksum "G:\Lưu Trữ\File nộp (File responses)\Team27_BookshopWeb\Team27_BookshopWeb\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4faf12f91c6093a738f7574513cabcc47f86999"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
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
#line 1 "G:\Lưu Trữ\File nộp (File responses)\Team27_BookshopWeb\Team27_BookshopWeb\Views\_ViewImports.cshtml"
using Team27_BookshopWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\Lưu Trữ\File nộp (File responses)\Team27_BookshopWeb\Team27_BookshopWeb\Views\_ViewImports.cshtml"
using Team27_BookshopWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4faf12f91c6093a738f7574513cabcc47f86999", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b095e99e3dd484b538f8cd4863877373ad092328", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Team27_BookshopWeb.Models.CartViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Team27StaticFiles/mycss/cart.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("checkout-btn c-btn btn--primary continue"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "G:\Lưu Trữ\File nộp (File responses)\Team27_BookshopWeb\Team27_BookshopWeb\Views\Cart\Index.cshtml"
  
    ViewBag.title = "Giỏ hàng";
    Layout = "~/Views/Shared/_Master.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("style", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e4faf12f91c6093a738f7574513cabcc47f869995740", async() => {
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
            }
            );
            WriteLiteral(@"
<section class=""breadcrumb-section"">
    <h2 class=""sr-only"">Site Breadcrumb</h2>
    <div class=""container"">
        <div class=""breadcrumb-contents"">
            <nav aria-label=""breadcrumb"">
                <ol class=""breadcrumb"">
                    <li class=""breadcrumb-item""><a href=""/"">Trang chủ</a></li>
                    <li class=""breadcrumb-item active"">Giỏ hàng</li>
                </ol>
            </nav>
        </div>
    </div>
</section>
<!-- Cart Page Start -->
<main class=""cart-page-main-block inner-page-sec-padding-bottom"">
    <div class=""cart_area cart-area-padding  "">
        <div class=""container"">
            <div class=""page-section-title"">
                <h1>Giỏ hàng</h1>
            </div>
            <div class=""row"">
                <div class=""col-12"">

                    <!-- Cart Table -->
                    <div class=""cart-table table-responsive mb--40"">
");
#nullable restore
#line 37 "G:\Lưu Trữ\File nộp (File responses)\Team27_BookshopWeb\Team27_BookshopWeb\Views\Cart\Index.cshtml"
                         if (Model.CartItems.Count() > 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <table class='table'>
                                <thead>
                                    <tr>
                                        <th class=""pro-select""></th>
                                        <th class=""pro-thumbnail"">Hình ảnh</th>
                                        <th class=""pro-title"">Tên sách</th>
                                        <th class=""pro-price"">Đơn giá</th>
                                        <th class=""pro-quantity"">Số lượng</th>
                                        <th class=""pro-subtotal"">Tổng tiền</th>
                                        <th class=""pro-remove""></th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 52 "G:\Lưu Trữ\File nộp (File responses)\Team27_BookshopWeb\Team27_BookshopWeb\Views\Cart\Index.cshtml"
                                     foreach (var item in Model.CartItems)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr");
            BeginWriteAttribute("id", " id=\"", 2218, "\"", 2235, 1);
#nullable restore
#line 54 "G:\Lưu Trữ\File nộp (File responses)\Team27_BookshopWeb\Team27_BookshopWeb\Views\Cart\Index.cshtml"
WriteAttributeValue("", 2223, item.BookId, 2223, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <td class=\"pro-select\">\r\n                                                <input title=\"Chọn sản phẩm để thanh toán\" type=\"checkbox\" class=\"cart-checkbox\" name=\"select\" ");
#nullable restore
#line 56 "G:\Lưu Trữ\File nộp (File responses)\Team27_BookshopWeb\Team27_BookshopWeb\Views\Cart\Index.cshtml"
                                                                                                                                           Write(item.IsSelected == 1 ? "checked" : string.Empty);

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                                            </td>\r\n                                            <td class=\"pro-thumbnail\"><a");
            BeginWriteAttribute("href", " href=\"", 2627, "\"", 2655, 2);
            WriteAttributeValue("", 2634, "/sach/", 2634, 6, true);
#nullable restore
#line 58 "G:\Lưu Trữ\File nộp (File responses)\Team27_BookshopWeb\Team27_BookshopWeb\Views\Cart\Index.cshtml"
WriteAttributeValue("", 2640, item.Book.Slug, 2640, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e4faf12f91c6093a738f7574513cabcc47f8699911103", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2667, "~/Team27StaticFiles/images/books/", 2667, 33, true);
#nullable restore
#line 58 "G:\Lưu Trữ\File nộp (File responses)\Team27_BookshopWeb\Team27_BookshopWeb\Views\Cart\Index.cshtml"
AddHtmlAttributeValue("", 2700, item.Book.PrimaryImage, 2700, 23, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 58 "G:\Lưu Trữ\File nộp (File responses)\Team27_BookshopWeb\Team27_BookshopWeb\Views\Cart\Index.cshtml"
AddHtmlAttributeValue("", 2730, item.Book.DisplayName, 2730, 22, false);

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
            WriteLiteral("</a></td>\r\n                                            <td class=\"pro-title\"><a");
            BeginWriteAttribute("href", " href=\"", 2833, "\"", 2861, 2);
            WriteAttributeValue("", 2840, "/sach/", 2840, 6, true);
#nullable restore
#line 59 "G:\Lưu Trữ\File nộp (File responses)\Team27_BookshopWeb\Team27_BookshopWeb\Views\Cart\Index.cshtml"
WriteAttributeValue("", 2846, item.Book.Slug, 2846, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 59 "G:\Lưu Trữ\File nộp (File responses)\Team27_BookshopWeb\Team27_BookshopWeb\Views\Cart\Index.cshtml"
                                                                                             Write(item.Book.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                                            <td class=\"pro-price\"><span>");
#nullable restore
#line 60 "G:\Lưu Trữ\File nộp (File responses)\Team27_BookshopWeb\Team27_BookshopWeb\Views\Cart\Index.cshtml"
                                                                   Write(item.Book.DisplayPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></td>
                                            <td class=""pro-quantity"">
                                                <div class=""pro-qty"">
                                                    <button class=""cart quantity up"" type=""button"" data-proid=""");
#nullable restore
#line 63 "G:\Lưu Trữ\File nộp (File responses)\Team27_BookshopWeb\Team27_BookshopWeb\Views\Cart\Index.cshtml"
                                                                                                          Write(item.BookId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><i class=\"fa fa-angle-up\"></i></button>\r\n                                                    <input type=\"number\" class=\"form-control text-center\"");
            BeginWriteAttribute("value", "\r\n                                                           value=\"", 3418, "\"", 3500, 1);
#nullable restore
#line 65 "G:\Lưu Trữ\File nộp (File responses)\Team27_BookshopWeb\Team27_BookshopWeb\Views\Cart\Index.cshtml"
WriteAttributeValue("", 3486, item.Quantity, 3486, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" readonly>\r\n                                                    <button class=\"cart quantity down\" type=\"button\" data-proid=\"");
#nullable restore
#line 66 "G:\Lưu Trữ\File nộp (File responses)\Team27_BookshopWeb\Team27_BookshopWeb\Views\Cart\Index.cshtml"
                                                                                                            Write(item.BookId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><i class=\"fa fa-angle-down\"></i></button>\r\n                                                </div>\r\n                                            </td>\r\n                                            <td class=\"pro-subtotal\"><span>");
#nullable restore
#line 69 "G:\Lưu Trữ\File nộp (File responses)\Team27_BookshopWeb\Team27_BookshopWeb\Views\Cart\Index.cshtml"
                                                                      Write(item.DisplayTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n                                            <td class=\"pro-remove\">\r\n                                                <button data-bookid=\"");
#nullable restore
#line 71 "G:\Lưu Trữ\File nộp (File responses)\Team27_BookshopWeb\Team27_BookshopWeb\Views\Cart\Index.cshtml"
                                                                Write(item.BookId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"cart_remove\"><i class=\"far fa-trash-alt\"></i></button>\r\n                                            </td>\r\n                                        </tr>\r\n");
#nullable restore
#line 74 "G:\Lưu Trữ\File nộp (File responses)\Team27_BookshopWeb\Team27_BookshopWeb\Views\Cart\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tbody>\r\n                            </table>\r\n");
#nullable restore
#line 77 "G:\Lưu Trữ\File nộp (File responses)\Team27_BookshopWeb\Team27_BookshopWeb\Views\Cart\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div>Giỏ hàng trống</div>\r\n");
#nullable restore
#line 81 "G:\Lưu Trữ\File nộp (File responses)\Team27_BookshopWeb\Team27_BookshopWeb\Views\Cart\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""cart-section-2"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-6 col-12 mb--30 mb-lg--0"">
                    <!-- slide Block 5 / Normal Slider -->
                    <div class=""cart-block-title"">
                        <h2>BẠN ĐỌC THƯỜNG MUA...</h2>
                    </div>
                    <div class=""product-slider sb-slick-slider considered-books"" data-slick-setting='{
							          ""autoplay"": true,
							          ""autoplaySpeed"": 3000,
							          ""slidesToShow"": 2
									  }' data-slick-responsive='[
                {""breakpoint"":992, ""settings"": {""slidesToShow"": 2} },
                {""breakpoint"":768, ""settings"": {""slidesToShow"": 3} },
                {""breakpoint"":575, ""settings"": {""slidesToShow"": 2} },
                {""breakpoint"":480, ""settings"": {""slidesToShow"": 1} },
                {""breakpoi");
            WriteLiteral("nt\":320, \"settings\": {\"slidesToShow\": 1} }\r\n            ]\'>\r\n                        <!--Sách được nhiều khách hàng mua-->\r\n");
#nullable restore
#line 107 "G:\Lưu Trữ\File nộp (File responses)\Team27_BookshopWeb\Team27_BookshopWeb\Views\Cart\Index.cshtml"
                         foreach (var book in Model.ConsideredBooks.Take(7))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <!--Gọi partial view hiển thị thông tin sách-->\r\n");
#nullable restore
#line 110 "G:\Lưu Trữ\File nộp (File responses)\Team27_BookshopWeb\Team27_BookshopWeb\Views\Cart\Index.cshtml"
                            Html.RenderPartial("_ProductCard", book);
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                </div>
                <!-- Cart Summary -->
                <div class=""col-lg-6 col-12 d-flex"">
                    <div class=""cart-summary"">
                        <div class=""cart-summary-wrap"">
                            <h4><span>Cart Summary</span></h4>
                            <p>Tạm tính <span class=""text-primary"" id=""subtotal"">");
#nullable restore
#line 119 "G:\Lưu Trữ\File nộp (File responses)\Team27_BookshopWeb\Team27_BookshopWeb\Views\Cart\Index.cshtml"
                                                                            Write(Model.DisplayTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n                        </div>\r\n                        <div class=\"cart-summary-button\">\r\n                            <a href=\"/thanh-toan\" class=\"checkout-btn c-btn btn--primary\">Thanh toán</a>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4faf12f91c6093a738f7574513cabcc47f8699921100", async() => {
                WriteLiteral("Tiếp tục mua hàng");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</main>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Team27_BookshopWeb.Models.CartViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
