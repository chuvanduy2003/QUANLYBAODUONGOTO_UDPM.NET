using _1_DAL.EF;
using _1_DAL.Entities;
using _1_DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1_DAL.Repositories
{
    public class PhieuChiTietRepository : IPhieuChiTietRepository
    {
        KOCDbContext _db;
        public PhieuChiTietRepository()
        {
            _db = new KOCDbContext();
        }

        public bool Add(PhieuChiTiet obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();
            _db.PhieuChiTiets.Add(obj);
            _db.SaveChanges();
            return true;
        }

        public bool Delete(PhieuChiTiet obj)
        {
            if (obj == null) return false;
            var temp = _db.PhieuChiTiets.FirstOrDefault(x => x.Id == obj.Id);
            _db.PhieuChiTiets.Remove(obj);
            _db.SaveChanges();
            return true;
        }

        public List<PhieuChiTiet> GetAll()
        {
            return _db.PhieuChiTiets.ToList();
        }

        public bool Update(PhieuChiTiet obj)
        {
            if (obj == null) return false;
            var temp = _db.PhieuChiTiets.FirstOrDefault(x => x.IdPhieu == obj.IdPhieu);
            temp.IdDichVu = obj.IdDichVu;
            temp.SoLuong = obj.SoLuong;
            temp.DonGia = obj.DonGia;
            temp.TrangThai = obj.TrangThai;
            _db.PhieuChiTiets.Update(obj);
            _db.SaveChanges();
            return true;
        }
    }
}
