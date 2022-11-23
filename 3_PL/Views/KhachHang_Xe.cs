using _2_BUS.IServices;
using _2_BUS.Services;
using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace _3_PL.Views
{
    public partial class KhachHang_Xe : Form
    {
        IKhachHangServices _ikhservice;
        IXeServices _ixeservice;
        Guid _id;
        
        public KhachHang_Xe()
        {
            InitializeComponent();
            _ikhservice = new KhachHangServices();
            _ixeservice = new XeServices();
           
            LoadData();
            LoadStatusKhachHang();
            LoadTime();
            LoadStatusXe();
        }
        public void LoadStatusKhachHang()
        {
            cmb_status.Items.Clear();
            cmb_status.Items.Add("Trạng thái");
            cmb_status.Items.Add("Mới");
            cmb_status.Items.Add("Cũ");
        }
        public void LoadStatusXe()
        {
            cmb_statusxe.Items.Add("Trạng thái");
            cmb_statusxe.Items.Add("Bảo dưỡng");
            cmb_statusxe.Items.Add("Sửa chữa");
        }
        public void LoadTime()
        {
            cmb_time.Items.Clear();
            cmb_time.Items.Add("7h30 - 8h30");
            cmb_time.Items.Add("8h50-9h50");
            cmb_time.Items.Add("10h-11h");
        }
        //public void LoadData1()
        //{
        //    dgrid_khachhang_xe.ColumnCount = 6;
        //    int stt = 1;
        //    dgrid_khachhang_xe.Columns[0].Name = "STT";

        //}
        public void LoadData()
        {
            dgrid_khachhang_xe.ColumnCount = 10;
            int stt = 1;
            dgrid_khachhang_xe.Columns[0].Name = "ID";
            dgrid_khachhang_xe.Columns[0].Visible = false;
            dgrid_khachhang_xe.Columns[1].Name = "Mã";
            dgrid_khachhang_xe.Columns[2].Name = "STT";
            dgrid_khachhang_xe.Columns[3].Name = "Họ và tên";
            dgrid_khachhang_xe.Columns[4].Name = "Số điện thoại";
            dgrid_khachhang_xe.Columns[5].Name = "Địa chỉ";
            dgrid_khachhang_xe.Columns[6].Name = "Trạng thái";
            dgrid_khachhang_xe.Columns[7].Name = "Khung giờ";
            dgrid_khachhang_xe.Columns[8].Name = "Biển số";
            dgrid_khachhang_xe.Columns[9].Name = "Trạng thái";
            dgrid_khachhang_xe.Rows.Clear();
            foreach (var item in _ixeservice.GetAll())
            {
                dgrid_khachhang_xe.Rows.Add(item.IdKH,item.Ma,stt++, item.TenKH, /*item.SDT, item.DiaChiKH, item.TrangThaiKH==1?"Mới":"Cũ", item.KhungGio,*/ item.BienSo, item.TrangThai==1?"Bảo dưỡng":"Sửa chữa");
            }
        }
        public KhachHangViews GetDataKHFromGui()
        {
            var a = new KhachHangViews()
            {
                
                Ma = "CH1",
                Ten = txt_name.Text,
                SDT = txt_numberphone.Text,
                DiaChi = txt_address.Text,
                TrangThai = cmb_status.SelectedIndex,
                KhungGio=Convert.ToString(cmb_time.SelectedItem),
            };
            return a;
        }

        void AddKH()
        {
            MessageBox.Show(_ikhservice.Add(GetDataKHFromGui())) ;
        }
        public XeViews GetDataXeFromGui()
        {
            return new XeViews()
            {
                //Id = Guid.NewGuid(),
                IdKH=GetDataKHFromGui().Id,//,_ikhservice.GetAll().Select((p=>p.Id))
                Ma = "X1",
                BienSo = txt_bienso.Text,
                TrangThai = cmb_statusxe.SelectedIndex,
                //TenKH=Convert.ToString(_ikhservice.GetAll().Select(c=>c.Ten)),
            };
        }

        
        private void btn_them_Click(object sender, EventArgs e)
        {
            AddKH();
            MessageBox.Show(_ixeservice.Add(GetDataXeFromGui()));
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var a = GetDataKHFromGui();
            a.Id = _id;
            _ikhservice.Delete(a);
            var obj = GetDataXeFromGui();
            obj.Id = _id;
            MessageBox.Show(_ixeservice.Delete(obj));
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            var a = GetDataKHFromGui();
            a.Id = _id;
            _ikhservice.Update(a);
            var obj = GetDataXeFromGui();
            obj.Id = _id;
            MessageBox.Show(_ixeservice.Update(obj));
        }

        //private void dgrid_khachhang_xe_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    int r = e.RowIndex;
        //    if()
        //}
    }
}
