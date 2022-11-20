using _1_DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_DAL.EntitiesConfiguration
{
    public class PhieuChiTietConfiguration : IEntityTypeConfiguration<PhieuChiTiet>
    {
        public void Configure(EntityTypeBuilder<PhieuChiTiet> builder)
        {
            builder.ToTable("PhieuChiTiet").HasKey(x => x.Id);
            builder.Property(x => x.Id).HasDefaultValueSql("NEWID()");
            builder.HasOne<PhieuDichVu>(x => x.PhieuDichVu)
                   .WithMany(x => x.PhieuChiTiets)
                   .HasForeignKey(x => x.IdPhieu);
            builder.HasOne<DichVu>(x => x.DichVu)
                   .WithMany(x => x.PhieuChiTiets)
                   .HasForeignKey(x => x.IdDichVu);
            builder.HasCheckConstraint("Stocks", "SoLuong >= 0")
                   .Property(x => x.SoLuong)
                   .IsRequired();
            builder.HasCheckConstraint("Prices", "DonGia >= 0")
                   .Property(x => x.DonGia)
                   .IsRequired();
            builder.Property(x => x.TrangThai).HasDefaultValue(0);
        }
    }
}
