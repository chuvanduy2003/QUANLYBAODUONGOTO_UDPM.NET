using _1_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_DAL.IRepositories
{
    public interface INhanVienRepository
    {
        public bool Add(NhanVien obj);
        public bool Update(NhanVien obj);
        public bool Delete(NhanVien obj);
        public List<NhanVien> GetAll();
    }
}
