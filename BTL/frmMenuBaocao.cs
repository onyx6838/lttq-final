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
    public partial class frmMenuBaocao : Form
    {
        public frmMenuBaocao()
        {
            InitializeComponent();
        }
        public void switchMenu(Form focusFrm, string Title, Image ImgTitle)
        {
            frmMain frmMain = (frmMain)ActiveForm;
            frmMain.panelBangDieuKhien.Controls.Clear();
            frmMain.panelNhiepvu.Controls.Clear();
            frmMain.panelMain.Controls.Clear();
            frmMain.panelKetquaTimKiem.Controls.Clear();
            frmMain.panelChucnang.Controls.Clear();
            //
            focusFrm.TopLevel = false;
            focusFrm.AutoScroll = false;
            focusFrm.FormBorderStyle = FormBorderStyle.None;
            focusFrm.Dock = DockStyle.Fill;
            //
            frmMain.panelBangDieuKhien.Controls.Add(focusFrm);
            frmMain.lbTieude.Visible = true;
            frmMain.lbTieude.Text = "Báo Cáo " + Title;
            frmMain.ptbTieude.Image = ImgTitle;
            focusFrm.Show();
        }
        private void FrmMenuBaocao_Load(object sender, EventArgs e)
        {
            btnBChoadon.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            btnBCKhachhang.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            btnBCnhanvien.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            btnBCsanpham.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }
        public void BtnBCsanpham_Click(object sender, EventArgs e)
        {
            frmMenuBaocaosanpham frm = new frmMenuBaocaosanpham();
            switchMenu(frm, btnBCsanpham.Text, btnBCsanpham.Image);
            frm.BtnBanchay_Click(sender, e);
        }

        public void BtnBChoadon_Click(object sender, EventArgs e)
        {
            frmMenuBaocaohoadon frm = new frmMenuBaocaohoadon();
            switchMenu(frm, btnBChoadon.Text, btnBChoadon.Image);
            frm.BtnHoaTonghoadonnhap_Click(sender, e);
        }

        public void BtnBCKhachhang_Click(object sender, EventArgs e)
        {
            frmMenuBaocaokhachhang frm = new frmMenuBaocaokhachhang();
            switchMenu(frm, btnBCKhachhang.Text, btnBCKhachhang.Image);
            frm.BtnMuanhieu_Click(sender, e);
        }

        public void BtnBCnhanvien_Click(object sender, EventArgs e)
        {
            frmMenuBaocaonhanvien frm = new frmMenuBaocaonhanvien();
            switchMenu(frm, btnBCnhanvien.Text, btnBCnhanvien.Image);
            frm.BtnNVNhap_Click(sender, e);
        }
    }
}
