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
            if (obj == null)  return "Thất bại";
            var a = new KhachHang()
            {
                Id = Guid.NewGuid(),
                Ma = obj.Ma,
                Ten = obj.Ten,
                SDT = obj.SDT,
                DiaChi = obj.DiaChi,
                KhungGio=obj.KhungGio,
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
            if (obj == null) ; return "Thất bại";
            var a = new KhachHang()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
                SDT = obj.SDT,
                DiaChi = obj.DiaChi,
                KhungGio=obj.KhungGio,
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
                       Ten = a.Ten,
                       SDT = a.SDT,
                       DiaChi = a.DiaChi,
                       KhungGio=a.KhungGio,
                       TrangThai = a.TrangThai,
                   }).ToList();
            return lst;
        }

        public string Update(KhachHangViews obj)
        {
            if (obj == null) ; return "Thất bại";
            var a = new KhachHang()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
                SDT = obj.SDT,
                DiaChi = obj.DiaChi,
                KhungGio=obj.KhungGio,
                TrangThai = obj.TrangThai,
            };
            if (_ikhachhangrepository.Update(a)) return "Thành Công";
            return "Thất bại";
        }
    }
}

