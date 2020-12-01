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
    public partial class frmChitietChatlieu : Form
    {
        SystemConstant sys = new SystemConstant();
        DataTable dt;
        public frmChitietChatlieu()
        {
            InitializeComponent();
            frmChitietChatlieu_Load(null, null);
            if (frmLogin.session.role == 2)
            {
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnIn.Enabled = false;
            }
            Handling.FormHandling.clearBorderGroupBox(gbxChitiet);             Handling.FormHandling.clearBorderGroupBox(gbxChucnang);
        }
        private void frmChitietChatlieu_Load(object sender, EventArgs e)
        {
            dt = B_ChatLieu.GetAllCL();
            dgvChatLieu.DataSource = dt;
        }

        private void btnCreateCode_Click(object sender, EventArgs e)
        {
            string newCode = Handling.InstanceHandling.AutoCreateKey(dt, "MaChatLieu", "CL");
            txtMaChatLieu.Text = newCode;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            ChatLieuDTO ob = checkData();
            if (ob != null)
            {
                if (checkDuplicate() == 1)
                {
                    MessageBox.Show("Mã Chất Liệu Trùng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaChatLieu.Focus();
                    return;
                }
                else
                {
                    B_ChatLieu.saveCL(ob, sys.INSERT);
                    MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dt = B_ChatLieu.GetAllCL();
                    dgvChatLieu.DataSource = dt;
                    clearTxt();
                }
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (checkDuplicate() == 2)
            {
                MessageBox.Show("Không Có Mã Đó Để Thay Đổi Liên Quan", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaChatLieu.Text = "";
                return;
            }
            else
            {
                ChatLieuDTO ob = checkData();
                if (ob != null)
                {
                    B_ChatLieu.saveCL(ob, sys.UPDATE);
                    MessageBox.Show("Sửa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dt = B_ChatLieu.GetAllCL();
                    dgvChatLieu.DataSource = dt;
                    clearTxt();
                }
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (checkDuplicate() == 2)
            {
                MessageBox.Show("Không Có Mã Đó Để Thay Đổi Liên Quan", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaChatLieu.Text = "";
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn muốn xóa không ?", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    B_ChatLieu.DeleteCL(txtMaChatLieu.Text);
                    MessageBox.Show("Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvChatLieu.DataSource = B_ChatLieu.GetAllCL();
                    dt = B_ChatLieu.GetAllCL();
                    clearTxt();
                }
            
            }
        }
        private void dgvChatLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvChatLieu.Rows[e.RowIndex];
                txtMaChatLieu.Text = row.Cells[0].Value.ToString();
                txtTenChatLieu.Text = row.Cells[1].Value.ToString();
            }
            catch
            {
            }
        }
        private void dgvChatLieu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dgvChatLieu.Rows.Count - 1)
            {
                frmChitietChatlieu f1 = new frmChitietChatlieu();                 Handling.FormHandling.PreventFormMultipleTimes("Chất liệu", f1, "Chất liệu");
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            Handling.ExcelAutomate.automateEx(dgvChatLieu, "Thông Tin Chất Liệu");
        }

        private void lblIntoChatLieu_Click(object sender, EventArgs e)
        {
            frmChitietChatlieu f1 = new frmChitietChatlieu();
            Handling.FormHandling.PreventFormMultipleTimes(f1, "Chất liệu");
        }

        private void dgvChatLieu_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Handling.FormHandling.changeColorRowDataGridView(dgvChatLieu);
        }
        /* in form handler */
        public void clearTxt()
        {
            txtMaChatLieu.Text = txtTenChatLieu.Text = "";
        }
        private ChatLieuDTO checkData()
        {
            string ma = txtMaChatLieu.Text;
            string ten = txtTenChatLieu.Text;
            string z = string.Join("", txtMaChatLieu.Text.Where(char.IsDigit));
            if (txtMaChatLieu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn Chưa Nhập Mã Chất Liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaChatLieu.Focus();
                return null;
            }
            else if (txtTenChatLieu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn Chưa Nhập Tên Chất Liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenChatLieu.Focus();
                return null;
            }
            else if (txtMaChatLieu.Text.Contains("CL") == false)
            {
                MessageBox.Show("Nhập Theo Định Dạng Là \"CL\"", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                 txtMaChatLieu.Focus();                 return null;
            }             else if (z == "")
            {
                MessageBox.Show("Nhập Theo Định Dạng Là \"CL\" và Thêm Số Đằng Sau", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                 txtMaChatLieu.Focus();                 return null;
            }
            ChatLieuDTO dto = new ChatLieuDTO(ma, Handling.FormHandling.formatString(ten));
            return dto;
        }
        public int checkDuplicate() // insert
        {
            IEnumerable<DataRow> dtrow = default;
            dtrow = dt.AsEnumerable().Where(x => x.Field<string>("MaChatLieu") == txtMaChatLieu.Text);
            return dtrow.Count() > 0 ? 1 : 2;
        }

        
    }
}
