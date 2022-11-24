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
    public class LoaiDichVuSrevices : ILoaiDichVuServices
    {
        ILoaiDichVuRepository _iloaidvrepository;

        public LoaiDichVuSrevices()
        {
            _iloaidvrepository = new LoaiDichVuRepository();
        }

        public string Add(LoaiDichVuViews obj)
        {

           if (obj == null)  return "Thất bại";
            var a = new LoaiDichVu()
            {
                Id = Guid.NewGuid(),
                Ma = obj.Ma,
                Ten = obj.Ten,
                TrangThai = obj.TrangThai,
            };
            if (_iloaidvrepository.Add(a))  return "Thành công";
            return "Thất bại";
        }

        public string Delete(LoaiDichVuViews obj)
        {
           if (obj == null) return "Thất bại";
            var a = new LoaiDichVu()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
                TrangThai = obj.TrangThai,
            };
            if (_iloaidvrepository.Delete(a))  return "Thành công";
            return "Thất bại";
        }

        public List<LoaiDichVuViews> GetAll()
        {
             List<LoaiDichVuViews> lst = new List<LoaiDichVuViews>();
            lst = (from a in _iloaidvrepository.GetAll()
                   select new LoaiDichVuViews
                   {
                       Id = a.Id,
                       Ma = a.Ma,
                       Ten = a.Ten,
                       TrangThai = a.TrangThai,
                   }).ToList();
            return lst;
        }

        public List<LoaiDichVuViews> GetAll(string value)
        {
            List<LoaiDichVuViews> lst = new List<LoaiDichVuViews>();
            lst = (from a in _iloaidvrepository.GetAll()
                   select new LoaiDichVuViews
                   {
                       Id = a.Id,
                       Ma = a.Ma,
                       Ten = a.Ten,
                       TrangThai = a.TrangThai,
                   }).ToList();
            return lst;
        }

        public string Update(LoaiDichVuViews obj)
        {
            if (obj == null)  return "Thất bại";
            var a = new LoaiDichVu()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
                TrangThai = obj.TrangThai,
            };
            if (_iloaidvrepository.Update(a)) return "Thành công";
            return "Thất bại";
        }
    }
}
