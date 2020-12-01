using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL
{
    public partial class frmMenuHanghoa : Form
    {
        public frmMenuHanghoa()
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
        public void BtnListhanghoa_Click(object sender, EventArgs e)
        {
            frmChitietHanghoa frmBC = new frmChitietHanghoa();
            switchMenu(frmBC.gbxChitiet);
        }
        public void BtnNhom_Click(object sender, EventArgs e)
        {
            frmChitietNhomhanghoa frmBC = new frmChitietNhomhanghoa();
            switchMenu(frmBC.gbxChitiet);
        }
        public void BtnTheloai_Click(object sender, EventArgs e)
        {
            frmChitietTheloai frmBC = new frmChitietTheloai();
            switchMenu(frmBC.gbxChitiet);
        }
        public void BtnDonvitinh_Click(object sender, EventArgs e)
        {
            frmChitietDonvitinh frmBC = new frmChitietDonvitinh();
            switchMenu(frmBC.gbxChitiet);
        }
        public void BtnChatlieu_Click(object sender, EventArgs e)
        {
            frmChitietChatlieu frmBC = new frmChitietChatlieu();
            switchMenu(frmBC.gbxChitiet);
        }
        public void BtnCongdung_Click(object sender, EventArgs e)
        {
            frmChitietCongdung frmBC = new frmChitietCongdung();
            switchMenu(frmBC.grxChitiet);
        }
        public void BtnNoisanxuat_Click(object sender, EventArgs e)
        {
            frmChitietNoisanxuat frmBC = new frmChitietNoisanxuat();
            switchMenu(frmBC.gbxChitiet);
        }
    }
}
