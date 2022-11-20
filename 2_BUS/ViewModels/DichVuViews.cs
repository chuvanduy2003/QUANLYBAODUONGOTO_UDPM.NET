using System;
using System.Collections.Generic;
using System.Text;

namespace _2_BUS.ViewModels
{
    public class DichVuViews
    {
        public Guid Id { get; set; }
        public Guid IdLDV { get; set; }
        public string Ma { get; set; }
        public string Ten { get; set; }
        public float Gia { get; set; }
        public DateTime ThoiGianHT { get; set; }
        public int TrangThai { get; set; }
        public string TenLDV { get; set; }
    }
}
