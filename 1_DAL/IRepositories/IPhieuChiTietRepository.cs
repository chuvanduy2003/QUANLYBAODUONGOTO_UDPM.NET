using _1_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_DAL.IRepositories
{
    public interface IPhieuChiTietRepository
    {
        public bool Add(PhieuChiTiet obj);
        public bool Update(PhieuChiTiet obj);
        public bool Delete(PhieuChiTiet obj);
        public List<PhieuChiTiet> GetAll();
    }
}
