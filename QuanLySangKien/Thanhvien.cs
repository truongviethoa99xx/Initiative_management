using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.Collections;

namespace QuanLySangKien
{
    public partial class Thanhvien : DevExpress.XtraEditors.XtraForm
    {
        
        SqlConnection con = new SqlConnection(@"Data Source=VU\MSSQLSERVER01;Initial Catalog=QLSK;Integrated Security=True");
        //SqlCommand cmd;
        public Thanhvien(string maHoiDong)
        {
            InitializeComponent();
            txtMaHoiDong.Text = maHoiDong;
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM HoiDong WHERE MaHoiDong = '" + maHoiDong + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                textBox1.Text = item["TenHoiDong"].ToString();
            }
        }
        public void load_data()
        {
            //con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM HoiDong", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "HoiDong");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "HoiDong";
            //con.Close();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM DSChuyenGia", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = false;
                dataGridView1.Rows[n].Cells[3].Value = item["MaChuyenGia"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["TenChuyenGia"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["HocHamHocVi"].ToString();
            }
            dataGridView1.Columns[3].Visible = false;
            con.Close();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count > 1)
            {
                foreach (DataGridViewRow dr in dataGridView2.Rows)
                {
                    string sql = "insert into DSThanhVienHoiDong(MaHoiDong, MaChuyenGia) values('" + txtMaHoiDong.Text + "','" + dr.Cells[2].Value.ToString() + "')";
                    con.Open();                 
                    SqlCommand cmd = new SqlCommand(sql, con);
                    if (cmd.ExecuteNonQuery() == 1)
                    {

                        load_data();
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Them khong duoc!");
                    }

                }
                MessageBox.Show("Da them!");
                this.Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if ((bool)item.Cells[0].Value == true)
                {
                    int n = dataGridView2.Rows.Add();
                    dataGridView2.Rows[n].Cells[0].Value = item.Cells[1].Value.ToString();
                    dataGridView2.Rows[n].Cells[1].Value = item.Cells[2].Value.ToString();
                    dataGridView2.Rows[n].Cells[2].Value = item.Cells[3].Value.ToString();
                }
            }
            dataGridView2.Columns[2].Visible = false;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.SelectedRows)
            {
                dataGridView2.Rows.Remove(row);
            }
        }

        private void dataGridView1_MouseClick_1(object sender, MouseEventArgs e)
        {
            if ((bool)dataGridView1.SelectedRows[0].Cells[0].Value == false)
            {
                dataGridView1.SelectedRows[0].Cells[0].Value = true;
            }
            else
            {
                dataGridView1.SelectedRows[0].Cells[0].Value = false;
            }
        }

        private void Thanhvien_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}