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
    public partial class NhanVien : Form
    {
        INhanVienServices _nhanVienServices;
        IChucVuServices _chucVuServices;
        private Guid _id;
        
        public NhanVien()
        {
            InitializeComponent();
            _nhanVienServices = new NhanVienServices();
            _chucVuServices = new ChucVuServices();
            LoadChucVu();
            LoadData();
        }
        public void LoadChucVu()
        {
            foreach (var item in _chucVuServices.GetAll())
            {
                cbb_chucvu.Items.Add(item.Ten);
                
            }
        }
        private void LoadData()
        {
            int stt = 1;
            dtg_hienthi.ColumnCount = 11;
            dtg_hienthi.Columns[0].Name = "STT";
            dtg_hienthi.Columns[1].Name = "ID";
            dtg_hienthi.Columns[1].Visible = false;
            dtg_hienthi.Columns[2].Name = "MÃ";
            dtg_hienthi.Columns[3].Name = "HỌ VÀ TÊN";
            dtg_hienthi.Columns[4].Name = "SĐT";
            dtg_hienthi.Columns[5].Name = "ĐỊA CHỈ";
            dtg_hienthi.Columns[6].Name = "THÀNH PHỐ";
            dtg_hienthi.Columns[7].Name = "CHỨC VỤ";
            dtg_hienthi.Columns[8].Name = "TÊN ĐĂNG NHẬP";
            dtg_hienthi.Columns[9].Name = "MẬT KHẨU";
            dtg_hienthi.Columns[10].Name = "TRẠNG THÁI";
            dtg_hienthi.Rows.Clear();
            foreach (var item in _nhanVienServices.GetAll())
            {
                dtg_hienthi.Rows.Add(stt++, item.Id, item.Ma, item.Ho + " " + item.TenDem + " " + item.Ten, item.SDT, item.DiaChi, item.ThanhPho, item.TenCV, item.TenDangNhap, item.MatKhau, item.TrangThai == 1 ? "Đang làm việc" : "Đã nghỉ việc");
            }
        }
        private void TimKiem(string a)
        {
            int stt = 1;
            dtg_hienthi.ColumnCount = 11;
            dtg_hienthi.Columns[0].Name = "STT";
            dtg_hienthi.Columns[1].Name = "ID";
            dtg_hienthi.Columns[1].Visible = false;
            dtg_hienthi.Columns[2].Name = "MÃ";
            dtg_hienthi.Columns[3].Name = "HỌ VÀ TÊN";
            dtg_hienthi.Columns[4].Name = "SĐT";
            dtg_hienthi.Columns[5].Name = "ĐỊA CHỈ";
            dtg_hienthi.Columns[6].Name = "THÀNH PHỐ";
            dtg_hienthi.Columns[7].Name = "CHỨC VỤ";
            dtg_hienthi.Columns[8].Name = "TÊN ĐĂNG NHẬP";
            dtg_hienthi.Columns[9].Name = "MẬT KHẨU";
            dtg_hienthi.Columns[10].Name = "TRẠNG THÁI";
            dtg_hienthi.Rows.Clear();
            foreach (var item in _nhanVienServices.GetAll(a))
            {
                dtg_hienthi.Rows.Add(stt++, item.Id, item.Ma, item.Ho + " " + item.TenDem + " " + item.Ten, item.SDT, item.DiaChi, item.ThanhPho, item.TenCV, item.TenDangNhap, item.MatKhau, item.TrangThai == 1 ? "Đang làm việc" : "Đã nghỉ việc");
            }
        }
        public NhanVienViews GetData()
        {
            NhanVienViews nv = new NhanVienViews()
            {
                Id = Guid.Empty,
                IdCV = _chucVuServices.GetAll().FirstOrDefault(c=>c.Ten== cbb_chucvu.Text).Id,
                Ma = txt_manhanvien.Text,
                Ho = txt_ho.Text,
                TenDem = txt_tendem.Text,
                Ten = txt_ten.Text,
                SDT = txt_sodienthoai.Text,
                DiaChi = txt_diachi.Text,
                ThanhPho = txt_thanhpho.Text,
                TenDangNhap = txt_tendangnhap.Text,
                MatKhau = txt_matkhau.Text,
                TenCV = cbb_chucvu.Text,
                TrangThai = Convert.ToInt32(rdb_danglamviec.Checked),
            };
            return nv;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_nhanVienServices.Add(GetData()));
            LoadData();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            var temp = GetData();
            temp.Id = _id;
            MessageBox.Show(_nhanVienServices.Update(temp));
            LoadData();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            var temp = GetData();
            temp.Id = _id;
            MessageBox.Show(_nhanVienServices.Delete(temp));
            LoadData();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            TimKiem(txt_timkiem.Text);
        }

        private void dtg_hienthi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _id = Guid.Parse(dtg_hienthi.CurrentRow.Cells[1].Value.ToString());
            var temp = _nhanVienServices.GetAll().FirstOrDefault(c => c.Id == _id);
            txt_manhanvien.Text = temp.Ma;
            txt_ho.Text = temp.Ho;
            txt_tendem.Text = temp.TenDem;
            txt_ten.Text = temp.Ten;
            txt_sodienthoai.Text = temp.SDT;
            txt_diachi.Text = temp.DiaChi;
            txt_thanhpho.Text = temp.ThanhPho;
            txt_tendangnhap.Text = temp.TenDangNhap;
            txt_matkhau.Text = temp.MatKhau;
            cbb_chucvu.SelectedIndex = cbb_chucvu.FindStringExact(_chucVuServices.GetAll().FirstOrDefault(c => c.Id == temp.IdCV).Ten.ToString());
            if (temp.TrangThai == 1)
            {
                rdb_danglamviec.Checked = true;
                return ;
            }
            rdb_danghiviec.Checked = true;

        }
    }
}
