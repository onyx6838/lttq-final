using BTL.Properties;
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
    public partial class frmMenuHoaDon : Form
    {
        public frmMenuHoaDon()
        {
            InitializeComponent();
        }
        private void FormMenuHoaDon_Load(object sender, EventArgs e)
        {
            btnHDB.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            btnHDN.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }
        public void switchMenu(GroupBox gbx)
        {
            frmMain frmMain = (frmMain)frmMain.ActiveForm;
            frmMain.panelNhiepvu.Controls.Clear();
            frmMain.panelMain.Controls.Clear();
            frmMain.panelKetquaTimKiem.Controls.Clear();
            frmMain.panelChucnang.Controls.Clear();
            //
            frmTimkiemHoadonNhap frm = new frmTimkiemHoadonNhap();
            frm.gbxTimkiem.Dock = DockStyle.Fill;
            frmMain.panelNhiepvu.Controls.Add(frm.gbxTimkiem);
            //
            gbx.Dock = DockStyle.Fill;
            frmMain.panelMain.Controls.Add(gbx);
        }
        public void BtnHDN_Click(object sender, EventArgs e)
        {
            frmChitietHDN frmBC = new frmChitietHDN();
            switchMenu(frmBC.gbxChitiet);
        }

        public void btnHDB_Click(object sender, EventArgs e)
        {
            frmChitietHDB frmBC = new frmChitietHDB();
            switchMenu(frmBC.gbxChitiet);
        }
    }
}
