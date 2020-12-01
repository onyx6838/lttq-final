using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace BTL
{
    public partial class frmMenuBaocaohoadon : Form
    {
        public frmMenuBaocaohoadon()
        {
            InitializeComponent();
        }
        public void switchMenu(GroupBox grx1, ReportViewer vw1)
        {
            frmMain frmMain = (frmMain)frmMain.ActiveForm;
            frmMain.panelNhiepvu.Controls.Clear();
            frmMain.panelMain.Controls.Clear();
            frmMain.panelKetquaTimKiem.Controls.Clear();
            frmMain.panelChucnang.Controls.Clear();
            //
            grx1.Dock = DockStyle.Fill;
            vw1.Dock = DockStyle.Fill;
            frmMain.panelNhiepvu.Controls.Add(grx1);
            frmMain.panelMain.Controls.Add(vw1);
        }
        public void BtnHoaTonghoadonnhap_Click(object sender, EventArgs e)
        {
            frmBaocaoTongnhap frmBC = new frmBaocaoTongnhap();
            switchMenu(frmBC.gbxNghiepvu, frmBC.rpvChitiet);
        }

        private void BtnTonghoadonban_Click(object sender, EventArgs e)
        {
            frmBaocaoTongban frmBC = new frmBaocaoTongban();
            switchMenu(frmBC.gbxNghiepvu, frmBC.rpvChitiet);
        }

        private void btnTopNhap_Click(object sender, EventArgs e)
        {
            frmBaocaoTopHDN frmBC = new frmBaocaoTopHDN();
            switchMenu(frmBC.gbxNghiepvu, frmBC.rpvChitiet);
        }

        private void btnTopBan_Click(object sender, EventArgs e)
        {
            frmBaocaoTopHDB frmBC = new frmBaocaoTopHDB();
            switchMenu(frmBC.gbxNghiepvu, frmBC.rpvChitiet);
        }
    }
}
