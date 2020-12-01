using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL
{
    public partial class frmLogin : Form
    {
        private const int EM_SETCUEBANNER = 0x1501;
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);
        /* placeholder*/
        public static UserDTO session;
        public frmLogin()
        {
            InitializeComponent();
        }
        private void loadTextBox()
        {
            SendMessage(txtAccount.Handle, EM_SETCUEBANNER, 0, "Nhập Tài Khoản");
            SendMessage(txtPassword.Handle, EM_SETCUEBANNER, 0, "Nhập Mật Khẩu");
        }
        private void llbDangky_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDangkiTK frm = new frmDangkiTK();
            Visible = false;
            frm.Show();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            string userName = txtAccount.Text;
            string passWord = txtPassword.Text;
            //UserDTO user = new UserDTO(userName, passWord);
            //session = user;
            int a = int.Parse(B_User.getRole("select dbo.loginWithRole('" + userName + "','" + passWord + "')"));
            if (a == 1)
            {
                DataTable kq = B_User.getInfoAccount(userName);
                List<UserDTO> listUs = Handling.InstanceHandling.ConvertDataTable<UserDTO>(kq);
                var dto = listUs.First();
                session = dto;
                Hide();
                frmMain frm = new frmMain();
                frm.Show();

                Visible = false;
            }
            else if (a == 2)
            {
                DataTable kq = B_User.getInfoAccount(userName);
                List<UserDTO> listUs = Handling.InstanceHandling.ConvertDataTable<UserDTO>(kq);
                var dto = listUs.First();
                session = dto;
                Hide();
                frmMain frm = new frmMain();
                frm.Show();
                Visible = false;
            }
            else if (a == -1)
            {
                MessageBox.Show("Sai Mật Khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassword.Focus();
                return;
            }
            else
            {
                MessageBox.Show("Chưa Có Tài Khoản", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAccount.Focus();
                return;
            }
            #region TTT code
            /*this.Hide();
            frmMain frm = new frmMain();
            frm.Show();*/
            #endregion
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            cbxVisible.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            loadTextBox();
        }

        private void cbxVisible_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxVisible.Checked == true) txtPassword.PasswordChar = default(char);
            else txtPassword.PasswordChar = '*';
        }

        private void llbQMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegistration frm = new frmRegistration();
            Visible = false;
            frm.Show();
        }

        private void btnHuybo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                btnDangnhap.PerformClick();
            }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
