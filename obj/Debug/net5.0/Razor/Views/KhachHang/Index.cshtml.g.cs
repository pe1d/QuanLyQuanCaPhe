#pragma checksum "D:\Study\HocKyI-Nam2024-2025\CNPM\BTL\Code\QuanLyQuanCaPhe\Views\KhachHang\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5e5dc4b93376ff8add1ae8f967ec2075f9c3c62"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_KhachHang_Index), @"mvc.1.0.view", @"/Views/KhachHang/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5e5dc4b93376ff8add1ae8f967ec2075f9c3c62", @"/Views/KhachHang/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6528bac52cd6a8f762b50b6e030a87311dc193f4", @"/Views/_ViewImports.cshtml")]
    public class Views_KhachHang_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<QuanLyQuanCaPhe.Models.KhachHangModel>>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2>----Thêm khách hàng-----</h2>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5e5dc4b93376ff8add1ae8f967ec2075f9c3c623337", async() => {
                WriteLiteral(@"
    <span class=""d-flex flex-row gap-3 "">
        <div class=""col-4"">
            <label for=""sTenKH"">Tên khách hàng</label>
            <input id=""sTenKH"" class=""form-control"" />
        </div>
        <div class=""col-3"">
            <label for=""sSDT"">Số điện thoại</label>
            <input id=""sSDT"" class=""form-control"" />
        </div>
    </span>
    <div class=""d-flex flex-row "">
        <div class=""col-7"">
            <label for=""sDiaChi"">Địa chỉ</label>
            <input id=""sDiaChi"" class=""form-control"" />
        </div>
    </div>
    <button onclick='createItem(event)' class=""btn btn-primary mt-2 mb-2"">Thêm</button>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<h2>Danh sách khách hàng</h2>
<div <div class=""table-responsive"" style=""height: 500px; overflow-y: auto;"">
    <table class=""table table-bordered"" id=""productTable"">
        <thead>
            <tr>
                <th>Mã khách hàng</th>
                <th>Tên khách hàng</th>
                <th>Số điện thoại</th>
                <th>Địa chỉ</th>
                <th>Điểm</th>
                <th>#</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 36 "D:\Study\HocKyI-Nam2024-2025\CNPM\BTL\Code\QuanLyQuanCaPhe\Views\KhachHang\Index.cshtml"
                 foreach (var khachHang in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr");
            BeginWriteAttribute("id", " id=\"", 1326, "\"", 1350, 1);
#nullable restore
#line 38 "D:\Study\HocKyI-Nam2024-2025\CNPM\BTL\Code\QuanLyQuanCaPhe\Views\KhachHang\Index.cshtml"
WriteAttributeValue("", 1331, khachHang.PK_sMaKH, 1331, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <td>");
#nullable restore
#line 39 "D:\Study\HocKyI-Nam2024-2025\CNPM\BTL\Code\QuanLyQuanCaPhe\Views\KhachHang\Index.cshtml"
                   Write(khachHang.PK_sMaKH);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 40 "D:\Study\HocKyI-Nam2024-2025\CNPM\BTL\Code\QuanLyQuanCaPhe\Views\KhachHang\Index.cshtml"
                   Write(khachHang.sTenKH);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 41 "D:\Study\HocKyI-Nam2024-2025\CNPM\BTL\Code\QuanLyQuanCaPhe\Views\KhachHang\Index.cshtml"
                   Write(khachHang.sSDT);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 42 "D:\Study\HocKyI-Nam2024-2025\CNPM\BTL\Code\QuanLyQuanCaPhe\Views\KhachHang\Index.cshtml"
                   Write(khachHang.sDiaChi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 43 "D:\Study\HocKyI-Nam2024-2025\CNPM\BTL\Code\QuanLyQuanCaPhe\Views\KhachHang\Index.cshtml"
                   Write(khachHang.iDiem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <button");
            BeginWriteAttribute("onclick", " onclick=\"", 1651, "\"", 1945, 18);
            WriteAttributeValue("", 1661, "openEditModal({", 1661, 15, true);
            WriteAttributeValue("\r\n                            ", 1676, "PK_sMaKH:", 1706, 39, true);
            WriteAttributeValue(" ", 1715, "\'", 1716, 2, true);
#nullable restore
#line 46 "D:\Study\HocKyI-Nam2024-2025\CNPM\BTL\Code\QuanLyQuanCaPhe\Views\KhachHang\Index.cshtml"
WriteAttributeValue("", 1717, khachHang.PK_sMaKH, 1717, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1736, "\',", 1736, 2, true);
            WriteAttributeValue("\r\n                            ", 1738, "sTenKH:", 1768, 37, true);
            WriteAttributeValue(" ", 1775, "\'", 1776, 2, true);
#nullable restore
#line 47 "D:\Study\HocKyI-Nam2024-2025\CNPM\BTL\Code\QuanLyQuanCaPhe\Views\KhachHang\Index.cshtml"
WriteAttributeValue("", 1777, khachHang.sTenKH, 1777, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1794, "\',", 1794, 2, true);
            WriteAttributeValue("\r\n                            ", 1796, "sSDT:", 1826, 35, true);
            WriteAttributeValue(" ", 1831, "\'", 1832, 2, true);
#nullable restore
#line 48 "D:\Study\HocKyI-Nam2024-2025\CNPM\BTL\Code\QuanLyQuanCaPhe\Views\KhachHang\Index.cshtml"
WriteAttributeValue("", 1833, khachHang.sSDT, 1833, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1848, "\',", 1848, 2, true);
            WriteAttributeValue("\r\n                            ", 1850, "sDiaChi:", 1880, 38, true);
            WriteAttributeValue(" ", 1888, "\'", 1889, 2, true);
#nullable restore
#line 49 "D:\Study\HocKyI-Nam2024-2025\CNPM\BTL\Code\QuanLyQuanCaPhe\Views\KhachHang\Index.cshtml"
WriteAttributeValue("", 1890, khachHang.sDiaChi, 1890, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1908, "\'", 1908, 1, true);
            WriteAttributeValue("\r\n                                ", 1909, "})", 1943, 36, true);
            EndWriteAttribute();
            WriteLiteral(" class=\" btn btn-primary\">\r\n                            Sửa\r\n                        </button>\r\n                        <button type=\"button\" class=\"btn btn-danger\"");
            BeginWriteAttribute("onclick", "\r\n                            onclick=\"", 2110, "\"", 2188, 3);
            WriteAttributeValue("", 2149, "deleteItem(event,\'", 2149, 18, true);
#nullable restore
#line 54 "D:\Study\HocKyI-Nam2024-2025\CNPM\BTL\Code\QuanLyQuanCaPhe\Views\KhachHang\Index.cshtml"
WriteAttributeValue("", 2167, khachHang.PK_sMaKH, 2167, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2186, "\')", 2186, 2, true);
            EndWriteAttribute();
            WriteLiteral(">Xóa</button>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 57 "D:\Study\HocKyI-Nam2024-2025\CNPM\BTL\Code\QuanLyQuanCaPhe\Views\KhachHang\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
    </table>
</div>
<!-- Modal HTML -->
<div class=""modal fade"" id=""editCustomerModal"" tabindex=""-1"" aria-labelledby=""editCustomerModalLabel""
    aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""editCustomerModalLabel"">Cập nhật thông tin khách hàng</h5>
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-body"">
                <input type=""hidden"" id=""editPK_sMaKH"" />
                <div class=""mb-3"">
                    <label for=""editTenKH"" class=""form-label"">Tên khách hàng</label>
                    <input type=""text"" id=""editTenKH"" class=""form-control"" />
                </div>
                <div class=""mb-3"">
                    <label for=""editSDT"" class=""form-label"">Số điện thoại</label>
                    <input type=""text"" id=""editSDT""");
            WriteLiteral(@" class=""form-control"" />
                </div>
                <div class=""mb-3"">
                    <label for=""editDiaChi"" class=""form-label"">Địa chỉ</label>
                    <input type=""text"" id=""editDiaChi"" class=""form-control"" />
                </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-bs-dismiss=""modal"">Đóng</button>
                <button type=""button"" class=""btn btn-primary"" onclick=""updateCustomer()"">Lưu thay đổi</button>
            </div>
        </div>
    </div>
</div>
<script>
    function openEditModal(khachHang) {
        // Populate modal fields with existing data
        document.getElementById('editPK_sMaKH').value = khachHang.PK_sMaKH;
        document.getElementById('editTenKH').value = khachHang.sTenKH;
        document.getElementById('editSDT').value = khachHang.sSDT;
        document.getElementById('editDiaChi').value = khachHang.sDiaChi;

        // Show the modal");
            WriteLiteral(@"
        const editCustomerModal = new bootstrap.Modal(document.getElementById('editCustomerModal'));
        editCustomerModal.show();
    }

    async function updateCustomer() {
        const khachHang = {
            PK_sMaKH: document.getElementById('editPK_sMaKH').value,
            sTenKH: document.getElementById('editTenKH').value,
            sSDT: document.getElementById('editSDT').value,
            sDiaChi: document.getElementById('editDiaChi').value
        };
        console.log('check:', khachHang);
        const formData = new FormData();
        formData.append('khachHang', JSON.stringify(khachHang));
        try {
            const response = await fetch('/KhachHang/Edit', {
                method: 'POST',
                body: formData
            });

            const data = await response.json();
            console.log(""Check data: "", data)
            if (data.success) {
                alert('Updated successfully');
                window.location.href = '/Khac");
            WriteLiteral(@"hHang/Index';
            } else {
                alert('Error updating: ' + data.message);
            }
        } catch (error) {
            console.error('Error:', error);
            alert('An error occurred while updating.');
        }
    }
    async function createItem(event) {
        event.preventDefault();
        const khachHang = {
            PK_sMaKH: '1',
            sTenKH: document.getElementById('sTenKH').value,
            sDiaChi: document.getElementById('sDiaChi').value,
            sSDT: document.getElementById('sSDT').value,
            iDiem: 0
        };
        console.log('check:', khachHang);
        const formData = new FormData();
        formData.append('khachHang', JSON.stringify(khachHang));
        try {
            const response = await fetch('/KhachHang/Create', {
                method: 'POST',
                body: formData
            });
            const data = await response.json();
            console.log(""Check data: "", data)
         ");
            WriteLiteral(@"   if (data.success) {
                alert('Created successfully');
                window.location.href = '/KhachHang/Index';
            } else {
                alert('Error creating: ' + data.message);
            }
        } catch (error) {
            console.error('Error:', error);
            alert('An error occurred while creating.');
        }
    }
    async function deleteItem(event, idDelete) {
        event.preventDefault();
        console.log(""Check: "", idDelete)
        try {
            const response = await fetch(`/KhachHang/Delete`, {
                method: 'POST',
                headers: {
                    'Content-Type': 'application/json'
                },
                body: JSON.stringify({ id: idDelete })
            });

            const data = await response.json();
            console.log(""Check data: "", data)
            if (data.success) {
                document.getElementById(`${idDelete}`).remove();
                alert(data.message)
");
            WriteLiteral("            } else {\r\n                alert(\'Error deleting\');\r\n            }\r\n        } catch (error) {\r\n            console.error(\'Error:\', error);\r\n        }\r\n    }\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<QuanLyQuanCaPhe.Models.KhachHangModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
