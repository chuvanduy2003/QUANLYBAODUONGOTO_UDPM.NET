using _1_DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_DAL.EntitiesConfiguration
{
    public class DichVuConfiguration : IEntityTypeConfiguration<DichVu>
    {
        public void Configure(EntityTypeBuilder<DichVu> builder)
        {
            builder.ToTable("DichVu");
            builder.HasKey(x => x.Id);
            builder.HasOne<LoaiDichVu>(x => x.LoaiDichVu)
                   .WithMany(x => x.DichVus)
                   .HasForeignKey(x => x.IdLDV);
            builder.Property(x => x.Id);
            builder.Property(x => x.Ma).IsRequired().HasMaxLength(10);
            builder.Property(x => x.Ten).IsRequired().HasMaxLength(200)
                   .IsUnicode();
            builder.HasCheckConstraint("Price", "Gia >= 0")
                   .Property(x => x.Gia)
                   .IsRequired();
            builder.HasCheckConstraint("Time", "ThoiGianHT >= GETDATE()")
                   .Property(x => x.ThoiGianHT)
                   .IsRequired();
            builder.Property(x => x.TrangThai).HasDefaultValue(0);
        }
    }
}
