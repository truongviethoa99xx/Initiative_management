using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySangKien
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public static string ID_USER = "";
        public static int PER_USER = 0;
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=VU\MSSQLSERVER01;Initial Catalog=QLSK;Integrated Security=True");
        public void login()
        {
            string pq;
            Connect cn = new Connect();
            ID_USER = cn.getID(txtUsername.Text, txtPassword.Text);
           
                try
                {
                    string sql = "select * from NhanVien where TenDangNhap='" + txtUsername.Text + "' and MatKhau = '" + txtPassword.Text + "'";
                    DataTable Account = Connect.Getdatatble(sql);

                    if (Account.Rows.Count != 0)
                    {
                        string a = Account.Rows[0]["PhanQuyen"].ToString();

                        if (a == "True")
                        {

                            Form2 ad = new Form2();
                            ad.Show();
                            this.Hide();
                        }
                        else if (a == "False")
                        {
                            Form2 nv = new Form2();
                            nv.Show();
                            this.Hide();
                        }
                        else
                        {

                            MessageBox.Show("Tai khoan khong hop le");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
           
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            Connect cn = new Connect();

            ID_USER = cn.getID(txtUsername.Text, txtPassword.Text);
            login();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
