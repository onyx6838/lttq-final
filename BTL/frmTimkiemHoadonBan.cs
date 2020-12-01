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
    public partial class frmTimkiemHoadonBan : Form
    {
        public frmTimkiemHoadonBan()
        {
            InitializeComponent();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            frmMain formMain = (frmMain)frmMain.ActiveForm;
            this.gbxKetqua.Dock = DockStyle.Fill;
            formMain.panelKetquaTimKiem.Controls.Clear();
            formMain.panelKetquaTimKiem.Controls.Add(this.gbxKetqua);
        }

        private void BtnLamlai_Click(object sender, EventArgs e)
        {
            frmMain formMain = (frmMain)frmMain.ActiveForm;
            formMain.panelKetquaTimKiem.Controls.Clear();
        }

        private void cbNgaythang_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNgaythang.Checked == true)
            {
                gbxNgaythang.Visible = true;
            }
            else if(cbNgaythang.Checked == false)
            {
                gbxNgaythang.Visible = false;
            }
        }

        private void frmTimkiemHoadonBan_Load(object sender, EventArgs e)
        {
            gbxNgaythang.Visible = false;
        }
    }
}
