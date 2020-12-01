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
    public partial class frmBaocaoTongnhap : Form
    {
        public frmBaocaoTongnhap()
        {
            InitializeComponent();
        }

        private void FormBaocaoTopban_Load(object sender, EventArgs e)
        {

            this.rpvChitiet.RefreshReport();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

        }
    }
}
