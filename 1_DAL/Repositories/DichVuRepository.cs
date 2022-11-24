using _1_DAL.EF;
using _1_DAL.Entities;
using _1_DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1_DAL.Repositories
{
    public class DichVuRepository : IDichVuRepository
    {
        KOCDbContext _db;
       
        public DichVuRepository()
        {
            _db = new KOCDbContext();
        }

        public bool Add(DichVu obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();
            _db.DichVus.Add(obj);
            _db.SaveChanges();
            return true;
        }

        public bool Delete(DichVu obj)
        {
            if (obj == null) return false;
            var temp = _db.DichVus.FirstOrDefault(x => x.Id == obj.Id);
            _db.DichVus.Remove(temp);
            _db.SaveChanges();
            return true;
        }

        public List<DichVu> GetAll()
        {
            return _db.DichVus.ToList();
        }

        public bool Update(DichVu obj)
        {
            if (obj == null) return false;
            var temp = _db.DichVus.FirstOrDefault(x => x.Id == obj.Id);
            temp.IdLDV = obj.IdLDV;
            temp.Ma = obj.Ma;
            temp.Ten = obj.Ten;
            temp.Gia = obj.Gia;
            temp.ThoiGianHT = obj.ThoiGianHT;
            _db.DichVus.Update(temp);
            _db.SaveChanges();
            return true;
        }
    }
}
