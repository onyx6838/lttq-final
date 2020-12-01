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
    public partial class frmMenuNhanvien : Form
    {
        public frmMenuNhanvien()
        {
            InitializeComponent();
        }
        public void switchMenu(GroupBox gbx)
        {
            frmMain frmMain = (frmMain)frmMain.ActiveForm;
            frmMain.panelNhiepvu.Controls.Clear();
            frmMain.panelMain.Controls.Clear();
            frmMain.panelKetquaTimKiem.Controls.Clear();
            frmMain.panelChucnang.Controls.Clear();
            //
            frmTimkiemhanghoa frmTimkiemhanghoa = new frmTimkiemhanghoa();
            frmTimkiemhanghoa.gbxTimkiem.Dock = DockStyle.Fill;
            frmMain.panelNhiepvu.Controls.Add(frmTimkiemhanghoa.gbxTimkiem);
            //
            gbx.Dock = DockStyle.Fill;
            frmMain.panelMain.Controls.Add(gbx);
        }
        public void BtnList_Click(object sender, EventArgs e)
        {
            frmChitietNhanvien frmBC = new frmChitietNhanvien();
            switchMenu(frmBC.gbxChitiet);
        }

        public void BtnCalam_Click(object sender, EventArgs e)
        {
            frmChitietCalamviec frmBC = new frmChitietCalamviec();
            switchMenu(frmBC.gbxChitiet);
        }

        public void BtnCongviec_Click(object sender, EventArgs e)
        {
            frmChitietCongviec frmBC = new frmChitietCongviec();
            switchMenu(frmBC.gbxChitiet);
        }
    }
}
