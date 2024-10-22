using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using QuanLyQuanCaPhe.Data;
using QuanLyQuanCaPhe.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyQuanCaPhe.Controllers
{
    public class SanPhamController : Controller
    {
        // private readonly ILogger<SanPhamController> _logger;

        // public SanPhamController(ILogger<SanPhamController> logger)
        // {
        //     _logger = logger;
        // }
        private readonly ApplicationDbContext _context;
        private readonly ILogger<SanPhamController> _logger;

        public SanPhamController(ApplicationDbContext context, ILogger<SanPhamController> logger)
        {
            _context = context;
            _logger = logger;
        }
        public async Task<IActionResult> Create()
        {
            var ncc = await _context.tbl_NhaCungCap.ToListAsync();
            //Console.WriteLine("Check: ");
            ViewBag.NhaCungCap = new SelectList(ncc, "PK_sMaNCC", "sTenNCC");
            ViewBag.LoaiSanPham = new SelectList(await _context.tbl_LoaiSanPham.ToListAsync(), "PK_sMaLSP", "sTenLoaiSanPham");
            return View();
        }

        // Phương thức POST để xử lý dữ liệu từ form
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(SanPhamModel model)
        {
            if (ModelState.IsValid)
            {
                var sanPham = new SanPhamModel
                {
                    PK_sMaSP = "SP" + DateTime.Now.ToString("yyyyMMddHHmmss"),
                    sTenSP = model.sTenSP,
                    FK_sMaNCC = model.FK_sMaNCC,
                    FK_sMaLSP = model.FK_sMaLSP,
                    iSoLuong = model.iSoLuong,
                    sIMG = model.sIMG,
                    fGiaSP = model.fGiaSP
                };

                _context.tbl_SanPham.Add(sanPham);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }
        public IActionResult Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sanPham = _context.tbl_SanPham
                .FirstOrDefault(m => m.PK_sMaSP == id);
            if (sanPham == null)
            {
                return NotFound();
            }

            return View(sanPham);
        }

        // Phương thức POST để xử lý yêu cầu xóa sản phẩm
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var product = _context.tbl_SanPham.Find(id);
            _context.tbl_SanPham.Remove(product);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Index(string maNCC)
        {
            // var models = await _context.tbl_SanPham.ToListAsync();
            // maNCC = "NCC01";
            //Console.WriteLine("check: " + maNCC);
            var ncc = await _context.tbl_NhaCungCap.ToListAsync();
            ViewBag.NhaCungCap = ncc;
            var models = string.IsNullOrEmpty(maNCC) ?
                   await _context.tbl_SanPham.ToListAsync() :
                   await _context.tbl_SanPham.Where(p => p.FK_sMaNCC == maNCC).ToListAsync();
            return View(models);
        }
    }
}
