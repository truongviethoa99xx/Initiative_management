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
using System.Data.Common;
using DevExpress.Emf;
using DevExpress.DirectX.Common.Direct3D;

namespace QuanLySangKien
{
    public partial class Danhsachnhanvien : DevExpress.XtraEditors.XtraUserControl
    {
        public static SqlConnection conn;
        public Danhsachnhanvien()
        {
            InitializeComponent();
            DateTime date = dTdate.Value;
            Connect cn = new Connect();
            conn = new SqlConnection(@"Data Source=VU\MSSQLSERVER01;Initial Catalog=QLSK;Integrated Security=True");
        }
        public void loaddulieu()
        {
            conn.Open();
            string sql = "select  MaNhanVien,HoTenNhanVien ,TenDangNhap,MatKhau,ChucDanh,NoiCongTac,TrinhDoChuyenMon from NhanVien where PhanQuyen ='0'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);//chuyen du lieu ve
            DataTable dt = new DataTable();             //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);                                //đổ dữ liệu vào kho
            conn.Close();
            dtgdanhsachnhanvien.DataSource = dt;
        }
        public void timkiem()
        {
            conn.Open();
            string sql = "select  MaNhanVien,HoTenNhanVien ,TenDangNhap,MatKhau,ChucDanh,NoiCongTac,TrinhDoChuyenMon from NhanVien where PhanQuyen ='0'and HoTenNhanVien='" + txtTimKiem.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);//chuyen du lieu ve
            DataTable dt = new DataTable();             //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);                                //đổ dữ liệu vào kho
            conn.Close();
            dtgdanhsachnhanvien.DataSource = dt;
        }
        private void cbtrinhdochuyenmon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbnoicongtac_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dtngaysinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Danhsachnhanvien_Load(object sender, EventArgs e)
        {
            loaddulieu();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cbchucdanh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckUsername())
            {
                try
                {
                    if (txthotennhanvien.Text.Length == 0 || txtUsername.Text.Length == 0 || txtPass.Text.Length == 0 || txtDiachi.Text.Length == 0 || txtTrinhdo.Text.Length == 0)
                    {
                        MessageBox.Show("Vui Lòng Nhập Đầy Đủ Các Thông Tin");
                    }


                    else
                    {
                        Connect ketnoi = new Connect();
                        conn = new SqlConnection(@"Data Source=VU\MSSQLSERVER01;Initial Catalog=QLSK;Integrated Security=True");
                        conn.Open();
                        var cmd = new SqlCommand("sp_NhanVien_NewID", conn);
                        cmd.CommandType = CommandType.StoredProcedure;


                        var MANV = cmd.ExecuteScalar().ToString();
                        //    MessageBox.Show(result);
                        cmd.ExecuteNonQuery();

                        int gioitinh = 0;
                        string ngaysinh = "";
                        if (this.rdNam.Checked == true)
                        {
                            gioitinh = 0;
                        }
                        else
                        {
                            if (this.rdNu.Checked == true)
                            {
                                gioitinh = 1;
                            }
                        }
                        ngaysinh = dTdate.Value.ToString();

                        string sql = "INSERT INTO NhanVien (MaNhanVien,HoTenNhanVien,TenDangNhap,MatKhau,NoiCongTac,TrinhDoChuyenMon,NgaySinh,GioiTinh) VALUES ('" + MANV + "','" + txthotennhanvien.Text + "', '" + txtUsername.Text + "', '" + txtPass.Text + "', '" + txtDiachi.Text + "','" + txtTrinhdo.Text + "',  '" + ngaysinh + "', '" + gioitinh + "' )";
                        ketnoi.ExcuteNonQuery(sql); // Thực thi Query
                        MessageBox.Show("Đăng Ký Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information); // Nếu đang ký thành công => Sẽ có thông báo Thành Công và đồng thời các TextBox sẽ mất giá trị do [B]ClearTextBox()[/B].
                        conn.Close();
                        ClearTextBox();
                        loaddulieu();

                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }else
            {
                    MessageBox.Show("Tên đăng nhập đã tồn tại");
                
            }
        }
        private void ClearTextBox()
        {
            txtUsername.Clear();
            txtPass.Clear();

        }
        public bool CheckUsername()
        {
            conn.Open();
            string sql = "	select count(TenDangNhap)  from NhanVien where TenDangNhap ='" + txtUsername.Text + "'";
            SqlCommand cmd1 = new SqlCommand();
            
            cmd1.Connection = conn;
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = sql;
           Int32 count= Int32.Parse(cmd1.ExecuteScalar().ToString());
            conn.Close();
            if (count>0)
            {
                return false;     
            }

            else return true;
            

        }
        public bool CheckUsernamesua()
        {
            conn.Open();
            string sql = "	select count(TenDangNhap)  from NhanVien where TenDangNhap ='" + txtUsername.Text + "' ";
            SqlCommand cmd1 = new SqlCommand();

            cmd1.Connection = conn;
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = sql;
            Int32 count = Int32.Parse(cmd1.ExecuteScalar().ToString());
            string sql2 = "	select count(TenDangNhap)  from NhanVien where TenDangNhap ='" + txtMa.Text+ "' ";
            SqlCommand cmd2 = new SqlCommand();

            cmd1.Connection = conn;
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = sql2;
            Int32 countnow = Int32.Parse(cmd1.ExecuteScalar().ToString());
            conn.Close();

            if (count <=1)
            {
                return true;
            }

            else return false;


        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            int i = dtgdanhsachnhanvien.CurrentRow.Index;
            txtMa.Text = dtgdanhsachnhanvien.Rows[i].Cells[0].Value.ToString();
            try
            {
                string sql = "delete from NhanVien where MaNhanVien='" + txtMa.Text + "'";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa Thành Công");
                conn.Close();
                loaddulieu();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtgdanhsachnhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int i;
            i = dtgdanhsachnhanvien.CurrentRow.Index;
            txtMa.Text = dtgdanhsachnhanvien.Rows[i].Cells[1].Value.ToString();
            txthotennhanvien.Text= dtgdanhsachnhanvien.Rows[i].Cells[1].Value.ToString();
            txtUsername.Text= dtgdanhsachnhanvien.Rows[i].Cells[2].Value.ToString();
            txtPass.Text= dtgdanhsachnhanvien.Rows[i].Cells[3].Value.ToString();
            txtChucdanh.Text= dtgdanhsachnhanvien.Rows[i].Cells[4].Value.ToString();
            txtDiachi.Text= dtgdanhsachnhanvien.Rows[i].Cells[5].Value.ToString();
            txtTrinhdo.Text= dtgdanhsachnhanvien.Rows[i].Cells[6].Value.ToString();



        }

        private void button4_Click(object sender, EventArgs e)
        {
            loaddulieu();
        }

        private void txtMa_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            int i = dtgdanhsachnhanvien.CurrentRow.Index;
            txtMa.Text = dtgdanhsachnhanvien.Rows[i].Cells[0].Value.ToString();
            if (CheckUsernamesua())
            {
                try
                {
                    string sql = "UPDATE NhanVien SET HoTenNhanVien='" + txthotennhanvien.Text + "' ,TenDangNhap='" + txtUsername.Text + "',MatKhau=  '" + txtPass.Text + "',ChucDanh='" + txtChucdanh.Text + "',NoiCongTac='" + txtDiachi.Text + "',TrinhDoChuyenMon='" + txtTrinhdo.Text + "'  WHERE MaNhanVien = '" + txtMa.Text + "'";
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
            else { MessageBox.Show("Tên đăng nhập đã tồn tại"); }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            timkiem();
            if (txtTimKiem.Text == "") loaddulieu();
        }
    }

}
