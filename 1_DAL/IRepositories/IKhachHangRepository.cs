using _1_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_DAL.IRepositories
{
    public interface IKhachHangRepository
    {
        public bool Add(KhachHang obj);
        public bool Update(KhachHang obj);
        public bool Delete(KhachHang obj);
        public List<KhachHang> GetAll();
    }
}
