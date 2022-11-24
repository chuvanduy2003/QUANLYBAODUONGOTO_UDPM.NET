using _1_DAL.Entities;
using _1_DAL.IRepositories;
using _1_DAL.Repositories;
using _2_BUS.IServices;
using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
namespace _2_BUS.Services
{
    public class DichVuServices : IDichVuServices
    {

        IDichVuRepository _idichvurepository;
        ILoaiDichVuRepository _iloaidvrepository;
        public DichVuServices()
        {
            _idichvurepository = new DichVuRepository();
            _iloaidvrepository = new LoaiDichVuRepository();
        }
        public string Add(DichVuViews obj)
        {
            List<DichVu> lst = new List<DichVu>();
            if (obj == null) return "Thất bại";
           
            var a = new DichVu()
            {
                
                Id =obj.Id,
                IdLDV = obj.IdLDV,
                Ma = obj.Ma,
                Ten = obj.Ten,
                Gia = obj.Gia,
                ThoiGianHT = obj.ThoiGianHT,
            };
            if (_idichvurepository.Add(a)) return "Thành Công";
            return "Thất bại";
        }

        public string Delete(DichVuViews obj)
        {
            if (obj == null) return "Thất bại";
            var a = new DichVu()
            {
                Id = obj.Id,
                IdLDV = obj.IdLDV,
                Ma = obj.Ma,
                Ten = obj.Ten,
                Gia = obj.Gia,
                ThoiGianHT = obj.ThoiGianHT,
            };
            if (_idichvurepository.Delete(a)) return "Thành Công";
            return "Thất bại";
        }

        public List<DichVuViews> GetAll()
        {
            List<DichVuViews> lst = new List<DichVuViews>();
            lst = (from a in _idichvurepository.GetAll()
                   join b in _iloaidvrepository.GetAll() on a.IdLDV equals b.Id
                   select new DichVuViews
                   {
                       Id = a.Id,
                       Ma = a.Ma,
                       Ten = a.Ten,
                       TenLDV = b.Ten,
                       Gia = a.Gia,
                       ThoiGianHT = a.ThoiGianHT,
                   }).ToList();
            return lst;
        }

        public List<DichVuViews> GetAll(string a)
        {
            List<DichVuViews> lst = new List<DichVuViews>();
            lst = (from x in _idichvurepository.GetAll()
                   join b in _iloaidvrepository.GetAll() on x.IdLDV equals b.Id
                   select new DichVuViews
                   {
                       Id = x.Id,
                       Ma = x.Ma,
                       Ten = x.Ten,
                       TenLDV = b.Ten,
                       Gia = x.Gia,
                       ThoiGianHT = x.ThoiGianHT,
                   }).Where(c => c.Ten.Contains(a)).ToList();
            return lst;
        }

        //public List<DichVuViews> Searchh(string value)
        //{

        //    List<DichVuViews> lst = new List<DichVuViews>();
        //    lst = (from a in _idichvurepository.GetAll()
        //           join b in _iloaidvrepository.GetAll() on a.IdLDV equals b.Id
        //           select new DichVuViews
        //           {
        //               Id = a.Id,
        //               Ma = a.Ma,
        //               Ten = a.Ten,
        //               TenLDV = b.Ten,
        //               Gia = a.Gia,
        //               ThoiGianHT = a.ThoiGianHT,

        //           }).Where(c => c.Ten.Contains(value)).ToList();
        //    return lst;
        //}


        public string Update(DichVuViews obj)
        {
            if (obj == null) return "Thất bại";
            var a = new DichVu()
            {
                Id = obj.Id,
                IdLDV = obj.IdLDV,
                Ma = obj.Ma,
                Ten = obj.Ten,
                Gia = obj.Gia,
                ThoiGianHT = obj.ThoiGianHT,
            };
            if (_idichvurepository.Update(a)) return "Thành Công";
            return "Thất bại";
        }
        
    }
}
