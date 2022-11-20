using _1_DAL.EF;
using _1_DAL.Entities;
using _1_DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1_DAL.Repositories
{
    public class PhieuDichVuRepository : IPhieuDichVuRepository
    {
        KOCDbContext _db;
        public PhieuDichVuRepository()
        {
            _db = new KOCDbContext();
        }

        public bool Add(PhieuDichVu obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();
            _db.Add(obj);
            _db.SaveChanges();
            return true;
        }

        public bool Delete(PhieuDichVu obj)
        {
            if (obj == null) return false;
            var temp = _db.PhieuDichVus.FirstOrDefault(x => x.Id == obj.Id);

            _db.Remove(obj);
            _db.SaveChanges();
            return true;
        }

        public List<PhieuDichVu> GetAll()
        {
            return _db.PhieuDichVus.ToList();
        }

        public bool Update(PhieuDichVu obj)
        {
            if (obj == null) return false;
            var temp = _db.PhieuDichVus.FirstOrDefault(x => x.Id == obj.Id);
            temp.IdXe = obj.IdXe;
            temp.IdNVTaoPhieu = obj.IdNVTaoPhieu;
            temp.IdNVSua = obj.IdNVSua;
            temp.Ma = obj.Ma;
            temp.TenNguoiNhan = obj.TenNguoiNhan;
            temp.ThoiGianTao = obj.ThoiGianTao;
            temp.ThoiGianNhan = obj.ThoiGianNhan;
            temp.ThoiGianHT = obj.ThoiGianHT;
            temp.TongTien = obj.TongTien;
            temp.SDT = obj.SDT;
            temp.TrangThai = obj.TrangThai;
            _db.Update(obj);
            _db.SaveChanges();
            return true;
        }
    }
}
