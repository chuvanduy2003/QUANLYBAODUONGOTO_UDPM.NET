using _1_DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_DAL.EntitiesConfiguration
{
    public class LoaiDichVuConfiguration : IEntityTypeConfiguration<LoaiDichVu>
    {
        public void Configure(EntityTypeBuilder<LoaiDichVu> builder)
        {
            builder.ToTable("LoaiDichVu");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasDefaultValueSql("NEWID()");
            builder.Property(x => x.Ma).IsRequired().HasMaxLength(10).IsRequired();
            builder.Property(x => x.Ten).IsRequired().HasMaxLength(200).IsRequired();
            builder.Property(x => x.TrangThai).HasDefaultValue(0);
        }
    }
}
