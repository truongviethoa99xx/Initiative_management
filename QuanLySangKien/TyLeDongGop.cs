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
    public partial class TyLeDongGop : DevExpress.XtraEditors.XtraUserControl
    {
        public static SqlConnection conn;
        public TyLeDongGop()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=VU\MSSQLSERVER01;Initial Catalog=QLSK;Integrated Security=True");
        }

        private void TyLeDongGop_Load(object sender, EventArgs e)
        {
            loadDS();
        }
        public void loadDS()
        {
            conn.Open();
            string sql = "Select NhanVien.HoTenNhanVien,TacGia.MaNhanVien,TacGia.MaSangKien,TacGia.TyLeDongGopVaoSangKien From TacGia INNER JOIN NhanVien ON TacGia.MaNhanVien = NhanVien.MaNhanVien";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);//chuyen du lieu ve
            DataTable dt = new DataTable();             //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);                                //đổ dữ liệu vào kho
            conn.Close();
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            txttyle.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            string sql = "UPDATE TacGia SET TyLeDongGopVaoSangKien='" + txttyle.Text + "' where MaNhanVien='" + dataGridView1.Rows[i].Cells[2].Value.ToString() + "' and MaSangKien='" + dataGridView1.Rows[i].Cells[3].Value.ToString() + "'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Lưu thành công");
            loadDS();
            conn.Close();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            string sql = "Delete TacGia  where MaNhanVien='" + dataGridView1.Rows[i].Cells[2].Value.ToString() + "' and MaSangKien='" + dataGridView1.Rows[i].Cells[3].Value.ToString() + "'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Xóa thành công");
            loadDS();
            conn.Close();
        }
    }
}
