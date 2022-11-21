using _1_DAL.EF;
using _1_DAL.Entities;
using _1_DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1_DAL.Repositories
{
    public class ChucVuRepository : IChucVuRepository
    {
        KOCDbContext _db;
        private List<ChucVu> _chucVuList;
        public ChucVuRepository()
        {
            _db = new KOCDbContext();
            _chucVuList = new List<ChucVu>();
        }

        public bool Add(ChucVu obj)
        {
            if (obj == null) return false;
            //obj.Id = Guid.NewGuid();
            _db.ChucVus.Add(obj);
            _db.SaveChanges();
            return true;
        }

        public bool Delete(ChucVu obj)
        {
            if (obj == null) return false;
            var temp = _db.ChucVus.FirstOrDefault(x => x.Id == obj.Id);
            _db.ChucVus.Remove(temp);
            _db.SaveChanges();
            return true;
        }

        public List<ChucVu> GetAll()
        {
            //return _db.ChucVus.ToList();

            _chucVuList = _db.ChucVus.ToList();
            return _chucVuList;
        }

        public bool Update(ChucVu obj)
        {
            if (obj == null) return false;
            var temp = _db.ChucVus.FirstOrDefault(x => x.Id == obj.Id);
            temp.Ma = obj.Ma;
            temp.Ten = obj.Ten;
            _db.ChucVus.Update(temp);
            _db.SaveChanges();
            return true;
        }
    }
}
