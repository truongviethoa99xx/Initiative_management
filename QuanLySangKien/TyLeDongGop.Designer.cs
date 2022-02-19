namespace QuanLySangKien
{
    partial class TyLeDongGop
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
            this.btnluu = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.txttyle = new System.Windows.Forms.TextBox();
            this.HoTenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSangKien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TyLeDongGo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HoTenNhanVien,
            this.MaNhanVien,
            this.MaSangKien,
            this.TyLeDongGo});
            this.dataGridView1.Location = new System.Drawing.Point(75, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(804, 202);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(257, 321);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(101, 38);
            this.btnluu.TabIndex = 1;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(428, 321);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(93, 38);
            this.btnxoa.TabIndex = 3;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // txttyle
            // 
            this.txttyle.Location = new System.Drawing.Point(75, 321);
            this.txttyle.Multiline = true;
            this.txttyle.Name = "txttyle";
            this.txttyle.Size = new System.Drawing.Size(105, 38);
            this.txttyle.TabIndex = 4;
            // 
            // HoTenNhanVien
            // 
            this.HoTenNhanVien.DataPropertyName = "HoTenNhanVien";
            this.HoTenNhanVien.HeaderText = "Họ Tên Nhân Viên";
            this.HoTenNhanVien.MinimumWidth = 8;
            this.HoTenNhanVien.Name = "HoTenNhanVien";
            this.HoTenNhanVien.Width = 150;
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.DataPropertyName = "MaNhanVien";
            this.MaNhanVien.HeaderText = "Mã Nhân Viên";
            this.MaNhanVien.MinimumWidth = 8;
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.Width = 150;
            // 
            // MaSangKien
            // 
            this.MaSangKien.DataPropertyName = "MaSangKien";
            this.MaSangKien.HeaderText = "Mã Sáng Kiến";
            this.MaSangKien.MinimumWidth = 8;
            this.MaSangKien.Name = "MaSangKien";
            this.MaSangKien.Width = 150;
            // 
            // TyLeDongGo
            // 
            this.TyLeDongGo.DataPropertyName = "TyLeDongGopVaoSangKien";
            this.TyLeDongGo.HeaderText = "Tỷ Lệ Đóng Góp";
            this.TyLeDongGo.MinimumWidth = 8;
            this.TyLeDongGo.Name = "TyLeDongGo";
            this.TyLeDongGo.Width = 150;
            // 
            // TyLeDongGop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txttyle);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TyLeDongGop";
            this.Size = new System.Drawing.Size(965, 432);
            this.Load += new System.EventHandler(this.TyLeDongGop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.TextBox txttyle;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSangKien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TyLeDongGo;
    }
}
