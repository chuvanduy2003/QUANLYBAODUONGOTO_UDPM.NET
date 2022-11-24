using _1_DAL.Entities;
using _1_DAL.IRepositories;
using _1_DAL.Repositories;
using _2_BUS.IServices;
using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2_BUS.Services
{
    public class NhanVienServices : INhanVienServices
    {
        INhanVienRepository _inhanvienrepository;
        IChucVuRepository _ichucvurepository;
        public NhanVienServices()
        {
            _inhanvienrepository = new NhanVienRepository();
            _ichucvurepository = new ChucVuRepository();
        }
        public string Add(NhanVienViews obj)
        {
            if (obj == null) return "Thất bại";
            var a = new NhanVien()
            {
                Id = obj.Id,
                IdCV = obj.IdCV,
                Ma = obj.Ma,
                MatKhau = obj.MatKhau,
                Ho = obj.Ho,
                TenDem = obj.TenDem,
                Ten = obj.Ten,
                TenDangNhap = obj.TenDangNhap,
                DiaChi = obj.DiaChi,
                ThanhPho = obj.ThanhPho,
                TrangThai = obj.TrangThai,
                SDT = obj.SDT,
            };
            if (_inhanvienrepository.Add(a)) return "Thành công";
            return "Thất bại";
        }

        public string Delete(NhanVienViews obj)
        {
            if (obj == null) return "Thất bại";
            var a = new NhanVien()
            {
                Id = obj.Id,
                IdCV = obj.IdCV,
                Ma = obj.Ma,
                MatKhau = obj.MatKhau,
                Ho = obj.Ho,
                TenDem = obj.TenDem,
                Ten = obj.Ten,
                TenDangNhap = obj.TenDangNhap,
                DiaChi = obj.DiaChi,
                ThanhPho = obj.ThanhPho,
                TrangThai = obj.TrangThai,
                SDT = obj.SDT,
                
            };
            if (_inhanvienrepository.Delete(a)) return "Thành công";
            return "Thất bại";
        }

        public List<NhanVienViews> GetAll()
        {
            List<NhanVienViews> lst = new List<NhanVienViews>();
            lst = (from a in _inhanvienrepository.GetAll()
                   join b in _ichucvurepository.GetAll() on a.IdCV equals b.Id
                   select new NhanVienViews()
                   {
                       Id = a.Id,
                       IdCV = b.Id,
                       Ma = a.Ma,
                       Ho = a.Ho,
                       TenDem = a.TenDem,
                       Ten = a.Ten,
                       TenCV = b.Ten,
                       TenDangNhap = a.TenDangNhap,
                       MatKhau = a.MatKhau,
                       DiaChi = a.DiaChi,
                       ThanhPho = a.ThanhPho,
                       SDT = a.SDT,
                       TrangThai = a.TrangThai,
                       
                   }).ToList();
            return lst;
        }
        public List<NhanVienViews> GetAll(string a)
        {
            if (a == null)
            {
                return GetAll();
            }
            return GetAll().Where(c => c.Ma.Contains(a)).ToList();
        }
        public string Update(NhanVienViews obj)
        {
            if (obj == null) return "Thất bại";
            var a = new NhanVien()
            {
                Id = obj.Id,
                IdCV = obj.IdCV,
                Ma = obj.Ma,
                MatKhau = obj.MatKhau,
                Ho = obj.Ho,
                TenDem = obj.TenDem,
                Ten = obj.Ten,
                TenDangNhap = obj.TenDangNhap,
                DiaChi = obj.DiaChi,
                ThanhPho = obj.ThanhPho,
                TrangThai = obj.TrangThai,
                SDT = obj.SDT,
                
            };
            if (_inhanvienrepository.Update(a)) return "Thành công";
            return "Thất bại";
        }
    }
}
