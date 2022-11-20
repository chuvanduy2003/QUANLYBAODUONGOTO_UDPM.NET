using System;
using System.Collections.Generic;
using System.Text;

namespace _2_BUS.ViewModels
{
    public class PhieuChiTietViews
    {
        public Guid Id { get; set; }
        public Guid IdPhieu { get; set; }
        public Guid IdDichVu { get; set; }
        public int SoLuong { get; set; }
        public float DonGia { get; set; }
        public int TrangThai { get; set; }
        public string TenDv { get; set; }
    }
}
