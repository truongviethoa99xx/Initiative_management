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
    public partial class insodangkysangkien : Form
    {
        public insodangkysangkien(DataTable data)
        {
            InitializeComponent();
            CR_sodangkysangkien rp = new CR_sodangkysangkien();
            rp.SetDataSource(data);
            crystalReportViewer1.ReportSource = rp;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
