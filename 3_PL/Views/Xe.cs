using _2_BUS.IServices;
using _2_BUS.Services;
using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _3_PL.Views
{
    
    public partial class Xe : Form
    {
        IXeServices _ixeservices;
        IKhachHangServices _ikhservices;
        Guid _id;
        public Xe()
        {
            InitializeComponent();
            _ixeservices=new XeServices();
            _ikhservices = new KhachHangServices();
            LoadKH();
            LoadData(null)   ;
        }
        public void LoadKH()
        {
            cmb_khachhang.Items.Clear();
            cmb_khachhang.Items.Add("Khách hàng");
            foreach (var item in _ikhservices.GetAll())
            {
                cmb_khachhang.Items.Add(item.HoTen);
            }
            cmb_khachhang.SelectedIndex = 0;
        }
        public void LoadData(string input)
        {
            dgrid_xe.ColumnCount = 6;
            int stt = 1;
            dgrid_xe.Columns[0].Name = "ID";
            dgrid_xe.Columns[0].Visible = false;
            dgrid_xe.Columns[1].Name = "STT";
            dgrid_xe.Columns[2].Name = "Mã";
            dgrid_xe.Columns[3].Name = "Biển số";
            dgrid_xe.Columns[4].Name = "Khách Hàng";
            dgrid_xe.Columns[5].Name = "Trạng thái";
            dgrid_xe.Rows.Clear();
            foreach (var x in _ixeservices.GetAll(input))
            {
                dgrid_xe.Rows.Add(x.Id, stt++, x.Ma, x.BienSo, x.TenKH, x.TrangThai == 1 ? "Bảo dưỡng" : "Sửa chữa");
            }
        }
        XeViews GetDataFromGui()
        {
            return new XeViews()
            {
                Id = Guid.Empty,
                Ma = txt_ma.Text,
                BienSo = txt_bienso.Text,
                IdKH =  _ikhservices.GetAll()[cmb_khachhang.SelectedIndex - 1].Id,
                TrangThai = rbtn_baoduong.Checked ? 1 : 0,
            };
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_ixeservices.Add(GetDataFromGui()));
            LoadData(null);
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            var obj=GetDataFromGui();
            obj.Id = _id;
            MessageBox.Show(_ixeservices.Update(obj));
            LoadData(null);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            var obj = GetDataFromGui();
            obj.Id = _id;
            MessageBox.Show(_ixeservices.Delete(obj));
            LoadData(null);
        }

        private void dgrid_xe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;

            if (r == -1) return;
            _id = Guid.Parse(dgrid_xe.Rows[r].Cells[0].Value.ToString());
            var temp = _ixeservices.GetAll().FirstOrDefault(c => c.Id == _id);

            txt_ma.Text = temp.Ma;
            txt_bienso.Text = temp.BienSo;
            cmb_khachhang.SelectedItem = temp.TenKH;
            if (temp.TrangThai == 1)
            {
                rbtn_baoduong.Checked = true;
            }
            if (temp.TrangThai == 0)
            {
                rbtn_suachua.Checked = true;
            }
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            LoadData(textBox3.Text);
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            textBox3.Text = "Tìm kiếm...";
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }
    }
}
