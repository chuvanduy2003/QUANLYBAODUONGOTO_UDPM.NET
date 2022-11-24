using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2_BUS.IServices
{
    public interface IXeServices
    {
        string Add(XeViews obj);
        string Update(XeViews obj);
        string Delete(XeViews obj);
        List<XeViews> GetAll();
        List<XeViews> GetAll(string input)  ;
    }
}
