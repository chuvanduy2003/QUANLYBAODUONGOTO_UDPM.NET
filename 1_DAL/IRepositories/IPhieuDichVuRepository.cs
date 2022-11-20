using _1_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_DAL.IRepositories
{
    public interface IPhieuDichVuRepository
    {
        public bool Add(PhieuDichVu obj);
        public bool Update(PhieuDichVu obj);
        public bool Delete(PhieuDichVu obj);
        public List<PhieuDichVu> GetAll();
    }
}
