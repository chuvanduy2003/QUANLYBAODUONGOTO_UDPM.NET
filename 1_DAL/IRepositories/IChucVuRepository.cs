using _1_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_DAL.IRepositories
{
    public interface IChucVuRepository
    {
        public bool Add(ChucVu obj);
        public bool Update(ChucVu obj);
        public bool Delete(ChucVu obj);
        public List<ChucVu> GetAll();
    }
}
