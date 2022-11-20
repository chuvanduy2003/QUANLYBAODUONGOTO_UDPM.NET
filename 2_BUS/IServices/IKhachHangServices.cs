using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2_BUS.IServices
{
    public interface IKhachHangServices
    {
        string Add(KhachHangViews obj);
        string Update(KhachHangViews obj);
        string Delete(KhachHangViews obj);
        List<KhachHangViews> GetAll();
    }
}
