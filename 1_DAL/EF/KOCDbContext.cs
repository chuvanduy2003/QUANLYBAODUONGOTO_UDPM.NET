using _1_DAL.Entities;
using _1_DAL.EntitiesConfiguration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_DAL.EF
{
    public class KOCDbContext : DbContext
    {


        public KOCDbContext(DbContextOptions options) : base(options)
        {
        }
        public KOCDbContext()
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ChucVuConfiguration());
            modelBuilder.ApplyConfiguration(new DichVuConfiguration());
            modelBuilder.ApplyConfiguration(new LoaiDichVuConfiguration());
            modelBuilder.ApplyConfiguration(new KhachHangConfiguration());
            modelBuilder.ApplyConfiguration(new NhanVienConfiguration());
            modelBuilder.ApplyConfiguration(new XeConfiguration());
            modelBuilder.ApplyConfiguration(new PhieuChiTietConfiguration());
            modelBuilder.ApplyConfiguration(new PhieuDichVuConfiguration());
        }
        public DbSet<ChucVu> ChucVus { get; set; }
        public DbSet<DichVu> DichVus { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<LoaiDichVu> LoaiDichVus { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<PhieuChiTiet> PhieuChiTiets { get; set; }
        public DbSet<PhieuDichVu> PhieuDichVus { get; set; }
        public DbSet<Xe> Xes { get; set; }
    }
}
