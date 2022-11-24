using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2_BUS.IServices
{
    public interface IDichVuServices
    {
        string Add(DichVuViews obj);
        string Update(DichVuViews obj);
        string Delete(DichVuViews obj);
        List<DichVuViews> GetAll(string a);
        List<DichVuViews> GetAll();
    }
}
