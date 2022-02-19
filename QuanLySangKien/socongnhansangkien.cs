using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySangKien
{
    public partial class socongnhansangkien : Form
    {
        public socongnhansangkien(DataTable data)
        {
            InitializeComponent();
            CR_socongnhansangkien rp = new CR_socongnhansangkien();// Gọi view mình tạo 
            rp.SetDataSource(data);//gắn data cho view tạo
            crystalReportViewer1.ReportSource = rp;//gắn cái view view cr
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
