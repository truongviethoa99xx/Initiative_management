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
using DevExpress.XtraEditors.Filtering.Templates;

namespace QuanLySangKien
{
    public partial class TinhTrang : DevExpress.XtraEditors.XtraUserControl
    {
        public static SqlConnection conn;
        public class tinhtrangketqua
        {
            public string Name { get; set; }
            public int Number { get; set; }

            public tinhtrangketqua(string name, int number)
            {
                this.Name = name;
                this.Number = number;
            }

            public override string ToString()
            {
                return Name;
            }
        }
        public TinhTrang()
        {
            conn = new SqlConnection(@"Data Source=VU\MSSQLSERVER01;Initial Catalog=QLSK;Integrated Security=True");
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            txtMaSk.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtMota.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txtDieuKien.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txtDanhGia.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();

            //string tinhtrang = dataGridView1.Rows[i].Cells[5].Value.ToString();
            //int TINHTRANG =Int32.Parse(tinhtrang);
            //if (TINHTRANG == -1) cbtinhtrang.Text = "Bị Hủy Bỏ";
            //if (TINHTRANG == 0) cbtinhtrang.Text = "Mới nộp đơn";
            //if (TINHTRANG == 1) cbtinhtrang.Text = "Được Công Nhận";

            //string ketqua = dataGridView1.Rows[i].Cells[6].Value.ToString();
            //int KETQUA = Int32.Parse(ketqua);
            //if (TINHTRANG == -1) cbketqua.Text = "Chưa xét";
            //if (TINHTRANG == 0) cbketqua.Text = "Từ Chối";
            //if (TINHTRANG == 1) cbketqua.Text = "Đã Được Công Nhận";
            
        }
        public void loaddulieu()
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM SoSangKien", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            //dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();

                dataGridView1.Rows[n].Cells[0].Value = item["MaSangKien"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["TenSangKien"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["MoTaSangKien"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["DieuKienApDungSangKien"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item["DanhGiaLoiIch"].ToString();
                dataGridView1.Rows[n].Cells[5].Value = item["TinhTrang"].ToString();
                dataGridView1.Rows[n].Cells[6].Value = item["KetQuaXet"].ToString();
               
            }
            conn.Close();
        }
        private void TinhTrang_Load(object sender, EventArgs e)
        {
            loaddulieu();
            loadtinhtrang();
        }
        public void loadtinhtrang()
        {
        

            Dictionary<string, int> comboSource = new Dictionary<string, int>();
            comboSource.Add("Mới nộp đơn", 0);
            comboSource.Add("Đã Được Công Nhận", 1);
            comboSource.Add("Bị Hủy Bỏ", -1);
            cbtinhtrang.DataSource = new BindingSource(comboSource, null);
            cbtinhtrang.DisplayMember = "Key";
            cbtinhtrang.ValueMember = "Value";

           // string key = ((KeyValuePair<string, string>)cbtinhtrang.SelectedItem).Key;
            int value = ((KeyValuePair<string, int>)cbtinhtrang.SelectedItem).Value;

            Dictionary<string, int> comboSource2 = new Dictionary<string, int>();
            comboSource2.Add("Chưa xét", -1);
            comboSource2.Add("Từ Chối", 0);
            comboSource2.Add("Được Công Nhận", 1);
            cbketqua.DataSource = new BindingSource(comboSource2, null);
            cbketqua.DisplayMember = "Key";
            cbketqua.ValueMember = "Value";







        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int value = ((KeyValuePair<string, int>)cbtinhtrang.SelectedItem).Value;


            try
            {
                string sql = "UPDATE SoSangKien Set MoTaSangKien = '" + txtMota.Text + "',DieuKienApDungSangKien = '" + txtDieuKien.Text + "',DanhGiaLoiIch= '" + txtDanhGia.Text + "',TinhTrang= '" + value + "',KetQuaXet = '" + cbketqua.SelectedValue + "'where MaSangKien = '" + txtMaSk.Text + "'";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công");
                dataGridView1.Rows.Clear();
                conn.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { loaddulieu(); }
        }
    }
}
