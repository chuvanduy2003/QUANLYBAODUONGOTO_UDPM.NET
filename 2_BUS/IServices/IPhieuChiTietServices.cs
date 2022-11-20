using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2_BUS.IServices
{
    public interface IPhieuChiTietServices
    {
        string Add(PhieuChiTietViews obj);
        string Update(PhieuChiTietViews obj);
        string Delete(PhieuChiTietViews obj);
        List<PhieuChiTietViews> GetAll();
    }
}
