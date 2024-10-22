using Microsoft.EntityFrameworkCore;
using QuanLyQuanCaPhe.Models;

namespace QuanLyQuanCaPhe.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SanPhamModel>()
                .HasKey(p => p.PK_sMaSP);
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<NhaCungCapModel>()
                .HasKey(p => p.PK_sMaNCC);
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<LoaiSanPhamModel>()
                .HasKey(p => p.PK_sMaLSP);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<SanPhamModel> tbl_SanPham { get; set; }
        public DbSet<NhaCungCapModel> tbl_NhaCungCap { get; set; }
        public DbSet<LoaiSanPhamModel> tbl_LoaiSanPham { get; set; }
    }
}
