using _1_DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_DAL.EntitiesConfiguration
{
    public class XeConfiguration : IEntityTypeConfiguration<Xe>
    {
        public void Configure(EntityTypeBuilder<Xe> builder)
        {
            builder.ToTable("Xe");
            builder.HasKey(x => x.Id);
            builder.HasOne<KhachHang>(x => x.KhachHang)
                   .WithMany(x => x.Xes)
                   .HasForeignKey(x => x.IdKH);
            builder.Property(x => x.BienSo).HasMaxLength(10).IsRequired();
            builder.Property(x => x.TrangThai).HasDefaultValue(0);
        }
    }
}
