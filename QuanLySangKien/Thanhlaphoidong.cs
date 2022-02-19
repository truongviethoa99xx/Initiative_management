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
using System.Collections;

namespace QuanLySangKien
{
    public partial class Thanhlaphoidong : DevExpress.XtraEditors.XtraUserControl
    {
        
        SqlConnection con = new SqlConnection(@"Data Source=VU\MSSQLSERVER01;Initial Catalog=QLSK;Integrated Security=True");
        SqlCommand cmd;
        public Thanhlaphoidong()
        {
            InitializeComponent();
            
        }
        
        private void Thanhlaphoidong_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT MaSangKien FROM SoSangKien";
            cmd.ExecuteNonQuery();
            DataTable dtTLHD = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dtTLHD);
            foreach(DataRow dr in dtTLHD.Rows)
            {
                comboBox1.Items.Add(dr["MaSangKien"].ToString());
            }
            con.Close();
            ketnoicsdl();
        }
        private void ketnoicsdl()
        {
            con.Open();
            string sql = "SELECT * FROM HoiDong";  // lay het du lieu trong bang sinh vien
            SqlCommand com = new SqlCommand(sql, con); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            con.Close();  // đóng kết nối
            dataGridView1.DataSource = dt; //đổ dữ liệu vào datagridview
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //if(dateTimePicker1.Value > dateTimePicker2.Value)
            //{
            //    MessageBox.Show("Lỗi ngày");
            //}    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO HoiDong(MaHoiDong,TenHoiDong,NgayThanhLap,NgayHopXet,SoQuyetDinhThanhLap,MaSangKien) VALUES('" + textBox1.Text + "', '" + textBox2.Text + "', '" + dateTimePicker1.Text + "', '" + dateTimePicker2.Text + "', '" + textBox3.Text + "', '" + comboBox1.Text + "')";
            con.Open();
            SqlCommand cmd = new SqlCommand(insertQuery, con);
            if(cmd.ExecuteNonQuery()==1)
            {
                MessageBox.Show("Da them!");
                load_data();
            }
            else
            {
                MessageBox.Show("Them khong duoc!");
            }
            con.Close();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                dateTimePicker2.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();              
            }
            catch
            {
                //sdada
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string insertQuery = "UPDATE HoiDong SET NgayThanhLap = '"+dateTimePicker1.Text +"', NgayHopXet = '"+dateTimePicker2.Text + "', SoQuyetDinhThanhLap = '" + textBox3.Text + "', TenHoiDong = '" + textBox2.Text + "' WHERE MaHoiDong = '" + textBox1.Text+"';";
            con.Open();
            SqlCommand cmd = new SqlCommand(insertQuery, con);
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Da sua!");
                load_data();
            }
            else
            {
                MessageBox.Show("sua khong duoc!");
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string insertQuery = "DELETE FROM HoiDong WHERE MaHoiDong = '" + textBox1.Text + "';";
            con.Open();
            SqlCommand cmd = new SqlCommand(insertQuery, con);
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Da Xoa!");
                load_data();
            }
            else
            {
                MessageBox.Show("xoa khong duoc!");
            }
            con.Close();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value > dateTimePicker2.Value)
            {
                MessageBox.Show("Ngày họp xét phải sau ngày thành lập");
            }
        }
    }
}
