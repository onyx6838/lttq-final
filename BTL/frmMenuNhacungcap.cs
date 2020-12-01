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
    public partial class frmMenuNhacungcap : Form
    {
        public frmMenuNhacungcap()
        {
            InitializeComponent();
        }

        public void btnList_Click(object sender, EventArgs e)
        {
            //
            frmMain formMain = (frmMain)frmMain.ActiveForm;
            formMain.panelKetquaTimKiem.Controls.Clear();
            formMain.panelNhiepvu.Controls.Clear();
            formMain.panelMain.Controls.Clear();
            formMain.panelChucnang.Controls.Clear();
            //
            frmTimkiemNhacungcap frmTimkiemNhacungcap = new frmTimkiemNhacungcap();
            frmTimkiemNhacungcap.gbxTimkiem.Dock = DockStyle.Fill;
            formMain.panelNhiepvu.Controls.Add(frmTimkiemNhacungcap.gbxTimkiem);
            //
            frmChitietNhacungcap frmChitietNhacungcap = new frmChitietNhacungcap();
            frmChitietNhacungcap.gbxChitiet.Dock = DockStyle.Fill;
            formMain.panelMain.Controls.Add(frmChitietNhacungcap.gbxChitiet);
            //
           
            //
        }
    }
}
