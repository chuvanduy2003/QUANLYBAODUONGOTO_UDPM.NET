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
    public partial class DichVu : Form
    {
        IDichVuServices _idichVuServices;
        ILoaiDichVuServices _iloaiDichVuServices;
        private Guid _id;
        public DichVu()
        {
            InitializeComponent();
            _idichVuServices = new DichVuServices();
            _iloaiDichVuServices = new LoaiDichVuSrevices();
            LoaiDichVU();
            LoadData();
        }
        public void LoaiDichVU()
        {
            foreach (var item in _iloaiDichVuServices.GetAll())
            {
                cmb_loaidichvu.Items.Add(item.Ten);
            }
        }

        private void LoadData()
        {
            int stt = 1;
            dtg_dichvu.ColumnCount = 6;
            dtg_dichvu.Columns[0].Name = "ID";
            dtg_dichvu.Columns[1].Name = "Tên";
            dtg_dichvu.Columns[2].Name = "Giá";
            dtg_dichvu.Columns[3].Name = "Thời gian HTDV";
            dtg_dichvu.Columns[4].Name = "Loai DV";
            dtg_dichvu.Columns[5].Name = "Trang thai";
            dtg_dichvu.Rows.Clear();
            foreach (var item in _idichVuServices.GetAll())
            {
                dtg_dichvu.Rows.Add(item.Id,item.Ten,item.Gia,item.ThoiGianHT,item.TenLDV,item.TrangThai == 1? "Đang hoạt động ":"Chưa hoạt động ");
            }
        }
        private void TimKiem(string a)
        {
            int stt = 1;
            dtg_dichvu.ColumnCount = 6;
            dtg_dichvu.Columns[0].Name = "ID";
            dtg_dichvu.Columns[1].Name = "Tên";
            dtg_dichvu.Columns[2].Name = "Giá";
            dtg_dichvu.Columns[3].Name = "Thời gian HTDV";
            dtg_dichvu.Columns[4].Name = "Loai DV";
            dtg_dichvu.Columns[5].Name = "Trang thai";
            dtg_dichvu.Rows.Clear();
            foreach (var item in _idichVuServices.GetAll(a))
            {
                dtg_dichvu.Rows.Add(item.Id, item.Ten, item.Gia, item.ThoiGianHT, item.TenLDV, item.TrangThai == 1 ? "Đang hoạt động " : "Chưa hoạt động ");
            }
        }
        public DichVuViews GetData()
        {
            DichVuViews dv = new DichVuViews()
            {
                Id = Guid.Empty,
                IdLDV = _iloaiDichVuServices.GetAll().FirstOrDefault(c=> c.Ten == cmb_loaidichvu.Text).Id,
                Ma = txt_madv.Text,
                Ten = txt_tendichvu.Text,
                Gia = float.Parse(txt_gia.Text),
                ThoiGianHT = dtp_thoigianhtdv.Value,
                TrangThai = Convert.ToInt32(rbn_hoatdong.Checked)
            };
            return dv;
        }

        private void btn_themdv_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show(_idichVuServices.Add(GetData()));
            LoadData();
        }

        private void btn_suadv_Click(object sender, EventArgs e)
        {
            var temp = GetData();
            temp.Id = _id;
            MessageBox.Show(_idichVuServices.Update(temp));
            LoadData();
        }

        private void btn_xoadv_Click(object sender, EventArgs e)
        {
            var temp = GetData();
            temp.Id = _id;
            MessageBox.Show(_idichVuServices.Delete(temp));
            LoadData();
        }

        private void btn_timkiemdv_Click(object sender, EventArgs e)
        {
            TimKiem(txt_timkiem.Text);
           
        }

        private void dtg_dichvu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _id = Guid.Parse(dtg_dichvu.CurrentRow.Cells[0].Value.ToString());
            var temp = _idichVuServices.GetAll().FirstOrDefault(c => c.Id == _id);
            txt_tendichvu.Text = temp.Ten;
            txt_gia.Text = temp.Gia.ToString();
            dtp_thoigianhtdv.Value = temp.ThoiGianHT;
            cmb_loaidichvu.Text=temp.TenLDV;
            if (temp.TrangThai == 1)
            {
                rbn_hoatdong.Checked = true;
                return;
            }
            rbn_chuahoatdong.Checked = true;

        }
    }
}
