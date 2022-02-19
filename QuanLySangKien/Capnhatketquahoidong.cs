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
    public partial class Capnhatketquahoidong : DevExpress.XtraEditors.XtraUserControl
    {
        public Capnhatketquahoidong()
        {
            InitializeComponent();
            cbHoiDong.DataSource = LoadArrHoiDong();
            cbHoiDong.DisplayMember = "tenHoiDong";
            cbHoiDong.ValueMember = "maHoiDong";
        }
        public class HoiDong
        {
            private string tenHoiDong;
            private string maHoiDong;

            public string MaHoiDong { get => maHoiDong; set => maHoiDong = value; }
            public string TenHoiDong { get => tenHoiDong; set => tenHoiDong = value; }
        }
        SqlConnection con = new SqlConnection(@"Data Source=VU\MSSQLSERVER01;Initial Catalog=QLSK;Integrated Security=True");
        SqlCommand cmd;
        SqlCommandBuilder sqlCommand = null;

        SqlDataAdapter sqlAdapter = null;

        DataSet dataset = null;
        private void LoadData()
        {
            try
            {
                sqlAdapter = new SqlDataAdapter("SELECT * FROM DSThanhVienHoiDong", con);
                sqlCommand = new SqlCommandBuilder(sqlAdapter);
                sqlAdapter.InsertCommand = sqlCommand.GetInsertCommand();
                sqlAdapter.UpdateCommand = sqlCommand.GetUpdateCommand();
                sqlAdapter.DeleteCommand = sqlCommand.GetDeleteCommand();
                dataset = new DataSet();
                sqlAdapter.Fill(dataset, "DSThanhVienHoiDong");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dataset.Tables["DSThanhVienHoiDong"];
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    dataGridView1[5, i] = linkCell;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private ArrayList LoadArrHoiDong()
        {
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select MaHoiDong, TenHoiDong from HoiDong";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            ArrayList listHoiDong = new ArrayList();
            foreach (DataRow dr in dt.Rows)
            {
                HoiDong hd = new HoiDong();
                hd.MaHoiDong = dr["MaHoiDong"].ToString();
                hd.TenHoiDong = dr["TenHoiDong"].ToString(); listHoiDong.Add(hd);
            }
            con.Close();
            return listHoiDong;
        }
        private void Capnhatketquahoidong_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            HoiDong hoiDong = new HoiDong();
            hoiDong = (HoiDong)cbHoiDong.SelectedItem;
            Thanhvien main = new Thanhvien(hoiDong.MaHoiDong);
            main.Show();
            main.FormClosing += Xuly_Khi_main_Close;
        }
        private void Xuly_Khi_main_Close(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT DSChuyenGia.MaChuyenGia, DSChuyenGia.TenChuyenGia, DSChuyenGia.HocHamHocVi,DSThanhVienHoiDong.VaiTro,DSThanhVienHoiDong.YKien FROM DSThanhVienHoiDong INNER JOIN DSChuyenGia ON DSThanhVienHoiDong.MaChuyenGia = DSChuyenGia.MaChuyenGia WHERE DSThanhVienHoiDong.MaHoiDong = '" + cbHoiDong.SelectedValue + "'; ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                string yk;
                int m = Convert.ToInt32(item["YKien"]);
                switch (m)
                {
                    case -1:
                        yk = "Chưa họp xét";
                        break;
                    case 0:
                        yk = "Không đồng ý";
                        break;
                    default:
                        yk = "ĐỒng ý";
                        break;
                }
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["MaChuyenGia"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["TenChuyenGia"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["HocHamHocVi"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["VaiTro"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = yk;
            }
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int lastRow = e.RowIndex;
                DataGridViewRow nRow = dataGridView1.Rows[lastRow];
                DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                dataGridView1[5, lastRow] = linkCell;
                nRow.Cells["Delete"].Value = "Update";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 5)
                {
                    string Task = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                    if (Task == "Delete")
                    {
                        if (MessageBox.Show("Bạn có chắc chắm muốn xóa không?", "Đang xóa...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            int rowIndex = e.RowIndex;
                            dataGridView1.Rows.RemoveAt(rowIndex);
                            dataset.Tables["DSThanhVienHoiDong"].Rows[rowIndex].Delete();
                            sqlAdapter.Update(dataset, "DSThanhVienHoiDong");
                        }
                    }
                    //else if (Task == "Insert")
                    //{
                    //    int row = dataGridView1.Rows.Count - 2;
                    //    DataRow dr = dataset.Tables["DSThanhVienHoiDong"].NewRow();
                    //    dr["MaChuyeGia"] = dataGridView1.Rows[row].Cells["MaChuyenGia"].Value;
                    //    dr["VaiTro"] = dataGridView1.Rows[row].Cells["VaiTro"].Value;
                    //    dr["YKien"] = dataGridView1.Rows[row].Cells["YKien"].Value;
                    //    dataset.Tables["DSThanhVienHoiDong"].Rows.Add(dr);
                    //    dataset.Tables["DSThanhVienHoiDong"].Rows.RemoveAt(dataset.Tables["DSThanhVienHoiDong"].Rows.Count - 1);
                    //    dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count - 2);
                    //    dataGridView1.Rows[e.RowIndex].Cells[0].Value = "Delete";
                    //    sqlAdapter.Update(dataset, "DSThanhVienHoiDong");
                    //}
                    else if (Task == "Update")
                    {
                        int r = e.RowIndex;
                        dataset.Tables["DSThanhVienHoiDong"].Rows[r]["MaChuyenGia"] = dataGridView1.Rows[r].Cells["MaChuyenGia"].Value;
                        dataset.Tables["VaiTro"].Rows[r]["VaiTro"] = dataGridView1.Rows[r].Cells["VaiTro"].Value;
                        dataset.Tables["YKien"].Rows[r]["YKien"] = dataGridView1.Rows[r].Cells["YKien"].Value;
                        sqlAdapter.Update(dataset, "DSThanhVienHoiDong");
                        dataGridView1.Rows[e.RowIndex].Cells[0].Value = "Delete";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    LoadData();
            //}
            //catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
