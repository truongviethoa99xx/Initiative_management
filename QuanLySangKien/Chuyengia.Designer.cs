namespace QuanLySangKien
{
    partial class Chuyengia
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
            this.dtgchuyengia = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cbhochamhocvi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txttenchuyengia = new System.Windows.Forms.TextBox();
            this.txtmachuyengia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgchuyengia)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgchuyengia
            // 
            this.dtgchuyengia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgchuyengia.Location = new System.Drawing.Point(13, 303);
            this.dtgchuyengia.Margin = new System.Windows.Forms.Padding(4);
            this.dtgchuyengia.Name = "dtgchuyengia";
            this.dtgchuyengia.RowHeadersWidth = 62;
            this.dtgchuyengia.Size = new System.Drawing.Size(473, 219);
            this.dtgchuyengia.TabIndex = 18;
            this.dtgchuyengia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgchuyengia_CellContentClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(602, 176);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(260, 34);
            this.button3.TabIndex = 17;
            this.button3.Text = "Xóa Chuyên Gia ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(602, 116);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(260, 34);
            this.button2.TabIndex = 16;
            this.button2.Text = "Sửa Thông Tin Chuyên  Gia ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(602, 57);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 34);
            this.button1.TabIndex = 15;
            this.button1.Text = "Thêm Chuyên Gia ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbhochamhocvi
            // 
            this.cbhochamhocvi.FormattingEnabled = true;
            this.cbhochamhocvi.Items.AddRange(new object[] {
            "Tiến Sỹ",
            "Thạc Sỹ",
            "Cao Học",
            "Cử Nhân"});
            this.cbhochamhocvi.Location = new System.Drawing.Point(160, 208);
            this.cbhochamhocvi.Margin = new System.Windows.Forms.Padding(4);
            this.cbhochamhocvi.Name = "cbhochamhocvi";
            this.cbhochamhocvi.Size = new System.Drawing.Size(326, 27);
            this.cbhochamhocvi.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 208);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Học Hàm Học Vị:";
            // 
            // txttenchuyengia
            // 
            this.txttenchuyengia.Location = new System.Drawing.Point(160, 142);
            this.txttenchuyengia.Margin = new System.Windows.Forms.Padding(4);
            this.txttenchuyengia.Multiline = true;
            this.txttenchuyengia.Name = "txttenchuyengia";
            this.txttenchuyengia.Size = new System.Drawing.Size(326, 27);
            this.txttenchuyengia.TabIndex = 12;
            // 
            // txtmachuyengia
            // 
            this.txtmachuyengia.Location = new System.Drawing.Point(160, 67);
            this.txtmachuyengia.Margin = new System.Windows.Forms.Padding(4);
            this.txtmachuyengia.Multiline = true;
            this.txtmachuyengia.Name = "txtmachuyengia";
            this.txtmachuyengia.Size = new System.Drawing.Size(326, 27);
            this.txtmachuyengia.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tên Chuyên Gia:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã Chuyên Gia:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(602, 233);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(260, 34);
            this.button4.TabIndex = 19;
            this.button4.Text = "Làm mới";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Chuyengia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dtgchuyengia);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbhochamhocvi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txttenchuyengia);
            this.Controls.Add(this.txtmachuyengia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Chuyengia";
            this.Size = new System.Drawing.Size(969, 579);
            this.Load += new System.EventHandler(this.Chuyengia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgchuyengia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgchuyengia;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbhochamhocvi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttenchuyengia;
        private System.Windows.Forms.TextBox txtmachuyengia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
    }
}
