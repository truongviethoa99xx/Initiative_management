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

namespace QuanLySangKien
{
    public partial class Form2 : DevExpress.XtraEditors.XtraForm
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pc_Main.Controls.Clear();
            pc_Main.Dock = DockStyle.Fill;

            Dangkysangkien dangkysangkien = new Dangkysangkien();
            dangkysangkien.Dock = DockStyle.Fill;
            pc_Main.Controls.Add(dangkysangkien);

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Connect cn = new Connect();
            string pq;
            string dn = Form1.ID_USER;
            pq = cn.getPhanQuyen(dn);
            if (pq == "True")
            {
                pc_Main.Controls.Clear();
                pc_Main.Dock = DockStyle.Fill;

                Chuyengia chuyengia = new Chuyengia();
                chuyengia.Dock = DockStyle.Fill;
                pc_Main.Controls.Add(chuyengia);
            }
            else { MessageBox.Show("Bạn Không Có Quyền Truy Cập"); }
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Connect cn = new Connect();
            string pq;
            string dn = Form1.ID_USER;
            pq = cn.getPhanQuyen(dn);
            if (pq == "True")
            {
                pc_Main.Controls.Clear();
                pc_Main.Dock = DockStyle.Fill;

                Thanhlaphoidong thanhlaphoidong = new Thanhlaphoidong();
                thanhlaphoidong.Dock = DockStyle.Fill;
                pc_Main.Controls.Add(thanhlaphoidong);
            }
            else { MessageBox.Show("Bạn Không Có Quyền Truy Cập"); }
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Connect cn = new Connect();
            string pq;
            string dn = Form1.ID_USER;
            pq = cn.getPhanQuyen(dn);
            if (pq == "True")
            {
                pc_Main.Controls.Clear();
                pc_Main.Dock = DockStyle.Fill;

                Danhsachtacgia danhsachtacgia = new Danhsachtacgia();
                danhsachtacgia.Dock = DockStyle.Fill;
                pc_Main.Controls.Add(danhsachtacgia);
            }
            else { MessageBox.Show("Bạn Không Có Quyền Truy Cập"); }
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Connect cn = new Connect();
            string pq;
            string dn = Form1.ID_USER;
            pq = cn.getPhanQuyen(dn);
            if (pq == "True")
            {
                pc_Main.Controls.Clear();
            pc_Main.Dock = DockStyle.Fill;

            Danhsachnhanvien danhsachnhanvien = new Danhsachnhanvien();
            danhsachnhanvien.Dock = DockStyle.Fill;
            pc_Main.Controls.Add(danhsachnhanvien);
        }          else { MessageBox.Show("Bạn Không Có Quyền Truy Cập"); }
}

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            pc_Main.Controls.Clear();
            pc_Main.Dock = DockStyle.Fill;

            TyLeDongGop tldg = new TyLeDongGop();
            tldg.Dock = DockStyle.Fill;
            pc_Main.Controls.Add(tldg);

        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Connect cn = new Connect();
            string pq;
            string dn = Form1.ID_USER;
            pq = cn.getPhanQuyen(dn);
            if (pq == "True")
            {
                pc_Main.Controls.Clear();
                pc_Main.Dock = DockStyle.Fill;

                ThongTinNhanVien ttnv = new ThongTinNhanVien();
                ttnv.Dock = DockStyle.Fill;
                pc_Main.Controls.Add(ttnv);
            }
            else { MessageBox.Show("Bạn Không Có Quyền Truy Cập"); }
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Connect cn = new Connect();
            string pq;
            string dn = Form1.ID_USER;
            pq = cn.getPhanQuyen(dn);
            if (pq == "True")
            {
                pc_Main.Controls.Clear();
            pc_Main.Dock = DockStyle.Fill;

            Capnhatketquahoidong kq = new Capnhatketquahoidong();
            kq.Dock = DockStyle.Fill;
            pc_Main.Controls.Add(kq);
        }
          else { MessageBox.Show("Bạn Không Có Quyền Truy Cập"); }
}

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Connect cn = new Connect();
            string pq;
            string dn = Form1.ID_USER;
            pq = cn.getPhanQuyen(dn);
            if (pq == "True")
            {
                pc_Main.Controls.Clear();
                pc_Main.Dock = DockStyle.Fill;

                TinhTrang tt = new TinhTrang();
                tt.Dock = DockStyle.Fill;
                pc_Main.Controls.Add(tt);
            }
            else { MessageBox.Show("Bạn Không Có Quyền Truy Cập"); }
        }
    
    

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
            Form1 form = new Form1();
            form.Show();
        }
    }

}