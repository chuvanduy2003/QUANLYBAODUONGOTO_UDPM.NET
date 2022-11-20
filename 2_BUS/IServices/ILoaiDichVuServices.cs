using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2_BUS.IServices
{
    public interface ILoaiDichVuServices
    {
        string Add(LoaiDichVuViews obj);
        string Update(LoaiDichVuViews obj);
        string Delete(LoaiDichVuViews obj);
        List<LoaiDichVuViews> GetAll();
    }
}
