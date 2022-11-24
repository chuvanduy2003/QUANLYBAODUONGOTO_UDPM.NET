namespace _3_PL.Views
{
    partial class Xe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgrid_xe = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ma = new System.Windows.Forms.TextBox();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.txt_bienso = new System.Windows.Forms.TextBox();
            this.cmb_khachhang = new System.Windows.Forms.ComboBox();
            this.rbtn_baoduong = new System.Windows.Forms.RadioButton();
            this.rbtn_suachua = new System.Windows.Forms.RadioButton();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_xe)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1039, 5);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1034, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 558);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 558);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(5, 558);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1029, 5);
            this.panel4.TabIndex = 1;
            // 
            // dgrid_xe
            // 
            this.dgrid_xe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_xe.Location = new System.Drawing.Point(7, 294);
            this.dgrid_xe.Name = "dgrid_xe";
            this.dgrid_xe.RowHeadersWidth = 62;
            this.dgrid_xe.RowTemplate.Height = 33;
            this.dgrid_xe.Size = new System.Drawing.Size(1020, 258);
            this.dgrid_xe.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Trạng thái";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Biển số";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(450, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "XE";
            // 
            // txt_ma
            // 
            this.txt_ma.ForeColor = System.Drawing.Color.Black;
            this.txt_ma.Location = new System.Drawing.Point(120, 32);
            this.txt_ma.Name = "txt_ma";
            this.txt_ma.Size = new System.Drawing.Size(301, 31);
            this.txt_ma.TabIndex = 8;
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(611, 204);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(384, 31);
            this.txt_timkiem.TabIndex = 9;
            this.txt_timkiem.Text = "Tìm kiếm...";
            this.txt_timkiem.Click += new System.EventHandler(this.txt_timkiem_Click);
            this.txt_timkiem.TextChanged += new System.EventHandler(this.txt_timkiem_TextChanged);
            this.txt_timkiem.Leave += new System.EventHandler(this.txt_timkiem_Leave);
            // 
            // txt_bienso
            // 
            this.txt_bienso.ForeColor = System.Drawing.Color.Black;
            this.txt_bienso.Location = new System.Drawing.Point(120, 79);
            this.txt_bienso.Name = "txt_bienso";
            this.txt_bienso.Size = new System.Drawing.Size(301, 31);
            this.txt_bienso.TabIndex = 10;
            // 
            // cmb_khachhang
            // 
            this.cmb_khachhang.FormattingEnabled = true;
            this.cmb_khachhang.Location = new System.Drawing.Point(120, 138);
            this.cmb_khachhang.Name = "cmb_khachhang";
            this.cmb_khachhang.Size = new System.Drawing.Size(301, 33);
            this.cmb_khachhang.TabIndex = 11;
            // 
            // rbtn_baoduong
            // 
            this.rbtn_baoduong.AutoSize = true;
            this.rbtn_baoduong.Location = new System.Drawing.Point(110, 213);
            this.rbtn_baoduong.Name = "rbtn_baoduong";
            this.rbtn_baoduong.Size = new System.Drawing.Size(126, 29);
            this.rbtn_baoduong.TabIndex = 12;
            this.rbtn_baoduong.TabStop = true;
            this.rbtn_baoduong.Text = "Bảo dưỡng";
            this.rbtn_baoduong.UseVisualStyleBackColor = true;
            // 
            // rbtn_suachua
            // 
            this.rbtn_suachua.AutoSize = true;
            this.rbtn_suachua.Location = new System.Drawing.Point(309, 213);
            this.rbtn_suachua.Name = "rbtn_suachua";
            this.rbtn_suachua.Size = new System.Drawing.Size(110, 29);
            this.rbtn_suachua.TabIndex = 13;
            this.rbtn_suachua.TabStop = true;
            this.rbtn_suachua.Text = "Sửa chữa";
            this.rbtn_suachua.UseVisualStyleBackColor = true;
            // 
            // btn_them
            // 
            this.btn_them.ForeColor = System.Drawing.Color.Black;
            this.btn_them.Location = new System.Drawing.Point(578, 47);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(112, 34);
            this.btn_them.TabIndex = 14;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.ForeColor = System.Drawing.Color.Black;
            this.btn_sua.Location = new System.Drawing.Point(716, 85);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(112, 34);
            this.btn_sua.TabIndex = 15;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.ForeColor = System.Drawing.Color.Black;
            this.btn_xoa.Location = new System.Drawing.Point(883, 137);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(112, 34);
            this.btn_xoa.TabIndex = 16;
            this.btn_xoa.Text = "Xoá";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // Xe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.ClientSize = new System.Drawing.Size(1039, 563);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.rbtn_suachua);
            this.Controls.Add(this.rbtn_baoduong);
            this.Controls.Add(this.cmb_khachhang);
            this.Controls.Add(this.txt_bienso);
            this.Controls.Add(this.txt_timkiem);
            this.Controls.Add(this.txt_ma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgrid_xe);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Xe";
            this.Text = "Xe";
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_xe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgrid_xe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ma;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.TextBox txt_bienso;
        private System.Windows.Forms.ComboBox cmb_khachhang;
        private System.Windows.Forms.RadioButton rbtn_baoduong;
        private System.Windows.Forms.RadioButton rbtn_suachua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
    }
}