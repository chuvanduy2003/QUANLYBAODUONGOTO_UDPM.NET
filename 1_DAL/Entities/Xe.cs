using System;
using System.Collections.Generic;
using System.Text;

namespace _1_DAL.Entities
{
    public class Xe
    {
        public Guid Id { get; set; }
        public Guid IdKH { get; set; }
        public string Ma { get; set; }
        public string BienSo { get; set; }
        public int TrangThai { get; set; }
        public KhachHang KhachHang { get; set; }
        public ICollection<PhieuDichVu> PhieuDichVus { get; set; }
    }
}
