using _1_DAL.EF;
using _1_DAL.Entities;
using _1_DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1_DAL.Repositories
{
    public class XeRepository : IXeRepository
    {
        KOCDbContext _db;
        public XeRepository()
        {
            _db = new KOCDbContext();
        }
        public bool Add(Xe obj)
        {
            if (obj == null) return false;
            //obj.Id = Guid.NewGuid();
            _db.Xes.Add(obj);
            _db.SaveChanges();
            return true;
        }

        public bool Delete(Xe obj)
        {
            if (obj == null) return false;
            var temp = _db.Xes.FirstOrDefault(x => x.Id == obj.Id);
            _db.Xes.Remove(temp);
            _db.SaveChanges();
            return true;
        }

        public List<Xe> GetAll()
        {
            return _db.Xes.ToList();
        }

        public bool Update(Xe obj)
        {
            if (obj == null) return false;
            var temp = _db.Xes.FirstOrDefault(c => c.Id == obj.Id);
            temp.Id = obj.Id;
            temp.IdKH = obj.IdKH;
            temp.Ma = obj.Ma;
            temp.BienSo = obj.BienSo;
            temp.TrangThai = obj.TrangThai;
            _db.Xes.Update(temp);
            _db.SaveChanges();
            return true;
        }
    }
}
