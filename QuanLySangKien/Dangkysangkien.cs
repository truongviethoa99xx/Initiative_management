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
using DevExpress.Utils.Extensions;
using DevExpress.Utils.Animation;


namespace QuanLySangKien
{
    public partial class Dangkysangkien : DevExpress.XtraEditors.XtraUserControl
    {
        public static SqlConnection conn;
        public Dangkysangkien()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=VU\MSSQLSERVER01;Initial Catalog=QLSK;Integrated Security=True");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Dangkysangkien_Load(object sender, EventArgs e)
        {
            // string dn= Form1.ID_USER;
            loadLinhVuc();
            loaddulieu();
            


        }
        public void loaddatagrid1()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM NhanVien", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            //dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dtgtacgia.Rows.Add();
                dtgtacgia.Rows[n].Cells[0].Value = false;

                dtgtacgia.Rows[n].Cells[1].Value = item["MaNhanVien"].ToString();
                dtgtacgia.Rows[n].Cells[2].Value = item["HoTenNhanVien"].ToString();
            }

        }
        public void loaddulieu()
        {
            conn.Open();
            string sql = "select MaSangKien , TenSangKien,MaLinhVucSangKien,NgayNopDon,NgayApDungThu,NgayTraKetQuaThucTe,TinhTrang from SoSangKien";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);//chuyen du lieu ve
            DataTable dt = new DataTable();             //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);                                //đổ dữ liệu vào kho
            conn.Close();
            dataGridView1.DataSource = dt;
        }
        public void loadtacgia()
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select MaNhanVien,HoTenNhanVien from NhanVien", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            //dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dtgtacgia.Rows.Add();
                dtgtacgia.Rows[n].Cells[0].Value = false;
                dtgtacgia.Rows[n].Cells[1].Value = item["MaNhanVien"].ToString();
                dtgtacgia.Rows[n].Cells[2].Value = item["HoTenNhanVien"].ToString();
               
          

            }
            conn.Close();


        }
        public void loadLinhVuc()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from DSLinhVucSangKien", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbLinhVuc.DisplayMember = "TenLinhVucSangKien";//tên trường bạn muốn hiển thị trong combobox
            cbLinhVuc.ValueMember = "MaLinhVucSangKien";
            cbLinhVuc.DataSource = dt;
        }
        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgtacgia2.Rows.Count >= 1)
                {
                    foreach (DataGridViewRow dr in dtgtacgia2.Rows)
                    {
                        string sql = "insert into TacGia(MaSangKien, MaNhanVien) values('" + txtMaSk.Text + "','" + dr.Cells[0].Value.ToString() + "')";
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Da them!");
                            conn.Close();

                        }
                        else
                        {
                            MessageBox.Show("Them khong duoc!");
                        }
                    }
                }
            }
            catch { MessageBox.Show("Tác giả đã được thêm vào sáng kiến trước đó"); }
        }
        public void xoask()
        {
            //string id =  dataGridView1.GetRowCellValue(dataGridView1.FocusedRowHandle, dataGridView1.Columns[0]).ToString();

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            txtMaSk.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtTenSk.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
     


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtNgayTHKQ.Value > dtNgayDK.Value && dtNgayADT.Value <= dtNgayDK.Value)
                {
                    Connect ketnoi = new Connect();
                    conn = new SqlConnection(@"Data Source=VU\MSSQLSERVER01;Initial Catalog=QLSK;Integrated Security=True");
                    conn.Open();
                    var cmd = new SqlCommand("sp_MaSangKien_NewID", conn);
                    cmd.CommandType = CommandType.StoredProcedure;


                    var MASK = cmd.ExecuteScalar().ToString();
                    //    MessageBox.Show(result);
                    cmd.ExecuteNonQuery();
                    string linhvucsk = cbLinhVuc.SelectedItem.ToString();
                    string ngaydangky = dtNgayDK.Value.ToString();
                    string ngayapdungthu = dtNgayADT.Value.ToString();
                    string ngaytrahenkq = dtNgayTHKQ.Value.ToString();


                    string sql = "INSERT INTO SoSangKien (MaSangKien,TenSangKien,MaLinhVucSangKien,NgayNopDon,NgayApDungThu,NgayTraKetQuaThucTe) VALUES ('" + MASK + "','" + txtTenSk.Text + "', '" + cbLinhVuc.SelectedValue + "', '" + ngaydangky + "', '" + ngayapdungthu + "','" + ngaytrahenkq + "' )";
                    ketnoi.ExcuteNonQuery(sql); // Thực thi Query
                    conn.Close();
                    MessageBox.Show("Đăng Ký Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loaddulieu();
                  
                    

                }
                else { MessageBox.Show("Loi Ngay"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtgtacgia2.SelectedRows)
            {
                dtgtacgia2.Rows.Remove(row);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            foreach (DataGridViewRow item in dtgtacgia.Rows)
            {
                if ((bool)item.Cells[0].Value == true)
                {
                    int n = dtgtacgia2.Rows.Add();
                    dtgtacgia2.Rows[n].Cells[0].Value = false;
                    dtgtacgia2.Rows[n].Cells[0].Value = item.Cells[1].Value.ToString();
                    dtgtacgia2.Rows[n].Cells[1].Value = item.Cells[2].Value.ToString();
                    //  dtgtacgia2.Rows[n].Cells[2].Value = item.Cells[3].Value.ToString();
                }
            }


        }

        private void dtgtacgia_MouseClick(object sender, MouseEventArgs e)
        {
            //if ((bool)dtgtacgia.SelectedRows[0].Cells[0].Value == false)
            //{
            //    dtgtacgia.SelectedRows[0].Cells[0].Value = true;
            //}
            //else
            //{
            //    dtgtacgia.SelectedRows[0].Cells[0].Value = false;
            //}
        }

        private void dtgtacgia2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTacgia_Click(object sender, EventArgs e)
        {
            loadtacgia();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;

            Connect cn = new Connect();
            string pq;
            string dn = Form1.ID_USER;
            pq = cn.getPhanQuyen(dn);
            if (pq == "True")
            {

                try
                {

                    string insertQuery = "DELETE FROM SoSangKien WHERE MaSangKien = '" + txtMaSk.Text + "';";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(insertQuery, conn);
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Xóa Thành Công");
                        conn.Close();
                        loaddulieu();

                    }
                    else
                    {
                        MessageBox.Show("xoa khong duoc!");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sáng Kiến Còn Trong Hoạt Động");
                }
            }
            else { MessageBox.Show("Bạn Không Có Quyền Truy Cập"); }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Connect cn = new Connect();
            string pq;
            string dn = Form1.ID_USER;
            pq = cn.getPhanQuyen(dn);
            if (pq == "True")
            {
                try
                {
                    string sql = "UPDATE SoSangKien Set TenSangKien = '" + txtTenSk.Text + "',MaLinhVucSangKien = '" + cbLinhVuc.SelectedValue + "',NgayNopDon = '" + dtNgayDK.Value.ToString() + "',NgayApDungThu = '" + dtNgayADT.Value.ToString() + "',NgayTraKetQuaThucTe = '" + dtNgayTHKQ.Value.ToString() + "'where MaSangKien = '" + txtMaSk.Text + "'";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa thành công");
                    conn.Close();
                    loaddulieu();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else { MessageBox.Show("Bạn Không Có Quyền Truy Cập"); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ConnectDatabase con = new ConnectDatabase();
                InDonDangKySangkien dk = new InDonDangKySangkien(con.getdata("select NhanVien.HoTenNhanVien, NgaySinh, NoiCongTac, ChucDanh, TrinhDoChuyenMon,TacGia.TyLeDongGopVaoSangKien from TacGia, NhanVien where TacGia.MaNhanVien = NhanVien.MaNhanVien"));
                dk.Show();
            
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            ConnectDatabase con = new ConnectDatabase();
            insodangkysangkien isdk = new insodangkysangkien(con.getdata("select SoSangKien.TenSangKien, NgayNopDon, NgayTraKetQuaThucTe from SoSangKien"));
            isdk.Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            ConnectDatabase con = new ConnectDatabase();
            socongnhansangkien scnsk = new socongnhansangkien(con.getdata("SELECT SoSangKien.TenSangKien, SoSangKien.SoVanBanKetQua,NhanVien.HoTenNhanVien, TacGia.MaNhanVien,TacGia.MaSangKien FROM SoSangKien INNER JOIN TacGia ON SoSangKien.MaSangKien = TacGia.MaSangKien INNER JOIN NhanVien ON NhanVien.MaNhanVien = TacGia.MaNhanVien"));
            scnsk.Show();
        }
    }
}
