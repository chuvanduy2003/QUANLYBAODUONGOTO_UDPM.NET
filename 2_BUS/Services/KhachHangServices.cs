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
    public class KhachHangServices : IKhachHangServices
    {
        IKhachHangRepository _ikhachhangrepository;

        public KhachHangServices()
        {
            _ikhachhangrepository = new KhachHangRepository();
            GetAll();
        }
        public string Add(KhachHangViews obj)
        {
            if (obj == null) return "Thất bại";
            var a = new KhachHang()
            {
                Id = Guid.NewGuid(),
                Ma = obj.Ma,
                Ho = obj.Ho,
                Ten = obj.Ten,
                TenDem = obj.Tendem,
                SDT = obj.SDT,
                DiaChi = obj.DiaChi,
                ThanhPho = obj.ThanhPho,
                KhungGio = obj.KhungGio,
                TrangThai = obj.TrangThai,
            };
            if (_ikhachhangrepository.Add(a))
            {
                GetAll();
                return "Thành Công";
            }
            return "Thất bại";

        }

        public string Delete(KhachHangViews obj)
        {
            if (obj == null) return "Thất bại";
            var a = new KhachHang()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
                SDT = obj.SDT,
                DiaChi = obj.DiaChi,
                KhungGio = obj.KhungGio,
                TrangThai = obj.TrangThai,
            };
            if (_ikhachhangrepository.Delete(a)) return "Thành Công";
            return "Thất bại";
        }

        public List<KhachHangViews> GetAll()
        {
            List<KhachHangViews> lst = new List<KhachHangViews>();

            lst = (from a in _ikhachhangrepository.GetAll()
                   select new KhachHangViews
                   {
                       Id = a.Id,
                       Ma = a.Ma,
                       Ho = a.Ho,
                       Tendem = a.TenDem,
                       Ten = a.Ten,
                       SDT = a.SDT,
                       DiaChi = a.DiaChi,
                       ThanhPho = a.ThanhPho,
                       KhungGio = a.KhungGio,
                       TrangThai = a.TrangThai,
                       HoTen = a.Ho + " " + a.TenDem + " " + a.Ten,
                       Diachi = a.DiaChi + " " + a.ThanhPho,
                   }).ToList();
            return lst;
        }

        public string Update(KhachHangViews obj)
        {
            if (obj == null) return "Thất bại";
            var a = new KhachHang()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ho = obj.Ho,
                TenDem = obj.Tendem,
                Ten = obj.Ten,
                SDT = obj.SDT,
                DiaChi = obj.DiaChi,
                ThanhPho = obj.ThanhPho,
                KhungGio = obj.KhungGio,
                TrangThai = obj.TrangThai,
            };
            if (_ikhachhangrepository.Update(a)) return "Thành Công";
            return "Thất bại";
        }
        public List<KhachHangViews> GetAll(string input)
        {


            if (input == null)
            {
                return GetAll();
            }
            //List<KhachHangViews> x = new List<KhachHangViews>();
            var x = GetAll().Where(c => c.SDT.Contains(input)).ToList();

            return x;

        }
    }
}
