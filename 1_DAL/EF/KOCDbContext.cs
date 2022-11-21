using _1_DAL.Entities;
using _1_DAL.EntitiesConfiguration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace _1_DAL.EF
{
    public class KOCDbContext : DbContext
    {

        public KOCDbContext()
        {

        }

        public KOCDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            if (!optionsBuilder.IsConfigured)
            {


                optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-M1K92CSH\SQLEXPRESS;Initial Catalog=KOC_BMW;Integrated Security=True");

            }

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
        public virtual DbSet<ChucVu> ChucVus { get; set; }
        public virtual DbSet<DichVu> DichVus { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<LoaiDichVu> LoaiDichVus { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<PhieuChiTiet> PhieuChiTiets { get; set; }
        public virtual DbSet<PhieuDichVu> PhieuDichVus { get; set; }
        public virtual DbSet<Xe> Xes { get; set; }
    }
}