using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2_BUS.IServices
{
    public interface IChucVuServices
    {
        string Add(ChucVuViews obj);
        string Update(ChucVuViews obj);
        string Delete(ChucVuViews obj);
        List<ChucVuViews> GetAll();
    }
}
