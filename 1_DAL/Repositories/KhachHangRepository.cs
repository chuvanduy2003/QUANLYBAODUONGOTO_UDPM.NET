using _1_DAL.EF;
using _1_DAL.Entities;
using _1_DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1_DAL.Repositories
{
    public class KhachHangRepository : IKhachHangRepository
    {
        KOCDbContext _db;
        public KhachHangRepository()
        {
            _db = new KOCDbContext();
        }

        public bool Add(KhachHang obj)
        {
            if (obj == null) return false;
            //obj.Id = Guid.NewGuid();
            _db.KhachHangs.Add(obj);
            _db.SaveChanges();
            return true  ;
        }

        public bool Delete(KhachHang obj)
        {
            if (obj == null) return false;
            var temp = _db.KhachHangs.FirstOrDefault(x => x.Id == obj.Id);
            _db.KhachHangs.Remove(temp);
            _db.SaveChanges();
            return true;
        }

        public List<KhachHang> GetAll()
        {
            return _db.KhachHangs.ToList();
        }

        public bool Update(KhachHang obj)
        {
            if (obj == null) return false;
            var temp = _db.KhachHangs.FirstOrDefault(x => x.Id == obj.Id);
            temp.Ma = obj.Ma;
            temp.Ho = obj.Ho;
            temp.TenDem = obj.TenDem;
            temp.Ten = obj.Ten;
            temp.SDT = obj.SDT;
            temp.DiaChi = obj.DiaChi;
            temp.ThanhPho = obj.ThanhPho;
            temp.TrangThai = obj.TrangThai;
            _db.KhachHangs.Update(temp);
            _db.SaveChanges();
            return true;
        }
    }
}
