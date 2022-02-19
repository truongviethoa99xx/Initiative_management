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
    public partial class InThongTinNhanVien : Form
    {
        public InThongTinNhanVien(DataTable data)
        {
            InitializeComponent();
            ThongKeNhanVien rpThongKe = new ThongKeNhanVien();
            rpThongKe.SetDataSource(data);
            crystalReportViewer1.ReportSource = rpThongKe;
        }
    }
}
