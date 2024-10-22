using Microsoft.AspNetCore.Http.Features;
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
    public class CongThucController : Controller
    {
        // private readonly ILogger<SanPhamController> _logger;

        // public SanPhamController(ILogger<SanPhamController> logger)
        // {
        //     _logger = logger;
        // }
        private readonly ApplicationDbContext _context;
        private readonly ILogger<CongThucController> _logger;

        public CongThucController(ApplicationDbContext context, ILogger<CongThucController> logger)
        {
            _context = context;
            _logger = logger;
        }
        public async Task<IActionResult> Create(string maSP)
        {
            var ncc = await _context.tbl_NhaCungCap.ToListAsync();
            //Console.WriteLine("Check: ");
            ViewBag.NguyenLieu = new SelectList(await _context.tbl_NguyenLieu.ToListAsync(), "PK_sMaNL", "sTenNL");
            ViewBag.SanPham = await _context.tbl_SanPham.ToListAsync();
            if (!string.IsNullOrEmpty(maSP))
            {
                ViewBag.CongThuc = await _context.tbl_CongThuc.Where(p => p.FK_sMaSP == maSP).ToListAsync();
                ViewBag.maSP = maSP;
            }
            else
            {
                ViewBag.CongThuc = "";
                ViewBag.maSP = "";
            }
            return View();
        }

        // Phương thức POST để xử lý dữ liệu từ form
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CongThucModel model)
        {
            if (ModelState.IsValid)
            {
                var CongThuc = new CongThucModel
                {
                    FK_sMaNL = model.FK_sMaNL,
                    FK_sMaSP = model.FK_sMaSP,
                    fKhoiLuong = model.fKhoiLuong,
                };

                _context.tbl_CongThuc.Add(CongThuc);
                _context.SaveChanges();
            }
            return View();
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

        public async Task<IActionResult> Index(string maSP)
        {

            var ncc = await _context.tbl_NhaCungCap.ToListAsync();
            var sp = await _context.tbl_SanPham.ToListAsync();
            var nl = await _context.tbl_NguyenLieu.ToListAsync();
            ViewBag.NhaCungCap = ncc;
            ViewBag.SanPham = sp;
            ViewBag.NguyenLieu = nl;
            if (string.IsNullOrEmpty(maSP) == true)
            {
                Console.WriteLine("check");
                foreach (var item in sp)
                {
                    maSP = item.PK_sMaSP;
                    break;
                }
            }
            // var models = await _context.tbl_CongThuc.Where(p => p.FK_sMaSP == maSP).ToListAsync();
            var models = string.IsNullOrEmpty(maSP) ?
                   await _context.tbl_CongThuc.ToListAsync() :
                   await _context.tbl_CongThuc.Where(p => p.FK_sMaSP == maSP).ToListAsync();
            return View(models);
        }
    }
}