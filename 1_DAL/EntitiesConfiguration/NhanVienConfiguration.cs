using _1_DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_DAL.EntitiesConfiguration
{
    public class NhanVienConfiguration : IEntityTypeConfiguration<NhanVien>
    {
        public void Configure(EntityTypeBuilder<NhanVien> builder)
        {
            builder.ToTable("NhanVien");
            builder.HasKey(x => x.Id);
            builder.HasOne<ChucVu>(x => x.ChucVu)
                   .WithMany(x => x.NhanViens)
                   .HasForeignKey(x => x.IdCV);
            builder.Property(x => x.Id).HasDefaultValueSql("NEWID()");
            builder.Property(x => x.Ma).HasMaxLength(10).IsRequired();
            builder.Property(x => x.Ten).HasMaxLength(50).IsRequired()
                   .IsUnicode();
            builder.Property(x => x.Ho).HasMaxLength(50).IsRequired()
                   .IsUnicode();
            builder.Property(x => x.TenDem).HasMaxLength(50).IsRequired()
                   .IsUnicode();
            builder.Property(x => x.SDT).HasMaxLength(11).IsRequired();
            builder.Property(x => x.DiaChi).HasMaxLength(50).IsRequired()
                   .IsUnicode();
            builder.Property(x => x.ThanhPho).HasMaxLength(50).IsRequired()
                   .IsUnicode();
            builder.Property(x => x.TrangThai).HasDefaultValue(0);
        }
    }
}
