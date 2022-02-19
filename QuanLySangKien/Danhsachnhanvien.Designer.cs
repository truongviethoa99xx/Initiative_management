namespace QuanLySangKien
{
    partial class Danhsachnhanvien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgdanhsachnhanvien = new System.Windows.Forms.DataGridView();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChucDanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiCongTac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrinhDoChuyenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.btnsua = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dTdate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.txthotennhanvien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtChucdanh = new System.Windows.Forms.TextBox();
            this.txtTrinhdo = new System.Windows.Forms.TextBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgdanhsachnhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgdanhsachnhanvien
            // 
            this.dtgdanhsachnhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgdanhsachnhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNhanVien,
            this.HoTenNhanVien,
            this.TenDangNhap,
            this.MatKhau,
            this.ChucDanh,
            this.NoiCongTac,
            this.TrinhDoChuyenMon});
            this.dtgdanhsachnhanvien.Location = new System.Drawing.Point(618, 59);
            this.dtgdanhsachnhanvien.Margin = new System.Windows.Forms.Padding(4);
            this.dtgdanhsachnhanvien.Name = "dtgdanhsachnhanvien";
            this.dtgdanhsachnhanvien.RowHeadersWidth = 62;
            this.dtgdanhsachnhanvien.Size = new System.Drawing.Size(937, 443);
            this.dtgdanhsachnhanvien.TabIndex = 37;
            this.dtgdanhsachnhanvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgdanhsachnhanvien_CellContentClick);
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.DataPropertyName = "MaNhanVien";
            this.MaNhanVien.HeaderText = "Mã Nhân Viên";
            this.MaNhanVien.MinimumWidth = 8;
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.Width = 150;
            // 
            // HoTenNhanVien
            // 
            this.HoTenNhanVien.DataPropertyName = "HoTenNhanVien";
            this.HoTenNhanVien.HeaderText = "Tên Nhân Viên";
            this.HoTenNhanVien.MinimumWidth = 8;
            this.HoTenNhanVien.Name = "HoTenNhanVien";
            this.HoTenNhanVien.Width = 150;
            // 
            // TenDangNhap
            // 
            this.TenDangNhap.DataPropertyName = "TenDangNhap";
            this.TenDangNhap.HeaderText = "Tên Đăng Nhập";
            this.TenDangNhap.MinimumWidth = 8;
            this.TenDangNhap.Name = "TenDangNhap";
            this.TenDangNhap.Width = 150;
            // 
            // MatKhau
            // 
            this.MatKhau.DataPropertyName = "MatKhau";
            this.MatKhau.HeaderText = "Mật Khẩu";
            this.MatKhau.MinimumWidth = 8;
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.Width = 150;
            // 
            // ChucDanh
            // 
            this.ChucDanh.DataPropertyName = "ChucDanh";
            this.ChucDanh.HeaderText = "Chức Danh";
            this.ChucDanh.MinimumWidth = 8;
            this.ChucDanh.Name = "ChucDanh";
            this.ChucDanh.Width = 150;
            // 
            // NoiCongTac
            // 
            this.NoiCongTac.DataPropertyName = "NoiCongTac";
            this.NoiCongTac.HeaderText = "Nơi Công Tác";
            this.NoiCongTac.MinimumWidth = 8;
            this.NoiCongTac.Name = "NoiCongTac";
            this.NoiCongTac.Width = 150;
            // 
            // TrinhDoChuyenMon
            // 
            this.TrinhDoChuyenMon.DataPropertyName = "TrinhDoChuyenMon";
            this.TrinhDoChuyenMon.HeaderText = "Trình Độ Chuyên Môn";
            this.TrinhDoChuyenMon.MinimumWidth = 8;
            this.TrinhDoChuyenMon.Name = "TrinhDoChuyenMon";
            this.TrinhDoChuyenMon.Width = 150;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(618, 24);
            this.txtMa.Margin = new System.Windows.Forms.Padding(4);
            this.txtMa.Multiline = true;
            this.txtMa.Name = "txtMa";
            this.txtMa.ReadOnly = true;
            this.txtMa.Size = new System.Drawing.Size(301, 27);
            this.txtMa.TabIndex = 36;
            this.txtMa.TextChanged += new System.EventHandler(this.txtMa_TextChanged);
            // 
            // btnsua
            // 
            this.btnsua.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnsua.Location = new System.Drawing.Point(462, 479);
            this.btnsua.Margin = new System.Windows.Forms.Padding(4);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(135, 34);
            this.btnsua.TabIndex = 34;
            this.btnsua.Text = "Sửa Thông Tin Nhân Viên";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(276, 479);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 34);
            this.button2.TabIndex = 33;
            this.button2.Text = "Xóa Nhân Viên";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(76, 479);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 34);
            this.button1.TabIndex = 32;
            this.button1.Text = "Thêm Nhân Viên ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 410);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 19);
            this.label7.TabIndex = 30;
            this.label7.Text = "Trình Độ Chuyên Môn:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 353);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 19);
            this.label6.TabIndex = 28;
            this.label6.Text = "Nơi Công Tác:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // dTdate
            // 
            this.dTdate.Location = new System.Drawing.Point(312, 287);
            this.dTdate.Margin = new System.Windows.Forms.Padding(4);
            this.dTdate.Name = "dTdate";
            this.dTdate.Size = new System.Drawing.Size(283, 27);
            this.dTdate.TabIndex = 27;
            this.dTdate.ValueChanged += new System.EventHandler(this.dtngaysinh_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 297);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 19);
            this.label5.TabIndex = 26;
            this.label5.Text = "Ngày Sinh ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(501, 181);
            this.rdNu.Margin = new System.Windows.Forms.Padding(4);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(55, 23);
            this.rdNu.TabIndex = 24;
            this.rdNu.TabStop = true;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            this.rdNu.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Location = new System.Drawing.Point(312, 181);
            this.rdNam.Margin = new System.Windows.Forms.Padding(4);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(72, 23);
            this.rdNam.TabIndex = 23;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam ";
            this.rdNam.UseVisualStyleBackColor = true;
            this.rdNam.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // txthotennhanvien
            // 
            this.txthotennhanvien.Location = new System.Drawing.Point(312, 26);
            this.txthotennhanvien.Margin = new System.Windows.Forms.Padding(4);
            this.txthotennhanvien.Multiline = true;
            this.txthotennhanvien.Name = "txthotennhanvien";
            this.txthotennhanvien.Size = new System.Drawing.Size(283, 27);
            this.txthotennhanvien.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 239);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Chức Danh :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 187);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Giới Tính :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Họ Tên Nhân Viên:";
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(314, 345);
            this.txtDiachi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiachi.Multiline = true;
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(283, 27);
            this.txtDiachi.TabIndex = 38;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(314, 121);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(283, 27);
            this.txtPass.TabIndex = 39;
            this.txtPass.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(68, 129);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 19);
            this.label8.TabIndex = 40;
            this.label8.Text = "Mật khẩu";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(314, 70);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(283, 27);
            this.txtUsername.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 19);
            this.label1.TabIndex = 42;
            this.label1.Text = "Tên đăng nhập";
            // 
            // txtChucdanh
            // 
            this.txtChucdanh.Location = new System.Drawing.Point(314, 231);
            this.txtChucdanh.Margin = new System.Windows.Forms.Padding(4);
            this.txtChucdanh.Multiline = true;
            this.txtChucdanh.Name = "txtChucdanh";
            this.txtChucdanh.Size = new System.Drawing.Size(283, 27);
            this.txtChucdanh.TabIndex = 43;
            // 
            // txtTrinhdo
            // 
            this.txtTrinhdo.Location = new System.Drawing.Point(314, 402);
            this.txtTrinhdo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTrinhdo.Multiline = true;
            this.txtTrinhdo.Name = "txtTrinhdo";
            this.txtTrinhdo.Size = new System.Drawing.Size(283, 27);
            this.txtTrinhdo.TabIndex = 44;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(1100, 24);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(455, 27);
            this.txtTimKiem.TabIndex = 45;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1016, 32);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 19);
            this.label9.TabIndex = 46;
            this.label9.Text = "Tìm kiếm";
            // 
            // Danhsachnhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.txtTrinhdo);
            this.Controls.Add(this.txtChucdanh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.dtgdanhsachnhanvien);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dTdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rdNu);
            this.Controls.Add(this.rdNam);
            this.Controls.Add(this.txthotennhanvien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Danhsachnhanvien";
            this.Size = new System.Drawing.Size(1666, 586);
            this.Load += new System.EventHandler(this.Danhsachnhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgdanhsachnhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgdanhsachnhanvien;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dTdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.TextBox txthotennhanvien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtChucdanh;
        private System.Windows.Forms.TextBox txtTrinhdo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDangNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChucDanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiCongTac;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrinhDoChuyenMon;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label9;
    }
}
