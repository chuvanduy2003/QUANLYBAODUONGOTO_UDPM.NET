using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2_BUS.IServices
{
    public interface INhanVienServices
    {
        string Add(NhanVienViews obj);
        string Update(NhanVienViews obj);
        string Delete(NhanVienViews obj);
        List<NhanVienViews> GetAll();
        List<NhanVienViews> GetAll(string a);
    }
}
