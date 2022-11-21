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
    public partial class ChucVu : Form
    {
        IChucVuServices _chucVuServices;
        private Guid _id;
        public ChucVu()
        {
            InitializeComponent();
            _chucVuServices = new ChucVuServices();
        }
        private void LoadData()
        {
            int stt = 1;
            dtg_hienthi.ColumnCount = 4;
            dtg_hienthi.Columns[0].Name = "STT";
            dtg_hienthi.Columns[1].Name = "ID";
            dtg_hienthi.Columns[1].Visible = false;
            dtg_hienthi.Columns[2].Name = "MÃ";
            dtg_hienthi.Columns[3].Name = "TÊN";
            dtg_hienthi.Rows.Clear();
            foreach (var item in _chucVuServices.GetAll())
            {
                dtg_hienthi.Rows.Add(stt++, item.Id, item.Ma, item.Ten);
            }
        }
        public ChucVuViews GetData()
        {
            ChucVuViews cv = new ChucVuViews()
            {
                Id = Guid.Empty,
                Ma = txt_machucvu.Text,
                Ten = txt_tenchucvu.Text,
            };
            return cv;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_chucVuServices.Add(GetData()));
            LoadData();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            var temp = GetData();
            temp.Id = _id;
            MessageBox.Show(_chucVuServices.Update(temp));
            LoadData();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            var temp = GetData();
            temp.Id = _id;
            MessageBox.Show(_chucVuServices.Delete(temp));
            LoadData();
        }

        private void dtg_hienthi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _id = Guid.Parse(dtg_hienthi.CurrentRow.Cells[1].Value.ToString());
            var temp =_chucVuServices.GetAll().FirstOrDefault(c => c.Id == _id);
            txt_machucvu.Text = temp.Ma;
            txt_tenchucvu.Text = temp.Ten;
        }
    }
}
