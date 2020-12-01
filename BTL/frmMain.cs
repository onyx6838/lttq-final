using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL
{
    public partial class frmMain : Form
    {
        frmQuanlyTK frmQLTK;
        frmBanhang frmBanHang;
        frmNhapHang frmNhapHang;
        frmKhohang frmKhoHang;
        public frmMain()
        {
            InitializeComponent();
            lbUser.Text += ": " + frmLogin.session.userName;
            lblDayNow.Text = DateTime.Now.ToLongDateString();
            lblTimeNow.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
            Handling.FormHandling.clearBorderGroupBox(grbChucnang);
            Handling.FormHandling.clearBorderGroupBox(grbBaocao);
            //
            btnKhoHang.BackColor = btnHome.BackColor = btnBanHang.BackColor = btnNhapHang.BackColor = Color.FromArgb(240, 238, 235);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimeNow.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            lbTieude.Text = "";
            panelBangDieuKhien.BorderStyle = BorderStyle.None;
            panelNhiepvu.BorderStyle = BorderStyle.None;
            HeThongToolStripMenuItem_Click(sender, e);
            BaocaoToolStripMenuItem_Click(sender, e);
            panelBangDieuKhien.Controls.Clear();
            panelNhiepvu.Controls.Clear();
            panelMain.Controls.Clear();
            panelKetquaTimKiem.Controls.Clear();
            panelChucnang.Controls.Clear();
            ptbTieude.Image = null;
            lbThongbao.Visible = false;
            if (frmLogin.session.role == 2) QuanlyTkToolStripMenuItem.Visible = false;
        }

        private void HeThongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMenuHeThong frmMenuHeThong = new FrmMenuHeThong
            {
                TopLevel = false,
                AutoScroll = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            this.grbChucnang.Controls.Clear();
            this.grbChucnang.Controls.Add(frmMenuHeThong);
            frmMenuHeThong.Show();
            this.grbChucnang.Text = "Hệ thống";
        }
        private void BaocaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMenuBaocao form = new frmMenuBaocao
            {
                TopLevel = false,
                AutoScroll = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            this.grbBaocao.Controls.Clear();
            this.grbBaocao.Controls.Add(form);
            this.grbBaocao.Text = "Báo cáo";
            form.Show();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            FormMain_Load(sender, e);
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            if (frmBanHang == null)
            {
                frmBanHang = new frmBanhang();
                Handling.FormHandling.PreventFormMultipleTimes(frmBanHang, "Bán hàng");
            }
            else
            {
                frmBanHang.Close();
                frmBanHang = null;
            }
            //frmBanhang frm = new frmBanhang();
            //Handling.FormHandling.PreventFormMultipleTimes(frm, "Bán hàng");
        }

        private void hàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMenuHeThong frm = new FrmMenuHeThong();
            frm.BtnHanghoa_Click(sender, e);
        }

        private void nhómToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMenuHanghoa frm = new frmMenuHanghoa();
            frm.BtnNhom_Click(sender, e);
        }

        private void thểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMenuHanghoa frm = new frmMenuHanghoa();
            frm.BtnTheloai_Click(sender, e);
        }

        private void đơnVịTínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMenuHanghoa frm = new frmMenuHanghoa();
            frm.BtnDonvitinh_Click(sender, e);
        }

        private void chấtLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMenuHanghoa frm = new frmMenuHanghoa();
            frm.BtnChatlieu_Click(sender, e);
        }

        private void côngDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMenuHanghoa frm = new frmMenuHanghoa();
            frm.BtnCongdung_Click(sender, e);
        }

        private void nơiSảnXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMenuHanghoa frm = new frmMenuHanghoa();
            frm.BtnNoisanxuat_Click(sender, e);
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMenuHeThong frm = new FrmMenuHeThong();
            frm.BtnNhanvien_Click(sender, e);
        }

        private void caLàmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMenuNhanvien frm = new frmMenuNhanvien();
            frm.BtnCalam_Click(sender, e);
        }

        private void côngViệcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMenuNhanvien frm = new frmMenuNhanvien();
            frm.BtnCongviec_Click(sender, e);
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMenuHeThong frm = new FrmMenuHeThong();
            frm.BtnKhachhang_Click(sender, e);
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMenuHeThong frm = new FrmMenuHeThong();
            frm.BtnNhacungcap_Click(sender, e);
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMenuHeThong frm = new FrmMenuHeThong();
            frm.BtnHoadon_Click(sender, e);
        }

        private void hóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMenuHoaDon frm = new frmMenuHoaDon();
            frm.BtnHDN_Click(sender, e);
        }

        private void hóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMenuHoaDon frm = new frmMenuHoaDon();
            frm.btnHDB_Click(sender, e);
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMenuBaocao frm = new frmMenuBaocao();
            frm.BtnBCsanpham_Click(sender, e);
        }

        private void hóaĐơnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMenuBaocao frm = new frmMenuBaocao();
            frm.BtnBChoadon_Click(sender, e);
        }

        private void nhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMenuBaocao frm = new frmMenuBaocao();
            frm.BtnBCnhanvien_Click(sender, e);
        }

        private void kháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMenuBaocao frm = new frmMenuBaocao();
            frm.BtnBCKhachhang_Click(sender, e);
        }

        private void QuanlyTkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmQLTK == null)
            {
                frmQLTK = new frmQuanlyTK();
                frmQLTK.Show();
            }
            else
            {
                frmQLTK.Close();
                frmQLTK = null;
            }
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            if (frmNhapHang == null)
            {
                frmNhapHang = new frmNhapHang();
                Handling.FormHandling.PreventFormMultipleTimes(frmNhapHang, "Nhập hàng");
            }
            else
            {
                frmNhapHang.Close();
                frmNhapHang = null;
            }
        }

        private void btnKhoHang_Click(object sender, EventArgs e)
        {
            if (frmKhoHang == null)
            {
                frmKhoHang = new frmKhohang();
                Handling.FormHandling.PreventFormMultipleTimes(frmKhoHang, "Kho hàng");
            }
            else
            {
                frmKhoHang.Close();
                frmKhoHang = null;
            }
            //frmKhohang frm = new frmKhohang();
            //Handling.FormHandling.PreventFormMultipleTimes(frm, "Kho hàng");
        }

        private void DangxuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            if (frmQLTK != null) frmQLTK.Close();
        }

        private void TrogiupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nhóm 5 - CNTT2 - K59 - DHGTVT \n Thành viên:\n Đoàn Minh Giang\n Trần Tiến Thành\n Lê Minh Chương\n Bùi Văn Ngọc\n Nghiêm Văn Xuân", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();

            if (frmQLTK != null) frmQLTK.Close();
            if (frmNhapHang != null) frmNhapHang.Close();
            if (frmBanHang != null) frmBanHang.Close();
            if (frmKhoHang != null) frmKhoHang.Close();
        }
    }
}
