using _1_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_DAL.IRepositories
{
    public interface IXeRepository
    {
        public bool Add(Xe obj);
        public bool Update(Xe obj);
        public bool Delete(Xe obj);
        public List<Xe> GetAll();
    }
}
