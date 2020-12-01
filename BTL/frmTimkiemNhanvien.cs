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
    public partial class frmTimkiemNhanvien : Form
    {
        public frmTimkiemNhanvien()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMain formMain = (frmMain)frmMain.ActiveForm;
            formMain.panelKetquaTimKiem.Controls.Clear();
            this.gbxKetqua.Dock = DockStyle.Fill;
            formMain.panelKetquaTimKiem.Controls.Add(this.gbxKetqua);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMain formMain = (frmMain)frmMain.ActiveForm;
            formMain.panelKetquaTimKiem.Controls.Clear();
        }
    }
}
