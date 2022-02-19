namespace QuanLySangKien
{
    partial class ThongTinNhanVien
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
            this.dtgthongtinnhanvien = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgthongtinnhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgthongtinnhanvien
            // 
            this.dtgthongtinnhanvien.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgthongtinnhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgthongtinnhanvien.Location = new System.Drawing.Point(13, 0);
            this.dtgthongtinnhanvien.Name = "dtgthongtinnhanvien";
            this.dtgthongtinnhanvien.RowHeadersWidth = 62;
            this.dtgthongtinnhanvien.RowTemplate.Height = 28;
            this.dtgthongtinnhanvien.Size = new System.Drawing.Size(830, 320);
            this.dtgthongtinnhanvien.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SpringGreen;
            this.button1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(849, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "In Thông Tin Nhân Viên ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ThongTinNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtgthongtinnhanvien);
            this.Name = "ThongTinNhanVien";
            this.Size = new System.Drawing.Size(1087, 353);
            this.Load += new System.EventHandler(this.ThongTinNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgthongtinnhanvien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgthongtinnhanvien;
        private System.Windows.Forms.Button button1;
    }
}
