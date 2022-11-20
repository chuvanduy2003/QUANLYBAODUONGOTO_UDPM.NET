using System;
using System.Collections.Generic;
using System.Text;

namespace _1_DAL.Entities
{
    public class LoaiDichVu
    {
        public Guid Id { get; set; }
        public string Ma { get; set; }
        public string Ten { get; set; }
        public int TrangThai { get; set; }
        public ICollection<DichVu> DichVus { get; set; }
    }
}
