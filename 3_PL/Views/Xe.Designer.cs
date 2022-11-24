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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgrid_xe = new System.Windows.Forms.DataGridView();
            this.txt_bienso = new System.Windows.Forms.TextBox();
            this.cmb_khachhang = new System.Windows.Forms.ComboBox();
            this.rbtn_baoduong = new System.Windows.Forms.RadioButton();
            this.rbtn_suachua = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ma = new System.Windows.Forms.TextBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_xe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(3, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Biển số";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(3, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Khách Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(10, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Trạng thái";
            // 
            // dgrid_xe
            // 
            this.dgrid_xe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_xe.Location = new System.Drawing.Point(3, 284);
            this.dgrid_xe.Name = "dgrid_xe";
            this.dgrid_xe.RowHeadersWidth = 62;
            this.dgrid_xe.RowTemplate.Height = 33;
            this.dgrid_xe.Size = new System.Drawing.Size(1027, 273);
            this.dgrid_xe.TabIndex = 3;
            this.dgrid_xe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_xe_CellClick);
            // 
            // txt_bienso
            // 
            this.txt_bienso.Location = new System.Drawing.Point(166, 76);
            this.txt_bienso.Name = "txt_bienso";
            this.txt_bienso.Size = new System.Drawing.Size(297, 31);
            this.txt_bienso.TabIndex = 4;
            // 
            // cmb_khachhang
            // 
            this.cmb_khachhang.FormattingEnabled = true;
            this.cmb_khachhang.Location = new System.Drawing.Point(166, 138);
            this.cmb_khachhang.Name = "cmb_khachhang";
            this.cmb_khachhang.Size = new System.Drawing.Size(295, 33);
            this.cmb_khachhang.TabIndex = 5;
            // 
            // rbtn_baoduong
            // 
            this.rbtn_baoduong.AutoSize = true;
            this.rbtn_baoduong.ForeColor = System.Drawing.SystemColors.Control;
            this.rbtn_baoduong.Location = new System.Drawing.Point(166, 193);
            this.rbtn_baoduong.Name = "rbtn_baoduong";
            this.rbtn_baoduong.Size = new System.Drawing.Size(126, 29);
            this.rbtn_baoduong.TabIndex = 6;
            this.rbtn_baoduong.TabStop = true;
            this.rbtn_baoduong.Text = "Bảo dưỡng";
            this.rbtn_baoduong.UseVisualStyleBackColor = true;
            // 
            // rbtn_suachua
            // 
            this.rbtn_suachua.AutoSize = true;
            this.rbtn_suachua.ForeColor = System.Drawing.SystemColors.Control;
            this.rbtn_suachua.Location = new System.Drawing.Point(322, 195);
            this.rbtn_suachua.Name = "rbtn_suachua";
            this.rbtn_suachua.Size = new System.Drawing.Size(110, 29);
            this.rbtn_suachua.TabIndex = 7;
            this.rbtn_suachua.TabStop = true;
            this.rbtn_suachua.Text = "Sửa chữa";
            this.rbtn_suachua.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(12, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mã";
            // 
            // txt_ma
            // 
            this.txt_ma.Location = new System.Drawing.Point(166, 22);
            this.txt_ma.Name = "txt_ma";
            this.txt_ma.Size = new System.Drawing.Size(297, 31);
            this.txt_ma.TabIndex = 9;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(809, 25);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(112, 34);
            this.btn_them.TabIndex = 10;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(809, 85);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(112, 34);
            this.btn_sua.TabIndex = 11;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(809, 149);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(112, 34);
            this.btn_xoa.TabIndex = 12;
            this.btn_xoa.Text = "Xoá";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(483, 240);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(393, 31);
            this.textBox3.TabIndex = 13;
            this.textBox3.Text = "Tìm kiếm....";
            this.textBox3.Click += new System.EventHandler(this.textBox3_Click);
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.textBox3.Leave += new System.EventHandler(this.textBox3_Leave);
            // 
            // Xe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.ClientSize = new System.Drawing.Size(1039, 563);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.txt_ma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rbtn_suachua);
            this.Controls.Add(this.rbtn_baoduong);
            this.Controls.Add(this.cmb_khachhang);
            this.Controls.Add(this.txt_bienso);
            this.Controls.Add(this.dgrid_xe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Xe";
            this.Text = "Xe";
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_xe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgrid_xe;
        private System.Windows.Forms.TextBox txt_bienso;
        private System.Windows.Forms.ComboBox cmb_khachhang;
        private System.Windows.Forms.RadioButton rbtn_baoduong;
        private System.Windows.Forms.RadioButton rbtn_suachua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ma;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.TextBox textBox3;
    }
}