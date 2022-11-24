using _1_DAL.EF;
using _1_DAL.Entities;
using _1_DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1_DAL.Repositories
{
    public class NhanVienRepository : INhanVienRepository
    {
        KOCDbContext _db;
        public NhanVienRepository()
        {
            _db = new KOCDbContext();
        }

        public bool Add(NhanVien obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();
            _db.NhanViens.Add(obj);
            _db.SaveChanges();
            return true;
        }

        public bool Delete(NhanVien obj)
        {
            if (obj == null) return false;
            var temp = _db.NhanViens.FirstOrDefault(x => x.Id == obj.Id);
            _db.NhanViens.Remove(temp);
            _db.SaveChanges();
            return true;
        }

        public List<NhanVien> GetAll()
        {
            return _db.NhanViens.ToList();
        }

        public bool Update(NhanVien obj)
        {
            if (obj == null) return false;
            var temp = _db.NhanViens.FirstOrDefault(x => x.Id == obj.Id);
            temp.Ma = obj.Ma;
            temp.Ho = obj.Ho;
            temp.TenDem = obj.TenDem;
            temp.Ten = obj.Ten;
            temp.SDT = obj.SDT;
            temp.DiaChi = obj.DiaChi;
            temp.ThanhPho = obj.ThanhPho;
            temp.TenDangNhap = obj.TenDangNhap;
            temp.MatKhau = obj.MatKhau;
            temp.ChucVu = obj.ChucVu;
            temp.TrangThai = obj.TrangThai;
            _db.NhanViens.Update(temp);
            _db.SaveChanges();
            return true;
        }
    }
}
