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
    public partial class FrmMenuHeThong : Form
    {
        public FrmMenuHeThong()
        {
            InitializeComponent();
        }

        public void BtnHanghoa_Click(object sender, EventArgs e)
        {
            //
            frmMain frmMain = (frmMain)frmMain.ActiveForm;
            frmMain.panelBangDieuKhien.Controls.Clear();
            frmMain.panelNhiepvu.Controls.Clear();
            frmMain.panelMain.Controls.Clear();
            frmMain.panelKetquaTimKiem.Controls.Clear();
            frmMain.panelChucnang.Controls.Clear();
            //
            frmMenuHanghoa frm = new frmMenuHanghoa
            {
                TopLevel = false,
                AutoScroll = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            frmMain.panelBangDieuKhien.Controls.Add(frm);
            frmMain.ptbTieude.Image = btnHanghoa.Image;
            frmMain.lbTieude.Text = btnHanghoa.Text;
            frmMain.lbTieude.Visible = true;
            frmMain.lbThongbao.Visible = true;
            frm.Show();
            frm.BtnListhanghoa_Click(sender, e);
            //
            }

        public void FrmMenuHeThong_Load(object sender, EventArgs e)
        {
            btnHanghoa.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            btnKhachhang.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            btnNhanvien.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            btnNhacungcap.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }

        public void BtnNhanvien_Click(object sender, EventArgs e)
        {
            //
            frmMain frmMain = (frmMain)frmMain.ActiveForm;
            frmMain.panelBangDieuKhien.Controls.Clear();
            frmMain.panelNhiepvu.Controls.Clear();
            frmMain.panelMain.Controls.Clear();
            frmMain.panelKetquaTimKiem.Controls.Clear();
            frmMain.panelChucnang.Controls.Clear();
            //
            frmMenuNhanvien frm = new frmMenuNhanvien
            {
                TopLevel = false,
                AutoScroll = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            frmMain.panelBangDieuKhien.Controls.Add(frm);
            frmMain.ptbTieude.Image = btnNhanvien.Image;
            frmMain.lbTieude.Text = btnNhanvien.Text;
            frmMain.lbTieude.Visible = true;
            frmMain.lbThongbao.Visible = true;
            frm.Show();
            frm.BtnList_Click(sender, e);
            //
        }

        public void BtnKhachhang_Click(object sender, EventArgs e)
        {
            //
            frmMain frmMain = (frmMain)frmMain.ActiveForm;
            frmMain.panelBangDieuKhien.Controls.Clear();
            frmMain.panelNhiepvu.Controls.Clear();
            frmMain.panelMain.Controls.Clear();
            frmMain.panelKetquaTimKiem.Controls.Clear();
            frmMain.panelChucnang.Controls.Clear();
            //
            frmMenuKhachHang frm = new frmMenuKhachHang
            {
                TopLevel = false,
                AutoScroll = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            frmMain.panelBangDieuKhien.Controls.Add(frm);
            frmMain.ptbTieude.Image = btnKhachhang.Image;
            frmMain.lbTieude.Text = btnKhachhang.Text;
            frmMain.lbTieude.Visible = true;
            frmMain.lbThongbao.Visible = true;
            frm.Show();
            frm.btnList_Click(sender, e);
            //
        }

        public void BtnNhacungcap_Click(object sender, EventArgs e)
        {
            //
            frmMain frmMain = (frmMain)frmMain.ActiveForm;
            frmMain.panelBangDieuKhien.Controls.Clear();
            frmMain.panelNhiepvu.Controls.Clear();
            frmMain.panelMain.Controls.Clear();
            frmMain.panelKetquaTimKiem.Controls.Clear();
            frmMain.panelChucnang.Controls.Clear();
            //
            frmMenuNhacungcap frm = new frmMenuNhacungcap
            {
                TopLevel = false,
                AutoScroll = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            frmMain.panelBangDieuKhien.Controls.Add(frm);
            frmMain.ptbTieude.Image = btnNhacungcap.Image;
            frmMain.lbTieude.Text = btnNhacungcap.Text;
            frmMain.lbTieude.Visible = true;
            frmMain.lbThongbao.Visible = true;
            frm.Show();
            frm.btnList_Click(sender, e);
        }

        public void BtnHoadon_Click(object sender, EventArgs e)
        {
            //
            frmMain frmMain = (frmMain)frmMain.ActiveForm;
            frmMain.panelBangDieuKhien.Controls.Clear();
            frmMain.panelNhiepvu.Controls.Clear();
            frmMain.panelMain.Controls.Clear();
            frmMain.panelKetquaTimKiem.Controls.Clear();
            frmMain.panelChucnang.Controls.Clear();
            //
            frmMenuHoaDon formMenuHoaDon = new frmMenuHoaDon()
            {
                TopLevel = false,
                AutoScroll = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            frmMain.panelBangDieuKhien.Controls.Add(formMenuHoaDon);
            frmMain.lbTieude.Text = btnHoadon.Text;
            frmMain.ptbTieude.Image = btnHoadon.Image;
            frmMain.lbThongbao.Visible = true;
            formMenuHoaDon.Show();
            formMenuHoaDon.BtnHDN_Click(sender, e);
        }
    }
}
