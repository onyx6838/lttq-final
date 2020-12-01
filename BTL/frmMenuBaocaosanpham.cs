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
    public partial class frmMenuBaocaosanpham : Form
    {
        public frmMenuBaocaosanpham()
        {
            InitializeComponent();
        }

        public void BtnBanchay_Click(object sender, EventArgs e)
        {
            //
            frmMain frmMain = (frmMain)frmMain.ActiveForm;
            frmMain.panelNhiepvu.Controls.Clear();
            frmMain.panelMain.Controls.Clear();
            frmMain.panelKetquaTimKiem.Controls.Clear();
            frmMain.panelChucnang.Controls.Clear();
            //
            frmBaocaoSanpham frm = new frmBaocaoSanpham();
            frm.gbxNghiepvu.Dock = DockStyle.Fill;
            frmMain.panelNhiepvu.Controls.Add(frm.gbxNghiepvu);
            frm.rpvChitiet.Dock = DockStyle.Fill;
            frmMain.panelMain.Controls.Add(frm.rpvChitiet);
            //
        }
    }
}
