using System;
using System.Collections.Generic;
using System.Text;

namespace _1_DAL.Entities
{
    public class PhieuChiTiet
    {
        public Guid Id { get; set; }
        public Guid IdPhieu { get; set; }
        public Guid IdDichVu { get; set; }
        public int SoLuong { get; set; }
        public float DonGia { get; set; }
        public int TrangThai { get; set; }
        public DichVu DichVu { get; set; }
        public PhieuDichVu PhieuDichVu { get; set; }
    }
}
