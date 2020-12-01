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
    public partial class frmChitietNhomhanghoa : Form
    {
        static SystemConstant sys = new SystemConstant();
        DataTable dt;
        public frmChitietNhomhanghoa()
        {
            InitializeComponent();
            frmChitietNhomhanghoa_Load(null, null);
            if (frmLogin.session.role == 2)
            {
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnIn.Enabled = false;
            }
            Handling.FormHandling.clearBorderGroupBox(gbxChitiet);             Handling.FormHandling.clearBorderGroupBox(gbxChucnang);
        }

        private void frmChitietNhomhanghoa_Load(object sender, EventArgs e)
        {
            dt = B_NhomHang.GetAllNhomHang();
            dgvNhomHang.DataSource = dt;
        }
        private void btnCreateCode_Click(object sender, EventArgs e)
        {
            string newCode = Handling.InstanceHandling.AutoCreateKey(dt, "MaNhom", "CL");
            txtMaNhom.Text = newCode;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            NhomHangDTO ob = checkData();
            if (ob != null)
            {
                if (checkDuplicated() == 1)
                {
                    MessageBox.Show("Mã Nhóm Hàng Hóa Trùng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaNhom.Focus();
                    return;
                }
                else
                {
                    B_NhomHang.saveNH(ob, sys.INSERT);
                    MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dt = B_NhomHang.GetAllNhomHang();
                    dgvNhomHang.DataSource = dt;
                    clearTxt();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (checkDuplicated() == 2)
            {
                MessageBox.Show("Không Có Mã Đó Để Thay Đổi Liên Quan", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNhom.Text = "";
                return;
            }
            else
            {
                NhomHangDTO ob = checkData();
                if (ob != null)
                {
                    B_NhomHang.saveNH(ob, sys.UPDATE);
                    MessageBox.Show("Sửa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dt = B_NhomHang.GetAllNhomHang();
                    dgvNhomHang.DataSource = dt;
                    clearTxt();
                }
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (checkDuplicated() == 2)
            {
                MessageBox.Show("Không Có Mã Đó Để Thay Đổi Liên Quan", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNhom.Text = "";
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn Muốn Xóa Không ?", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    B_NhomHang.DeleteNhomHang(txtMaNhom.Text);
                    MessageBox.Show("Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvNhomHang.DataSource = B_NhomHang.GetAllNhomHang();
                    dt = B_NhomHang.GetAllNhomHang();
                    clearTxt();
                }
            }
        }
        private void dgvNhomHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvNhomHang.Rows[e.RowIndex];
                txtMaNhom.Text = row.Cells[0].Value.ToString();
                txtTenNhom.Text = row.Cells[1].Value.ToString();
            }
            catch
            {
            }
        }

        private void dgvNhomHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dgvNhomHang.Rows.Count - 1)
            {
                frmChitietNhomhanghoa f1 = new frmChitietNhomhanghoa();
                Handling.FormHandling.PreventFormMultipleTimes("Nhóm Hàng", f1, "Nhóm hàng hóa");
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            Handling.ExcelAutomate.automateEx(dgvNhomHang, "Thông Tin Nhóm Hàng Hóa");
        }

        private void lblIntoNhomHangHoa_Click(object sender, EventArgs e)
        {
            frmChitietNhomhanghoa f1 = new frmChitietNhomhanghoa();
            Handling.FormHandling.PreventFormMultipleTimes(f1, "Nhóm hàng hóa");
        }

        private void dgvNhomHang_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Handling.FormHandling.changeColorRowDataGridView(dgvNhomHang);
        }
        /* in form*/
        private NhomHangDTO checkData()
        {
            string ma = txtMaNhom.Text;
            string ten = txtTenNhom.Text;
            string z = string.Join("", txtMaNhom.Text.Where(char.IsDigit));
            if (txtMaNhom.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn Chưa Nhập Mã Nhóm Hàng Hóa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNhom.Focus();
                return null;
            }
            else if (txtTenNhom.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn Chưa Nhập Tên Nhóm Hàng Hóa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenNhom.Focus();
                return null;
            }
            else if (txtMaNhom.Text.Contains("CL") == false)
            {
                MessageBox.Show("Nhập Theo Định Dạng Là \"CL\"", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                 txtMaNhom.Focus();                 return null;
            }             else if (z == "")
            {
                MessageBox.Show("Nhập Theo Định Dạng Là \"CL\" và Thêm Số Đằng Sau", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                 txtMaNhom.Focus();                 return null;
            }
            NhomHangDTO dto = new NhomHangDTO(ma, ten);
            return dto;
        }
        public int checkDuplicated() // insert
        {
            IEnumerable<DataRow> dtrow = default;
            dtrow = dt.AsEnumerable().Where(x => x.Field<string>("MaNhom") == txtMaNhom.Text);
            return dtrow.Count() > 0 ? 1 : 2;
        }
        public void clearTxt()
        {
            txtMaNhom.Text = txtTenNhom.Text = "";
        }
    }
}
