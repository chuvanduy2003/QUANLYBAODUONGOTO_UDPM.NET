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
    public partial class KhachHang : Form
    {
        IKhachHangServices _ikhservice;
        Guid _id;
        public KhachHang()
        {
            InitializeComponent();
            _ikhservice = new KhachHangServices();
            LoadData(null);
            this.dgrid_khachhang.DefaultCellStyle.ForeColor = Color.Black;
            LoadKhungGio();
        }
        public void LoadKhungGio()
        {
            cmb_gio.Items.Clear();
            cmb_gio.Items.Add("Chọn khung giờ");
            cmb_gio.Items.Add("7h30-8h30");
            cmb_gio.Items.Add("8h50-9h50");
            cmb_gio.Items.Add("10h00-11h00");
            cmb_gio.Items.Add("1h30-2h30");
            cmb_gio.SelectedIndex = 0;
        }

        public void LoadData(string input)
        {
            int stt = 1;
            dgrid_khachhang.ColumnCount = 8;
            dgrid_khachhang.Columns[0].Name = "ID";
            dgrid_khachhang.Columns[0].Visible = false;
            dgrid_khachhang.Columns[1].Name = "STT";
            dgrid_khachhang.Columns[2].Name = "Mã";
            dgrid_khachhang.Columns[3].Name = "Họ và tên";
            dgrid_khachhang.Columns[4].Name = "Số điện thoại";
            dgrid_khachhang.Columns[5].Name = "Địa chỉ";
            dgrid_khachhang.Columns[6].Name = "Trạng thái";
            dgrid_khachhang.Columns[7].Name = "Khung giờ";
            dgrid_khachhang.Rows.Clear();
            foreach (var x in _ikhservice.GetAll(input))
            {
                dgrid_khachhang.Rows.Add(x.Id, stt++, x.Ma, x.HoTen, x.SDT, x.Diachi, x.TrangThai == 0 ? "Khách hàng cũ" : "Khách hàng mới", x.KhungGio);
            }
        }

        KhachHangViews GetDataFromGui()
        {
            return new KhachHangViews()
            {
                Id = Guid.Empty,
                Ma = txt_ma.Text,//"KH"+_ikhservice.GetAll().Max()+1
                Ho = txt_ho.Text,
                Tendem = txt_tendem.Text,
                Ten = txt_ten.Text,
                SDT = txt_sdt.Text,
                DiaChi = txt_diachi.Text,
                ThanhPho = txt_thanhpho.Text,
                KhungGio = Convert.ToString(cmb_gio.SelectedItem),
                TrangThai = rbtn_cu.Checked ? 0 : 1,
            };
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn có muốn thêm không?", "Thông báo", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                MessageBox.Show(_ikhservice.Add(GetDataFromGui()));
                LoadData(null);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            var obj = GetDataFromGui();
            obj.Id = _id;
            DialogResult d = MessageBox.Show("Bạn có muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                MessageBox.Show(_ikhservice.Update(obj));
                LoadData(null);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            var obj = GetDataFromGui();
            obj.Id = _id;
            DialogResult d = MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                MessageBox.Show(_ikhservice.Delete(obj));
                LoadData(null);
            }
        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            LoadData(txt_sdt.Text);
        }

        private void dgrid_khachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r == -1) return;
            _id = Guid.Parse(dgrid_khachhang.Rows[r].Cells[0].Value.ToString());
            var obj = _ikhservice.GetAll().FirstOrDefault(c => c.Id == _id);
            txt_ho.Text = obj.Ho;
            txt_ten.Text = obj.Ten;
            txt_tendem.Text = obj.Tendem;
            txt_ma.Text = obj.Ma;
            txt_sdt.Text = obj.SDT;
            txt_thanhpho.Text = obj.ThanhPho;
            txt_diachi.Text = obj.DiaChi;
            cmb_gio.Text = obj.KhungGio;
            if (obj.TrangThai == 0)
            {
                rbtn_cu.Checked = true;
            }
            if (obj.TrangThai == 1)
            {
                rbtn_moi.Checked = true;
            }
        }

        private void txt_timkiem_Leave(object sender, EventArgs e)
        {
            txt_timkiem.Text = "Tìm kiếm...";
        }

        private void txt_timkiem_Click(object sender, EventArgs e)
        {
            txt_timkiem.Text = "";
        }
    }
}
