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
    public class XeServices : IXeServices
    {
        IXeRepository _ixerepository;
        IKhachHangRepository _ikhachhangrepository;
        public XeServices()
        {
            _ixerepository = new XeRepository();
            _ikhachhangrepository = new KhachHangRepository();
        }
        public string Add(XeViews obj)
        {
            if (obj == null) return "Thất bại";
            var a = new Xe()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                IdKH = obj.IdKH,
                BienSo = obj.BienSo,
                TrangThai = obj.TrangThai,
                
            };
            if (_ixerepository.Add(a)) return "Thành công";
            return "Thất bại";
        }

        public string Delete(XeViews obj)
        {
            if (obj == null) return "Thất bại";
            var a = new Xe()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                IdKH = obj.IdKH,
                BienSo = obj.BienSo,
                TrangThai = obj.TrangThai,

            };
            if (_ixerepository.Delete(a)) return "Thành công";
            return "Thất bại";
        }

        public List<XeViews> GetAll()
        {
            List<XeViews> lst = new List<XeViews>();
            lst = (from a in _ixerepository.GetAll()
                   join b in _ikhachhangrepository.GetAll() on a.IdKH equals b.Id
                   select new XeViews()
                   {
                       Id = a.Id,
                       Ma = a.Ma,
                       IdKH = b.Id,
                       TenKH = b.Ten,
                       BienSo = a.BienSo,
                       TrangThai = a.TrangThai,
                       //DiaChiKH=b.DiaChi,
                       //SDT=b.SDT,
                       //TrangThaiKH=b.TrangThai,
                       //KhungGio=b.KhungGio,
                   }).ToList();
            return lst;
        }

        public string Update(XeViews obj)
        {
            if (obj == null) return "Thất bại";
            var a = new Xe()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                IdKH = obj.IdKH,
                BienSo = obj.BienSo,
                TrangThai = obj.TrangThai,

            };
            if (_ixerepository.Update(a)) return "Thành công";
            return "Thất bại";
        }
    }
}
