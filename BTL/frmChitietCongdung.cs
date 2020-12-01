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
    public partial class frmChitietCongdung : Form
    {
        SystemConstant sys = new SystemConstant();
        DataTable dt;
        public frmChitietCongdung()
        {
            InitializeComponent();
            frmChitietCongdung_Load(null, null);
            if (frmLogin.session.role == 2)
            {
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnIn.Enabled = false;
            }
            Handling.FormHandling.clearBorderGroupBox(grxChitiet);             Handling.FormHandling.clearBorderGroupBox(gbxChucnang);
        }

        private void frmChitietCongdung_Load(object sender, EventArgs e)
        {
            dt = B_CongDung.GetAllCD();
            dgvCongDung.DataSource = dt;
        }
        private void btnCreateCode_Click(object sender, EventArgs e)
        {
            string newCode = Handling.InstanceHandling.AutoCreateKey(dt, "MaCongDung", "CD");
            txtMaCongDung.Text = newCode;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            CongDungDTO ob = checkData();
            if (ob != null)
            {
                if (checkDuplicate() == 1)
                {
                    MessageBox.Show("Mã Công Dụng Trùng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaCongDung.Focus();
                    return;
                }
                else
                {
                    B_CongDung.saveCD(ob, sys.INSERT);
                    MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dt = B_CongDung.GetAllCD();
                    dgvCongDung.DataSource = dt;
                    clearTxt();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (checkDuplicate() == 2)
            {
                MessageBox.Show("Không Có Mã Đó Để Thay Đổi Liên Quan", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaCongDung.Text = "";
                return;
            }
            else
            {
                CongDungDTO ob = checkData();
                if (ob != null)
                {
                    B_CongDung.saveCD(ob, sys.UPDATE);
                    MessageBox.Show("Sửa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dt = B_CongDung.GetAllCD();
                    dgvCongDung.DataSource = dt;
                    clearTxt();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (checkDuplicate() == 2)
            {
                MessageBox.Show("Không Có Mã Đó Để Thay Đổi Liên Quan", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaCongDung.Text = "";
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn Muốn Xóa Không ?", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    B_CongDung.DeleteCD(txtMaCongDung.Text);
                    MessageBox.Show("Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvCongDung.DataSource = B_CongDung.GetAllCD();
                    dt = B_CongDung.GetAllCD();
                    clearTxt();
                }
            }
        }

        private void dgvCongDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvCongDung.Rows[e.RowIndex];
                txtMaCongDung.Text = row.Cells[0].Value.ToString();
                txtTenCongDung.Text = row.Cells[1].Value.ToString();
            }
            catch
            {
            }
        }
        private void dgvCongDung_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dgvCongDung.Rows.Count - 1)
            {
                frmChitietCongdung f1 = new frmChitietCongdung();
                Handling.FormHandling.PreventFormMultipleTimes("Công Dụng", f1, "Công dụng");
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            Handling.ExcelAutomate.automateEx(dgvCongDung, "Thông Tin Công Dụng");
        }

        private void lblIntoCongDung_Click(object sender, EventArgs e)
        {
            frmChitietCongdung f1 = new frmChitietCongdung();
            Handling.FormHandling.PreventFormMultipleTimes(f1, "Công dụng");
        }

        private void dgvCongDung_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Handling.FormHandling.changeColorRowDataGridView(dgvCongDung);
        }
        /* in form handler*/
        public void clearTxt()
        {
            txtMaCongDung.Text = txtTenCongDung.Text = "";
        }
        private CongDungDTO checkData()
        {
            string ma = txtMaCongDung.Text;
            string ten = txtTenCongDung.Text;
            string z = string.Join("", txtMaCongDung.Text.Where(char.IsDigit));
            if (txtMaCongDung.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn Chưa Nhập Mã Công Dụng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaCongDung.Focus();
                return null;
            }
            else if (txtTenCongDung.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn Chưa Nhập Tên Công Dụng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenCongDung.Focus();
                return null;
            }
            else if (txtMaCongDung.Text.Contains("CD") == false)
            {
                MessageBox.Show("Nhập Theo Định Dạng Là \"CD\"", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                 txtMaCongDung.Focus();                 return null;
            }             else if (z == "")
            {
                MessageBox.Show("Nhập Theo Định Dạng Là \"CD\" và Thêm Số Đằng Sau", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                 txtMaCongDung.Focus();                 return null;
            }
            CongDungDTO dto = new CongDungDTO(ma, Handling.FormHandling.formatString(ten));
            return dto;
        }
        public int checkDuplicate() // insert
        {
            IEnumerable<DataRow> dtrow = default;
            dtrow = dt.AsEnumerable().Where(x => x.Field<string>("MaCongDung") == txtMaCongDung.Text);
            return dtrow.Count() > 0 ? 1 : 2;
        }

        
    }
}
