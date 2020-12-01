using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;

namespace BTL
{
    public partial class frmMenuBaocaokhachhang : Form
    {
        public frmMenuBaocaokhachhang()
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
        public void BtnMuanhieu_Click(object sender, EventArgs e)
        {
            frmBaocaoKhachhangmuanhieu frmBC = new frmBaocaoKhachhangmuanhieu();
            switchMenu(frmBC.gbxNghiepvu, frmBC.rpvChitiet);
        }

        private void BtnMuait_Click(object sender, EventArgs e)
        {
            frmBaocaoKhachhangmuait frmBC = new frmBaocaoKhachhangmuait();
            switchMenu(frmBC.gbxNghiepvu, frmBC.rpvChitiet);
        }
    }
}
