using System;
using System.Collections.Generic;
using System.Text;

namespace _1_DAL.Entities
{
    public class PhieuDichVu
    {
        public Guid Id { get; set; }
        public Guid IdXe { get; set; }
        public Guid IdNVTaoPhieu { get; set; }
        public string Ma { get; set; }
        public DateTime ThoiGianNhan { get; set; }
        public DateTime ThoiGianTao { get; set; }
        public DateTime ThoiGianHT { get; set; }
        public float TongTien { get; set; }
        public Guid IdNVSua { get; set; }
        public string TenNguoiNhan { get; set; }
        public string SDT { get; set; }
        public int TrangThai { get; set; }
        public ICollection<PhieuChiTiet> PhieuChiTiets { get; set; }
        public Xe Xe { get; set; }
        public NhanVien NhanVien { get; set; }
    }
}
