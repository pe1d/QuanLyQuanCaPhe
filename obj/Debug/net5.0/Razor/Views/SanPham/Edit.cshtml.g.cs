#pragma checksum "D:\Study\HocKyI-Nam2024-2025\CNPM\BTL\Code\QuanLyQuanCaPhe\Views\SanPham\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20ceb4478b93716e68c9ecb48aa2be0b3b17b28d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SanPham_Edit), @"mvc.1.0.view", @"/Views/SanPham/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20ceb4478b93716e68c9ecb48aa2be0b3b17b28d", @"/Views/SanPham/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6528bac52cd6a8f762b50b6e030a87311dc193f4", @"/Views/_ViewImports.cshtml")]
    public class Views_SanPham_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QuanLyQuanCaPhe.Models.SanPhamModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("FK_sMaNCC"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("FK_sMaLSP"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("editProductForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>Chỉnh Sửa Sản Phẩm</h2>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20ceb4478b93716e68c9ecb48aa2be0b3b17b28d5983", async() => {
                WriteLiteral("\r\n    <input type=\"hidden\" id=\"PK_sMaSP\"");
                BeginWriteAttribute("value", " value=\"", 172, "\"", 195, 1);
#nullable restore
#line 5 "D:\Study\HocKyI-Nam2024-2025\CNPM\BTL\Code\QuanLyQuanCaPhe\Views\SanPham\Edit.cshtml"
WriteAttributeValue("", 180, Model.PK_sMaSP, 180, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n    <div class=\"form-group\">\r\n        <label for=\"sTenSP\">Tên sản phẩm</label>\r\n        <input type=\"text\" id=\"sTenSP\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 342, "\"", 363, 1);
#nullable restore
#line 9 "D:\Study\HocKyI-Nam2024-2025\CNPM\BTL\Code\QuanLyQuanCaPhe\Views\SanPham\Edit.cshtml"
WriteAttributeValue("", 350, Model.sTenSP, 350, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        <label for=\"FK_sMaNCC\">Nhà cung cấp</label>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20ceb4478b93716e68c9ecb48aa2be0b3b17b28d7329", async() => {
                    WriteLiteral("\r\n        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 15 "D:\Study\HocKyI-Nam2024-2025\CNPM\BTL\Code\QuanLyQuanCaPhe\Views\SanPham\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = (new SelectList(ViewBag.NhaCungCap, "PK_sMaNCC", "sTenNCC"));

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        <label for=\"FK_sMaLSP\">Loại sản phẩm</label>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20ceb4478b93716e68c9ecb48aa2be0b3b17b28d9158", async() => {
                    WriteLiteral("\r\n        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 22 "D:\Study\HocKyI-Nam2024-2025\CNPM\BTL\Code\QuanLyQuanCaPhe\Views\SanPham\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = (new SelectList(ViewBag.LoaiSanPham, "PK_sMaLSP", "sTenLoaiSanPham"));

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        <label for=\"iSoLuong\">Số lượng</label>\r\n        <input type=\"number\" id=\"iSoLuong\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 1048, "\"", 1071, 1);
#nullable restore
#line 28 "D:\Study\HocKyI-Nam2024-2025\CNPM\BTL\Code\QuanLyQuanCaPhe\Views\SanPham\Edit.cshtml"
WriteAttributeValue("", 1056, Model.iSoLuong, 1056, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
    </div>

    <div class=""form-group"">
        <label for=""sIMG"">Hình ảnh</label>
        <input type=""file"" name=""imageFile"" accept=""image/*"" onchange=""previewImage(event)"">
        <div>
            <img id=""imagePreview"" src=""#"" alt=""Chọn ảnh"" style=""max-width: 200px; display: none;"" />
        </div>
        <input type=""text"" id=""sIMG"" class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 1450, "\"", 1469, 1);
#nullable restore
#line 37 "D:\Study\HocKyI-Nam2024-2025\CNPM\BTL\Code\QuanLyQuanCaPhe\Views\SanPham\Edit.cshtml"
WriteAttributeValue("", 1458, Model.sIMG, 1458, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" hidden />\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label for=\"fGiaSP\">Giá sản phẩm</label>\r\n        <input type=\"number\" id=\"fGiaSP\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 1635, "\"", 1656, 1);
#nullable restore
#line 41 "D:\Study\HocKyI-Nam2024-2025\CNPM\BTL\Code\QuanLyQuanCaPhe\Views\SanPham\Edit.cshtml"
WriteAttributeValue("", 1643, Model.fGiaSP, 1643, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    </div>\r\n\r\n    <button type=\"button\" class=\"btn btn-primary\" onclick=\"editProduct()\">Lưu thay đổi</button>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20ceb4478b93716e68c9ecb48aa2be0b3b17b28d12922", async() => {
                    WriteLiteral("Quay lại");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<script>
    async function editProduct() {
        var formData = new FormData();
        const product = {
            PK_sMaSP: document.getElementById('PK_sMaSP').value,
            sTenSP: document.getElementById('sTenSP').value,
            FK_sMaNCC: document.getElementById('FK_sMaNCC').value,
            FK_sMaLSP: document.getElementById('FK_sMaLSP').value,
            iSoLuong: parseInt(document.getElementById('iSoLuong').value),
            sIMG: document.getElementById('sIMG').value,
            fGiaSP: parseFloat(document.getElementById('fGiaSP').value)
        };
        formData.append('product', JSON.stringify(product));
        var imageFile = document.querySelector('input[type=""file""]').files[0];
        if (imageFile) {
            formData.append('imageFile', imageFile); // Thêm file vào FormData
        }
        console.log('Form data: ', formData);
        try {
            const response = await fetch('/SanPham/Edit', {
                method: 'POST',
         ");
            WriteLiteral(@"       body: formData
            });

            const data = await response.json();
            if (data.success) {
                alert('Product updated successfully');
                window.location.href = '/SanPham/Index';
            } else {
                alert('Error updating product: ' + data.message);
            }
        } catch (error) {
            console.error('Error:', error);
            alert('An error occurred while updating the product.');
        }
    }
    function previewImage(event) {
        var imagePreview = document.getElementById('imagePreview');
        var file = event.target.files[0]; // Lấy file từ input

        if (file) {
            var reader = new FileReader();

            // Đọc file dưới dạng URL
            reader.onload = function (e) {
                imagePreview.src = e.target.result; // Gán URL của ảnh vào thẻ <img>
                imagePreview.style.display = 'block'; // Hiển thị ảnh
            }

            reader.readAsDat");
            WriteLiteral("aURL(file); // Đọc file để hiển thị ảnh\r\n        } else {\r\n            imagePreview.src = \"#\";\r\n            imagePreview.style.display = \'none\'; // Ẩn nếu không có file\r\n        }\r\n    }\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuanLyQuanCaPhe.Models.SanPhamModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
