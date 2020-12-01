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
    public partial class frmMenuKhachHang : Form
    {
        public frmMenuKhachHang()
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
            frmTimkiemKhachhang frmTimkiemKhachhang = new frmTimkiemKhachhang();
            frmTimkiemKhachhang.gbxTimkiem.Dock = DockStyle.Fill;
            formMain.panelNhiepvu.Controls.Add(frmTimkiemKhachhang.gbxTimkiem);
            //
            frmChitietKhachhang  frmChitietKhachhang= new frmChitietKhachhang();
            frmChitietKhachhang.gbxChitiet.Dock = DockStyle.Fill;
            formMain.panelMain.Controls.Add(frmChitietKhachhang.gbxChitiet);
            //
            
            //
        }
    }
}
