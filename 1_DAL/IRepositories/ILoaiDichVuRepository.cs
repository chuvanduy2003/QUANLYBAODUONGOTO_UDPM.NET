using _1_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_DAL.IRepositories
{
    public interface ILoaiDichVuRepository
    {
        public bool Add(LoaiDichVu obj);
        public bool Update(LoaiDichVu obj);
        public bool Delete(LoaiDichVu obj);
        public List<LoaiDichVu> GetAll();
    }
}
