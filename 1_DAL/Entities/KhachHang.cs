using System;
using System.Collections.Generic;
using System.Text;

namespace _1_DAL.Entities
{
    public class KhachHang
    {
        public Guid Id { get; set; }
        public string Ma { get; set; }
        public string Ho { get; set; }
        public string TenDem { get; set; }
        public string Ten { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public string ThanhPho { get; set; }
        public int TrangThai { get; set; }
        public ICollection<Xe> Xes { get; set; }
    }
}
