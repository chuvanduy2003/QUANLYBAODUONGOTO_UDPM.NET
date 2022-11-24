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
    public partial class LoaiDichVu : Form
    {
        ILoaiDichVuServices _iloaidvServices;
        private Guid _id;
        public LoaiDichVu()
        {
            InitializeComponent();
            _iloaidvServices = new LoaiDichVuSrevices();
            LoadData();

        }
       

        private void LoadData()
        {
            int stt = 1;
            dtg_loaidichvu.ColumnCount = 4;
            dtg_loaidichvu.Columns[0].Name = "ID";
            dtg_loaidichvu.Columns[0].Visible = false;
            dtg_loaidichvu.Columns[1].Name = "Mã ";
            dtg_loaidichvu.Columns[2].Name = "Tên";
            dtg_loaidichvu.Columns[3].Name = "Trạng thái ";
            dtg_loaidichvu.Rows.Clear();
            foreach (var item in _iloaidvServices.GetAll())
            {
                dtg_loaidichvu.Rows.Add(item.Id, item.Ma, item.Ten, item.TrangThai == 1 ? "Hoạt động " : " Chưa hoạt động ");
                
            }
        }
        public LoaiDichVuViews GetData()
        {
            LoaiDichVuViews ldv = new LoaiDichVuViews()
            {
                Id = Guid.Empty,
                Ma = txt_maloaidv.Text,
                Ten = txt_tenloaidv.Text,
                TrangThai = Convert.ToInt32(rbn_hoatdong.Checked)
            };
            return ldv;
        }

        private void btn_themloaidv_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_iloaidvServices.Add(GetData()));
            LoadData();
        }

        private void btn_sualoaidv_Click(object sender, EventArgs e)
        {
            var temp = GetData();
            temp.Id = _id;
            MessageBox.Show(_iloaidvServices.Update(temp));
            LoadData();

        }

        private void btn_xoaloaidv_Click(object sender, EventArgs e)
        {
            var temp = GetData();
            temp.Ma = txt_maloaidv.Text;
            temp.Id = _iloaidvServices.GetAll().FirstOrDefault(c => c.Ma == txt_maloaidv.Text).Id;
            MessageBox.Show(_iloaidvServices.Delete(temp));
            LoadData();
        }

        private void dtg_loaidichvu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _id = Guid.Parse(dtg_loaidichvu.CurrentRow.Cells[0].Value.ToString());
            var temp = _iloaidvServices.GetAll().FirstOrDefault(c => c.Id == _id);
            txt_tenloaidv.Text = temp.Ten;
            txt_maloaidv.Text = temp.Ma;
            //cbb_trangthai.Text= temp.TrangThai.ToString();
            if (temp.TrangThai == 1 )
            {
                rbn_hoatdong.Checked = true;
                return;
            }
            rbn_chuahoatdong.Checked = true ;

        }
    }
}
