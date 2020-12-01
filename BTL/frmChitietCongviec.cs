using BUS;
using Constant;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BTL
{
    public partial class frmChitietCongviec : Form
    {
        SystemConstant sys = new SystemConstant();
        DataTable dt;
        public frmChitietCongviec()
        {
            InitializeComponent();
            frmChitietCongviec_Load(null, null);
            if (frmLogin.session.role == 2)
            {
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnIn.Enabled = false;
            }
            Handling.FormHandling.clearBorderGroupBox(gbxChitiet);             Handling.FormHandling.clearBorderGroupBox(gbxChucnang);
        }

        private void dgvCongViec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvCongViec.Rows[e.RowIndex];
                txtMaCongViec.Text = row.Cells[0].Value.ToString();
                txtTenCongViec.Text = row.Cells[1].Value.ToString();
            }
            catch
            {
            }
        }
        private void btnCreateCode_Click(object sender, EventArgs e)
        {
            string newCode = Handling.InstanceHandling.AutoCreateKey(dt, "MaCV", "CV");
            txtMaCongViec.Text = newCode;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            CongViecDTO ob = checkData();
            if (ob != null)
            {
                if (checkDuplicate() == 1)
                {
                    MessageBox.Show("Mã Công Việc Trùng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaCongViec.Focus();
                    return;
                }
                else
                {
                    B_CongViec.saveCV(ob, sys.INSERT);
                    MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dt = B_CongViec.GetAllCV();
                    dgvCongViec.DataSource = dt;
                    clearTxt();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (checkDuplicate() == 2)
            {
                MessageBox.Show("Không Có Mã Đó Để Thay Đổi Liên Quan", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaCongViec.Text = "";
                return;
            }
            else
            {
                CongViecDTO ob = checkData();
                if (ob != null)
                {
                    B_CongViec.saveCV(ob, sys.UPDATE);
                    MessageBox.Show("Sửa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dt = B_CongViec.GetAllCV();
                    dgvCongViec.DataSource = dt;
                    clearTxt();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (checkDuplicate() == 2)
            {
                MessageBox.Show("Không Có Mã Đó Để Thay Đổi Liên Quan", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaCongViec.Text = "";
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn Muốn Xóa Không ?", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    B_CongDung.DeleteCD(txtMaCongViec.Text);
                    MessageBox.Show("Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvCongViec.DataSource = B_CongDung.GetAllCD();
                    dt = B_CongDung.GetAllCD();
                    clearTxt();
                }
            }
        }

        private void frmChitietCongviec_Load(object sender, EventArgs e)
        {
            dt = B_CongViec.GetAllCV();
            dgvCongViec.DataSource = dt;
        }
        private void dgvCongViec_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dgvCongViec.Rows.Count - 1)
            {
                frmChitietCongviec f1 = new frmChitietCongviec();
                Handling.FormHandling.PreventFormMultipleTimes("Công Việc", f1, "Công việc");
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            Handling.ExcelAutomate.automateEx(dgvCongViec, "Thông Tin Các Công Việc");
        }

        private void lblIntoCongViec_Click(object sender, EventArgs e)
        {
            frmChitietCongviec f1 = new frmChitietCongviec();
            Handling.FormHandling.PreventFormMultipleTimes(f1, "Công việc");
        }

        private void dgvCongViec_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Handling.FormHandling.changeColorRowDataGridView(dgvCongViec);
        }
        /* in form*/
        public void clearTxt()
        {
            txtMaCongViec.Text = txtTenCongViec.Text = "";
        }
        private CongViecDTO checkData()
        {
            string ma = txtMaCongViec.Text;
            string ten = txtTenCongViec.Text;
            string z = string.Join("", txtMaCongViec.Text.Where(char.IsDigit));
            if (txtMaCongViec.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn Chưa Nhập Mã Công Việc", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaCongViec.Focus();
                return null;
            }
            else if (txtTenCongViec.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn Chưa Nhập Tên Công Việc", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenCongViec.Focus();
                txtTenCongViec.Focus();
                return null;
            }
            else if (txtMaCongViec.Text.Contains("CV") == false)
            {
                MessageBox.Show("Nhập Theo Định Dạng Là \"CV\"", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                 txtMaCongViec.Focus();                 return null;
            }             else if (z == "")
            {
                MessageBox.Show("Nhập Theo Định Dạng Là \"CV\" và Thêm Số Đằng Sau", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                 txtMaCongViec.Focus();                 return null;
            }
            CongViecDTO dto = new CongViecDTO(ma, Handling.FormHandling.formatString(ten));
            return dto;
        }
        public int checkDuplicate() // insert
        {
            IEnumerable<DataRow> dtrow = default;
            dtrow = dt.AsEnumerable().Where(x => x.Field<string>("MaCV") == txtMaCongViec.Text);
            return dtrow.Count() > 0 ? 1 : 2;
        }
    }
}
