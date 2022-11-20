using _1_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_DAL.IRepositories
{
    public interface IDichVuRepository
    {
        public bool Add(DichVu obj);
        public bool Update(DichVu obj);
        public bool Delete(DichVu obj);
        public List<DichVu> GetAll();
    }
}
