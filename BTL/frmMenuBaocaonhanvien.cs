using Microsoft.Reporting.WinForms;
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
    public partial class frmMenuBaocaonhanvien : Form
    {
        public frmMenuBaocaonhanvien()
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
        public void BtnNVNhap_Click(object sender, EventArgs e)
        {
            frmBaocaoNhanVienNhap frmBC = new frmBaocaoNhanVienNhap();
            switchMenu(frmBC.gbxNghiepvu, frmBC.rpvChitiet);
        }

        private void BtnNVBan_Click(object sender, EventArgs e)
        {
            frmBaocaoNhanVienBan frmBC = new frmBaocaoNhanVienBan();
            switchMenu(frmBC.gbxNghiepvu, frmBC.rpvChitiet);
        }
    }
}
