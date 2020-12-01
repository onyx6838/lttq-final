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
    public partial class frmRegistration : Form
    {
        static SystemConstant sys = new SystemConstant();
        public frmRegistration()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            Close();
            frm.Show();
            Visible = false;
        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {

        }

        private void btnRegis_Click(object sender, EventArgs e)
        {
            UserDTO user = checkData();
            if (user != null)
            {
                MessageBox.Show("Đổi Mật Khẩu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                B_User.updateAccount(user, user.id, sys.UPDATE);
                btnCancel_Click(sender, e);
            }
        }
        private UserDTO checkData()
        {
            string tk = txtNewAccount.Text;
            string pwd = txtNewPassword.Text;
            string newPwd = txtPwdAgain.Text;
            if (txtNewPassword.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa Nhập Mật Khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNewPassword.Focus();
                return null;
            }
            else if (txtNewAccount.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa Nhập Tài Khoản", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNewAccount.Focus();
                return null;
            }
            else if (txtPwdAgain.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa Nhập Lại Mật Khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPwdAgain.Focus();
                return null;
            }
            else if (string.Compare(txtNewPassword.Text, txtPwdAgain.Text) != 0)
            {
                MessageBox.Show("Mật Khẩu Nhập Lại Chưa Trùng Với Mật Khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPwdAgain.Focus();
                return null;
            }
            DataTable kq = B_User.getInfoAccount(tk);
            if (kq.Rows.Count == 0)
            {
                MessageBox.Show("Tài Khoản Không Tồn Tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNewAccount.Focus();
                return null;
            }
            List<UserDTO> listUs = Handling.InstanceHandling.ConvertDataTable<UserDTO>(kq);
            var dto = listUs.First();

            UserDTO user = new UserDTO(tk, pwd, 1, dto.role);
            UserDTO userWithId = new UserDTO(dto.id, tk, pwd, 1, dto.role);
            return userWithId;
        }
    }
}
