using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace QuanLySangKien
{
    public partial class ThongTinNhanVien : DevExpress.XtraEditors.XtraUserControl
    {
        public ThongTinNhanVien()
        {
            InitializeComponent();
        }
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=VU\MSSQLSERVER01;Initial Catalog=QLSK;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable Table = new DataTable();
        public void LoadData()
        {
            command = connection.CreateCommand();//Khởi tạo xử lý kết nối
            command.CommandText = "SELECT*FROM NhanVien";
            adapter.SelectCommand = command;
            Table.Clear();
            adapter.Fill(this.Table);
            dtgthongtinnhanvien.DataSource = Table;
        }
        private void ThongTinNhanVien_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            LoadData();

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            InThongTinNhanVien thongtin = new InThongTinNhanVien(Table);
            thongtin.Show();
        }
    }
}
