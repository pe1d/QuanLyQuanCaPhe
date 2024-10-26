#pragma checksum "D:\Study\HocKyI-Nam2024-2025\CNPM\BTL\Code\QuanLyQuanCaPhe\Views\HoaDon\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec11103709e31dbb90246ae196b96b8ee72d63b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HoaDon_Index), @"mvc.1.0.view", @"/Views/HoaDon/Index.cshtml")]
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
#line 1 "D:\Study\HocKyI-Nam2024-2025\CNPM\BTL\Code\QuanLyQuanCaPhe\Views\_ViewImports.cshtml"
using QuanLyQuanCaPhe;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Study\HocKyI-Nam2024-2025\CNPM\BTL\Code\QuanLyQuanCaPhe\Views\_ViewImports.cshtml"
using QuanLyQuanCaPhe.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec11103709e31dbb90246ae196b96b8ee72d63b0", @"/Views/HoaDon/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6528bac52cd6a8f762b50b6e030a87311dc193f4", @"/Views/_ViewImports.cshtml")]
    public class Views_HoaDon_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<QuanLyQuanCaPhe.Models.HoaDonModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h2>Danh Sách Hóa Đơn</h2>

<table class=""table"">
    <thead>
        <tr>
            <th>Mã Hóa Đơn</th>
            <th>Tên khách hàng</th>
            <th>Ngày Xuất Hóa Đơn</th>
            <th>Tổng Tiền</th>
            <th>Hành Động</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 16 "D:\Study\HocKyI-Nam2024-2025\CNPM\BTL\Code\QuanLyQuanCaPhe\Views\HoaDon\Index.cshtml"
         foreach (var hoaDon in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 19 "D:\Study\HocKyI-Nam2024-2025\CNPM\BTL\Code\QuanLyQuanCaPhe\Views\HoaDon\Index.cshtml"
               Write(hoaDon.PK_sMaHD);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 20 "D:\Study\HocKyI-Nam2024-2025\CNPM\BTL\Code\QuanLyQuanCaPhe\Views\HoaDon\Index.cshtml"
                     foreach (var kh in ViewBag.KhachHang)
                    {
                        if (kh.PK_sMaKH == hoaDon.FK_sMaKH)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\Study\HocKyI-Nam2024-2025\CNPM\BTL\Code\QuanLyQuanCaPhe\Views\HoaDon\Index.cshtml"
                       Write(kh.sTenKH);

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\Study\HocKyI-Nam2024-2025\CNPM\BTL\Code\QuanLyQuanCaPhe\Views\HoaDon\Index.cshtml"
                                      
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>");
#nullable restore
#line 29 "D:\Study\HocKyI-Nam2024-2025\CNPM\BTL\Code\QuanLyQuanCaPhe\Views\HoaDon\Index.cshtml"
               Write(hoaDon.dNgayXuatHD.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "D:\Study\HocKyI-Nam2024-2025\CNPM\BTL\Code\QuanLyQuanCaPhe\Views\HoaDon\Index.cshtml"
               Write(hoaDon.fTongTien.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec11103709e31dbb90246ae196b96b8ee72d63b06151", async() => {
                WriteLiteral("Chi tiết");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "D:\Study\HocKyI-Nam2024-2025\CNPM\BTL\Code\QuanLyQuanCaPhe\Views\HoaDon\Index.cshtml"
                                             WriteLiteral(hoaDon.PK_sMaHD);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 35 "D:\Study\HocKyI-Nam2024-2025\CNPM\BTL\Code\QuanLyQuanCaPhe\Views\HoaDon\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<QuanLyQuanCaPhe.Models.HoaDonModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591