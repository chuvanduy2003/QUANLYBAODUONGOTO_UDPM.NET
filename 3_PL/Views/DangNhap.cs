using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using _2_BUS.Services;
using _2_BUS.IServices;
using System.Linq;
using System.Data.SqlClient;

namespace _3_PL.Views
{
    public partial class DangNhap : Form
    {
        INhanVienServices _inhanvienservices;
        public DangNhap()
        {
            InitializeComponent();
            _inhanvienservices = new NhanVienServices();
            LoadTaiKhoan();
        }

        private void LoadTaiKhoan()
        {
            foreach (var item in _inhanvienservices.GetAll())
            {
               string  tknv = item.TenDangNhap;
               string  mknv = item.MatKhau;
            }
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            string tkql = "quanly";
            string mkql = "quanly";
            if (txt_taikhoan.Text == tkql && txt_matkhau.Text == mkql)
            {
                MessageBox.Show(" dang nhap la quan ly ");
            }
            else
            {
                SqlConnection conn = new SqlConnection(@"Data Source=PC-DAT\SQLEXPRESS02;Initial Catalog=KOC_BMW;Integrated Security=True");
                try
                {
                    conn.Open();
                    string tknv = txt_taikhoan.Text;
                    string mknv = txt_matkhau.Text;
                    string sql = "select * from NhanVien where TenDangNhap" + tknv + " and MatKhau" + mknv + "";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader dta = cmd.ExecuteReader();
                    if (dta.Read() == true)
                    {
                        MessageBox.Show("dang nhap la nhan vien ");
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show("fail");
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            //label2.BackColor = Color.White;
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            //label2.BackColor = Color.White;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            //label2.BackColor = Color.White;
        }

        private void btn_dangnhap_MouseEnter(object sender, EventArgs e)
        {
        }
    }
}
