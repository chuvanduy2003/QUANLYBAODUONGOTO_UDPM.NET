using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2_BUS.IServices
{
    public interface IPhieuDichVuServices
    {
        string Add(PhieuDichVuViews obj);
        string Update(PhieuDichVuViews obj);
        string Delete(PhieuDichVuViews obj);
        List<PhieuDichVuViews> GetAll();
    }
}
