namespace QuanLySangKien
{
    partial class TinhTrang
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaSangKien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSangKien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DieuKienApDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DanhGiaLoiIch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KetQuaXet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMota = new System.Windows.Forms.TextBox();
            this.txtDieuKien = new System.Windows.Forms.TextBox();
            this.txtDanhGia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbtinhtrang = new System.Windows.Forms.ComboBox();
            this.cbketqua = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtMaSk = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSangKien,
            this.TenSangKien,
            this.MoTa,
            this.DieuKienApDung,
            this.DanhGiaLoiIch,
            this.TinhTrang1,
            this.KetQuaXet});
            this.dataGridView1.Location = new System.Drawing.Point(39, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1468, 183);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MaSangKien
            // 
            this.MaSangKien.DataPropertyName = "MaSangKien";
            this.MaSangKien.HeaderText = "Mã Sáng Kiến";
            this.MaSangKien.MinimumWidth = 8;
            this.MaSangKien.Name = "MaSangKien";
            this.MaSangKien.ReadOnly = true;
            this.MaSangKien.Width = 150;
            // 
            // TenSangKien
            // 
            this.TenSangKien.DataPropertyName = "TenSangKien";
            this.TenSangKien.HeaderText = "Tên Sáng Kiến";
            this.TenSangKien.MinimumWidth = 8;
            this.TenSangKien.Name = "TenSangKien";
            this.TenSangKien.ReadOnly = true;
            this.TenSangKien.Width = 150;
            // 
            // MoTa
            // 
            this.MoTa.DataPropertyName = "MoTa";
            this.MoTa.HeaderText = "Mô Tả";
            this.MoTa.MinimumWidth = 8;
            this.MoTa.Name = "MoTa";
            this.MoTa.ReadOnly = true;
            this.MoTa.Width = 150;
            // 
            // DieuKienApDung
            // 
            this.DieuKienApDung.DataPropertyName = "DieuKienApDung";
            this.DieuKienApDung.HeaderText = "Điều Kiện Áp Dụng";
            this.DieuKienApDung.MinimumWidth = 8;
            this.DieuKienApDung.Name = "DieuKienApDung";
            this.DieuKienApDung.ReadOnly = true;
            this.DieuKienApDung.Width = 150;
            // 
            // DanhGiaLoiIch
            // 
            this.DanhGiaLoiIch.DataPropertyName = "DanhGiaLoiIch";
            this.DanhGiaLoiIch.HeaderText = "Đánh Giá Lợi Ích";
            this.DanhGiaLoiIch.MinimumWidth = 8;
            this.DanhGiaLoiIch.Name = "DanhGiaLoiIch";
            this.DanhGiaLoiIch.ReadOnly = true;
            this.DanhGiaLoiIch.Width = 150;
            // 
            // TinhTrang1
            // 
            this.TinhTrang1.DataPropertyName = "TinhTrang";
            this.TinhTrang1.HeaderText = "TinhTrang";
            this.TinhTrang1.MinimumWidth = 8;
            this.TinhTrang1.Name = "TinhTrang1";
            this.TinhTrang1.ReadOnly = true;
            this.TinhTrang1.Width = 150;
            // 
            // KetQuaXet
            // 
            this.KetQuaXet.DataPropertyName = "KetQuaXet";
            this.KetQuaXet.HeaderText = "Kết Quả Xét";
            this.KetQuaXet.MinimumWidth = 8;
            this.KetQuaXet.Name = "KetQuaXet";
            this.KetQuaXet.ReadOnly = true;
            this.KetQuaXet.Width = 150;
            // 
            // txtMota
            // 
            this.txtMota.Location = new System.Drawing.Point(155, 277);
            this.txtMota.Multiline = true;
            this.txtMota.Name = "txtMota";
            this.txtMota.Size = new System.Drawing.Size(746, 82);
            this.txtMota.TabIndex = 1;
            // 
            // txtDieuKien
            // 
            this.txtDieuKien.Location = new System.Drawing.Point(155, 377);
            this.txtDieuKien.Multiline = true;
            this.txtDieuKien.Name = "txtDieuKien";
            this.txtDieuKien.Size = new System.Drawing.Size(746, 78);
            this.txtDieuKien.TabIndex = 2;
            // 
            // txtDanhGia
            // 
            this.txtDanhGia.Location = new System.Drawing.Point(155, 484);
            this.txtDanhGia.Multiline = true;
            this.txtDanhGia.Name = "txtDanhGia";
            this.txtDanhGia.Size = new System.Drawing.Size(746, 75);
            this.txtDanhGia.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mô Tả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Điều Kiện";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 511);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Đánh giá";
            // 
            // cbtinhtrang
            // 
            this.cbtinhtrang.FormattingEnabled = true;
            this.cbtinhtrang.Location = new System.Drawing.Point(1161, 279);
            this.cbtinhtrang.Name = "cbtinhtrang";
            this.cbtinhtrang.Size = new System.Drawing.Size(346, 27);
            this.cbtinhtrang.TabIndex = 7;
            // 
            // cbketqua
            // 
            this.cbketqua.FormattingEnabled = true;
            this.cbketqua.Location = new System.Drawing.Point(1161, 350);
            this.cbketqua.Name = "cbketqua";
            this.cbketqua.Size = new System.Drawing.Size(346, 27);
            this.cbketqua.TabIndex = 9;
            this.cbketqua.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1072, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Kết quả";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(1161, 417);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(346, 34);
            this.btnLuu.TabIndex = 11;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtMaSk
            // 
            this.txtMaSk.Location = new System.Drawing.Point(155, 239);
            this.txtMaSk.Name = "txtMaSk";
            this.txtMaSk.ReadOnly = true;
            this.txtMaSk.Size = new System.Drawing.Size(279, 27);
            this.txtMaSk.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Mã Sáng Kiến";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1072, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tình trạng";
            // 
            // TinhTrang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMaSk);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbketqua);
            this.Controls.Add(this.cbtinhtrang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDanhGia);
            this.Controls.Add(this.txtDieuKien);
            this.Controls.Add(this.txtMota);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TinhTrang";
            this.Size = new System.Drawing.Size(1696, 607);
            this.Load += new System.EventHandler(this.TinhTrang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSangKien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSangKien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn DieuKienApDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn DanhGiaLoiIch;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang1;
        private System.Windows.Forms.DataGridViewTextBoxColumn KetQuaXet;
        private System.Windows.Forms.TextBox txtMota;
        private System.Windows.Forms.TextBox txtDieuKien;
        private System.Windows.Forms.TextBox txtDanhGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbketqua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtMaSk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbtinhtrang;
    }
}
