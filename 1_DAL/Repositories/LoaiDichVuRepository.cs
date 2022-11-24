using _1_DAL.EF;
using _1_DAL.Entities;
using _1_DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1_DAL.Repositories
{
    public class LoaiDichVuRepository : ILoaiDichVuRepository
    {
        KOCDbContext _db;
       
        public LoaiDichVuRepository()
        {
            _db = new KOCDbContext();
        }
        public bool Add(LoaiDichVu obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();
            _db.LoaiDichVus.Add(obj);
            _db.SaveChanges();
            return true;
        }

        public bool Delete(LoaiDichVu obj)
        {
            if (obj == null) return false;
            var temp = _db.LoaiDichVus.FirstOrDefault(x => x.Id == obj.Id);
            _db.LoaiDichVus.Remove(temp);
            _db.SaveChanges();
            return true;
        }

        public List<LoaiDichVu> GetAll()
        {
            return _db.LoaiDichVus.ToList();
        }

        public bool Update(LoaiDichVu obj)
        {
            if (obj == null) return false;
            var temp = _db.LoaiDichVus.FirstOrDefault(c => c.Id == obj.Id);
            //temp.Id = obj.Id;
            temp.Ma = obj.Ma;
            temp.Ten = obj.Ten;
            temp.TrangThai = obj.TrangThai;
            _db.LoaiDichVus.Update(temp);
            _db.SaveChanges();
            return true;
        }

       
    }
}
