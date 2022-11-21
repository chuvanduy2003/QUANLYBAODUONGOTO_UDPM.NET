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
    public class ChucVuServices : IChucVuServices
    {
        IChucVuRepository _ichucvurepository;
        public ChucVuServices()
        {
            _ichucvurepository = new ChucVuRepository();
        }
        public string Add(ChucVuViews obj)
        {
            if (obj == null) return "Thất bại";
            var a = new ChucVu()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
            };
            if (_ichucvurepository.Add(a)) return "Thành Công";
            return "Thất bại";
        }

        public string Delete(ChucVuViews obj)
        {
            if (obj == null) return "Thất bại";
            var a = new ChucVu()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
            };
            if (_ichucvurepository.Delete(a)) return "Thành Công";
            return "Thất bại";
        }

        public List<ChucVuViews> GetAll()
        {
            List<ChucVuViews> lst = new List<ChucVuViews>();
            lst = (from a in _ichucvurepository.GetAll()
                   select new ChucVuViews
                   {
                       Id = a.Id,
                       Ma = a.Ma,
                       Ten = a.Ten,
                   }).ToList();
            return lst;
        }

        public string Update(ChucVuViews obj)
        {
            if (obj == null) return "Thất bại";
            var a = new ChucVu()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
            };
            if (_ichucvurepository.Update(a)) return "Thành Công";
            return "Thất bại";
        }
    }
}
