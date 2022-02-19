using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySangKien
{
    class Connect
    {
        public static SqlConnection conn;
        public static SqlCommand cm;
        public static SqlDataAdapter da;
        public SqlConnection GetConnection()
        {
            return new SqlConnection(@"Data Source=VU\MSSQLSERVER01;Initial Catalog=QLSK;Integrated Security=True");
        }
        public static void MoKetNoi()
        {
            conn = new SqlConnection(@"Data Source=VU\MSSQLSERVER01;Initial Catalog=QLSK;Integrated Security=True");
            conn.Open();
        }
        public static void DongKetNoi()
        {
            conn.Close();
        }
        public static void ThucthicaulenhSQL(string sql)
        {
            MoKetNoi();
            cm = new SqlCommand(sql, conn);
            cm.ExecuteNonQuery();
            DongKetNoi();

        }
        public void ExcuteNonQuery(string sql)
        {
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            cmd.Dispose();
        }
        public SqlDataReader ExecuteReader(string sql)
        {
            SqlConnection conn = GetConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }
        public static DataTable Getdatatble(string sql)//select
        {
            MoKetNoi();
            DataTable dt = new DataTable();
            cm = new SqlCommand(sql, conn);
            da = new SqlDataAdapter(cm);
            da.Fill(dt);
            return dt;
            //conn.Close();
        }
        public string getID(string username, string pass)
        {
            string id = "";
            try
            {
                MoKetNoi();
                SqlCommand cmd = new SqlCommand("SELECT * FROM NhanVien WHERE TenDangNhap ='" + username + "' and MatKhau='" + pass + "'", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        id = dr["MaNhanVien"].ToString();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại !");
            }
            finally
            {
                conn.Close();
            }
            return id;
        }


        public string getPhanQuyen(string id)
        {

            string pq = "";
            
            try
            {
                MoKetNoi();
                SqlCommand cmd = new SqlCommand("SELECT * FROM NhanVien WHERE MaNhanVien ='" + id + "' ", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        pq = dr["PhanQuyen"].ToString();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại !");
            }
            finally
            {
                conn.Close();
            }
            return pq;
        }
    }
}