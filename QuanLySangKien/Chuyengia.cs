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
    public partial class Chuyengia : DevExpress.XtraEditors.XtraUserControl
    {
        public static SqlConnection conn;
        public Chuyengia()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=VU\MSSQLSERVER01;Initial Catalog=QLSK;Integrated Security=True");
        }
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=VU\MSSQLSERVER01;Initial Catalog=QLSK;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable Table = new DataTable();
        public void LoadData()
        {
            command = connection.CreateCommand();//Khởi tạo xử lý kết nối
            command.CommandText = "SELECT*FROM DSChuyenGia";
            adapter.SelectCommand = command;
            Table.Clear();
            adapter.Fill(Table);
            dtgchuyengia.DataSource = Table;
        }


        private void Chuyengia_Load(object sender, EventArgs e)
        {
            txtmachuyengia.ReadOnly = true;
            connection = new SqlConnection(str);
            connection.Open();
            LoadData();
        }

        private void dtgchuyengia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            int i;
            i = dtgchuyengia.CurrentRow.Index;
            txtmachuyengia.Text = dtgchuyengia.Rows[i].Cells[0].Value.ToString();
            txttenchuyengia.Text = dtgchuyengia.Rows[i].Cells[1].Value.ToString();
            cbhochamhocvi.Text = dtgchuyengia.Rows[i].Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            conn.Open();
            var cmd = new SqlCommand("sp_MaChuyenGia_NewID", conn);
            cmd.CommandType = CommandType.StoredProcedure;


            var MACG = cmd.ExecuteScalar().ToString();
            if ( txttenchuyengia.Text.Length == 0 || cbhochamhocvi.Text.Length == 0)
            {
                MessageBox.Show("Vui Lòng Điền Đầy Đủ Thông Tin");
            }
            else
            {
             
              
                command = connection.CreateCommand();
                cmd.ExecuteNonQuery();
                command.CommandText = "insert into DSChuyenGia values('" + MACG + "','" + txttenchuyengia.Text + "','" + cbhochamhocvi.Text + "')";
                command.ExecuteNonQuery();
                LoadData();
                conn.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from DSChuyenGia where MaChuyenGia='" + txtmachuyengia.Text + "'";
            command.ExecuteNonQuery();
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update DSChuyenGia set TenChuyenGia='" + txttenchuyengia.Text + "',HocHamHocVi='" + cbhochamhocvi.Text + "'where MaChuyenGia ='" + txtmachuyengia.Text + "'";
            command.ExecuteNonQuery();
            LoadData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtmachuyengia.Text = "";
            txttenchuyengia.Text = "";
            cbhochamhocvi.Text = "";
        }
    }
}
