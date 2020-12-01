using BUS;
using Constant;
using DTO;
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
    public partial class frmDangkiTK : Form
    {
        DataTable dt;
        SystemConstant sys = new SystemConstant();
        public frmDangkiTK()
        {
            InitializeComponent();
        }

        private void frmDangkiTK_Load(object sender, EventArgs e)
        {
            dt = B_User.getAllAccount();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDangkiTK_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            UserDTO ob = checkData();             if (ob != null)             {                 if (checkDuplicate() == 1)                 {                     MessageBox.Show("Tài Khoản Đã Tồn Tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                     txtTenTK.Focus();                     return;                 }                 else                 {                     B_User.saveAccount(ob, sys.INSERT);                     MessageBox.Show("Tạo Tài Khoản Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                     dt = B_User.getAllAccount();                     Close();                 }             }
        }
        /* in form handler*/
        private UserDTO checkData()
        {
            string MK = txtMK.Text;
            string tk = txtTenTK.Text;
            string reMK = txtReMK.Text;
            if (txtMK.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn Chưa Nhập Mật Khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMK.Focus();
                return null;
            }
            else if (txtTenTK.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn Chưa Nhập Tên Tài Khoản", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenTK.Focus();
                return null;
            }
            else if (txtReMK.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa Nhập Lại Mật Khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtReMK.Focus();
                return null;
            }
            else if (MK != reMK)
            {
                MessageBox.Show("Bạn Chưa Nhập Mật Khẩu 1 Và 2 Chưa Trùng Khớp ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtReMK.Focus();
                return null;
            }
            UserDTO dto = new UserDTO(tk, MK, 1, 2);
            return dto;
        }
        public int checkDuplicate() // insert
        {             IEnumerable<DataRow> dtrow = default;             dtrow = dt.AsEnumerable().Where(x => x.Field<string>("userName") == txtTenTK.Text);             return dtrow.Count() > 0 ? 1 : 2;         }

        private void cbxVisible_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxVisible.Checked == true) txtMK.PasswordChar = txtReMK.PasswordChar = default;
            else txtMK.PasswordChar = txtReMK.PasswordChar = '*';
        }
    }
}
