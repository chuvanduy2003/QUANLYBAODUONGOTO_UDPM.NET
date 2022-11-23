using _1_DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_DAL.EntitiesConfiguration
{
    public class PhieuDichVuConfiguration : IEntityTypeConfiguration<PhieuDichVu>
    {
        public void Configure(EntityTypeBuilder<PhieuDichVu> builder)
        {
            builder.ToTable("PhieuDichVu");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id);
            builder.HasOne<Xe>(x => x.Xe)
                   .WithMany(x => x.PhieuDichVus)
                   .HasForeignKey(x => x.IdXe);
            builder.HasOne<NhanVien>(x => x.NhanVien)
                   .WithMany(x => x.PhieuDichVus)
                   .HasForeignKey(x => x.IdNVTaoPhieu);
            builder.Property(x => x.Ma).HasMaxLength(10).IsRequired();
            builder.HasCheckConstraint("TimeHT", "ThoiGianHT >= GETDATE()")
                   .Property(x => x.ThoiGianHT)
                   .IsRequired();
            builder.Property(x => x.ThoiGianTao).HasDefaultValueSql("GETDATE()");
            builder.HasCheckConstraint("TimeNhan", "ThoiGianNhan >= GETDATE()")
                   .Property(x => x.ThoiGianNhan)
                   .IsRequired();
            builder.HasCheckConstraint("PriceSum", "TongTien >= 0")
                   .Property(x => x.TongTien)
                   .IsRequired();
            builder.Property(x => x.SDT).HasMaxLength(11).IsRequired();
            builder.Property(x => x.TenNguoiNhan).HasMaxLength(200).IsRequired()
                   .IsUnicode();
            builder.Property(x => x.TrangThai).HasDefaultValue(0);
        }
    }
}
